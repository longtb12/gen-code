using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ProductDataAccess : IProductDataAccess
{
private readonly ICommonRepository _commonRepository;
public ProductDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Product> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Product>("Product_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Product SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Product>("Product_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Product(Product objProduct)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Cost", objProduct.Cost),
			new KeyValuePair<string, object>("Discount", objProduct.Discount),
			new KeyValuePair<string, object>("Percent", objProduct.Percent),
			new KeyValuePair<string, object>("DateBegin", objProduct.DateBegin),
			new KeyValuePair<string, object>("DateEnd", objProduct.DateEnd),
			new KeyValuePair<string, object>("InStock", objProduct.InStock)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Product_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Product(Product objProduct)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objProduct.Id),
			new KeyValuePair<string, object>("Cost", objProduct.Cost),
			new KeyValuePair<string, object>("Discount", objProduct.Discount),
			new KeyValuePair<string, object>("Percent", objProduct.Percent),
			new KeyValuePair<string, object>("DateBegin", objProduct.DateBegin),
			new KeyValuePair<string, object>("DateEnd", objProduct.DateEnd),
			new KeyValuePair<string, object>("InStock", objProduct.InStock)
};
objReturn.Success =_commonRepository.ExcuteStore("Product_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Product2(Product objProduct)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objProduct.Id),
			new KeyValuePair<string, object>("Cost", objProduct.Cost),
			new KeyValuePair<string, object>("Discount", objProduct.Discount),
			new KeyValuePair<string, object>("Percent", objProduct.Percent),
			new KeyValuePair<string, object>("DateBegin", objProduct.DateBegin),
			new KeyValuePair<string, object>("DateEnd", objProduct.DateEnd),
			new KeyValuePair<string, object>("InStock", objProduct.InStock)
};
objReturn.Success =_commonRepository.ExcuteStore("Product_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Product> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Product>("Product_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Product> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PageIndex", PageIndex ),
			new KeyValuePair<string, object>("PageSize", PageSize ),
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Product>("Product_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int Id)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			 objReturn= _commonRepository.ExcuteStore("Product_DeleteByKey",arg);
		}
	catch (Exception ex)
		{
objReturn.Success=false;
objReturn.Message=ex.ToString();
		}
return objReturn;
}
}
}
