using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class CategoryPropertyDataAccess : ICategoryPropertyDataAccess
{
private readonly ICommonRepository _commonRepository;
public CategoryPropertyDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<CategoryProperty> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<CategoryProperty>("CategoryProperty_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public CategoryProperty SelectByKey(int CategoryId, int PropertyId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("CategoryId", CategoryId),
			new KeyValuePair<string, object>("PropertyId", PropertyId)
			};
			return _commonRepository.GetObjectByStoredProcedure<CategoryProperty>("CategoryProperty_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_CategoryProperty(CategoryProperty objCategoryProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("CategoryId", objCategoryProperty.CategoryId),
			new KeyValuePair<string, object>("PropertyId", objCategoryProperty.PropertyId),
			new KeyValuePair<string, object>("Active", objCategoryProperty.Active),
			new KeyValuePair<string, object>("CreatorId", objCategoryProperty.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objCategoryProperty.CreateDate),
			new KeyValuePair<string, object>("UpdatetorId", objCategoryProperty.UpdatetorId),
			new KeyValuePair<string, object>("UpdateDate", objCategoryProperty.UpdateDate)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("CategoryProperty_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_CategoryProperty(CategoryProperty objCategoryProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("CategoryId", objCategoryProperty.CategoryId),
			new KeyValuePair<string, object>("PropertyId", objCategoryProperty.PropertyId),
			new KeyValuePair<string, object>("Active", objCategoryProperty.Active),
			new KeyValuePair<string, object>("CreatorId", objCategoryProperty.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objCategoryProperty.CreateDate),
			new KeyValuePair<string, object>("UpdatetorId", objCategoryProperty.UpdatetorId),
			new KeyValuePair<string, object>("UpdateDate", objCategoryProperty.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("CategoryProperty_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_CategoryProperty2(CategoryProperty objCategoryProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("CategoryId", objCategoryProperty.CategoryId),
			new KeyValuePair<string, object>("PropertyId", objCategoryProperty.PropertyId),
			new KeyValuePair<string, object>("Active", objCategoryProperty.Active),
			new KeyValuePair<string, object>("CreatorId", objCategoryProperty.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objCategoryProperty.CreateDate),
			new KeyValuePair<string, object>("UpdatetorId", objCategoryProperty.UpdatetorId),
			new KeyValuePair<string, object>("UpdateDate", objCategoryProperty.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("CategoryProperty_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<CategoryProperty> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<CategoryProperty>("CategoryProperty_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<CategoryProperty> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<CategoryProperty>("CategoryProperty_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int CategoryId, int PropertyId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("CategoryId", CategoryId),
			new KeyValuePair<string, object>("PropertyId", PropertyId)
			};
			 objReturn= _commonRepository.ExcuteStore("CategoryProperty_DeleteByKey",arg);
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
