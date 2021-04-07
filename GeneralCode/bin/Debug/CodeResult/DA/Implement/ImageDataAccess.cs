using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ImageDataAccess : IImageDataAccess
{
private readonly ICommonRepository _commonRepository;
public ImageDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Image> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Image>("Image_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Image SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Image>("Image_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Image(Image objImage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("ItemId", objImage.ItemId),
			new KeyValuePair<string, object>("ImageUrl", objImage.ImageUrl),
			new KeyValuePair<string, object>("Order", objImage.Order),
			new KeyValuePair<string, object>("Active", objImage.Active)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Image_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Image(Image objImage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objImage.Id),
			new KeyValuePair<string, object>("ItemId", objImage.ItemId),
			new KeyValuePair<string, object>("ImageUrl", objImage.ImageUrl),
			new KeyValuePair<string, object>("Order", objImage.Order),
			new KeyValuePair<string, object>("Active", objImage.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("Image_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Image2(Image objImage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objImage.Id),
			new KeyValuePair<string, object>("ItemId", objImage.ItemId),
			new KeyValuePair<string, object>("ImageUrl", objImage.ImageUrl),
			new KeyValuePair<string, object>("Order", objImage.Order),
			new KeyValuePair<string, object>("Active", objImage.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("Image_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Image> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Image>("Image_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Image> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Image>("Image_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Image_DeleteByKey",arg);
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
