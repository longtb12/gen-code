using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PropertyValueDataAccess : IPropertyValueDataAccess
{
private readonly ICommonRepository _commonRepository;
public PropertyValueDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<PropertyValue> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<PropertyValue>("PropertyValue_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public PropertyValue SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<PropertyValue>("PropertyValue_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_PropertyValue(PropertyValue objPropertyValue)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("ItemId", objPropertyValue.ItemId),
			new KeyValuePair<string, object>("PropertyId", objPropertyValue.PropertyId),
			new KeyValuePair<string, object>("LanguageId", objPropertyValue.LanguageId),
			new KeyValuePair<string, object>("Value", objPropertyValue.Value),
			new KeyValuePair<string, object>("Deleted", objPropertyValue.Deleted),
			new KeyValuePair<string, object>("Order", objPropertyValue.Order)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("PropertyValue_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PropertyValue(PropertyValue objPropertyValue)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objPropertyValue.Id),
			new KeyValuePair<string, object>("ItemId", objPropertyValue.ItemId),
			new KeyValuePair<string, object>("PropertyId", objPropertyValue.PropertyId),
			new KeyValuePair<string, object>("LanguageId", objPropertyValue.LanguageId),
			new KeyValuePair<string, object>("Value", objPropertyValue.Value),
			new KeyValuePair<string, object>("Deleted", objPropertyValue.Deleted),
			new KeyValuePair<string, object>("Order", objPropertyValue.Order)
};
objReturn.Success =_commonRepository.ExcuteStore("PropertyValue_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PropertyValue2(PropertyValue objPropertyValue)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objPropertyValue.Id),
			new KeyValuePair<string, object>("ItemId", objPropertyValue.ItemId),
			new KeyValuePair<string, object>("PropertyId", objPropertyValue.PropertyId),
			new KeyValuePair<string, object>("LanguageId", objPropertyValue.LanguageId),
			new KeyValuePair<string, object>("Value", objPropertyValue.Value),
			new KeyValuePair<string, object>("Deleted", objPropertyValue.Deleted),
			new KeyValuePair<string, object>("Order", objPropertyValue.Order)
};
objReturn.Success =_commonRepository.ExcuteStore("PropertyValue_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<PropertyValue> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<PropertyValue>("PropertyValue_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<PropertyValue> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<PropertyValue>("PropertyValue_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("PropertyValue_DeleteByKey",arg);
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
