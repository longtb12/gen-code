using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PropertyLanguageDataAccess : IPropertyLanguageDataAccess
{
private readonly ICommonRepository _commonRepository;
public PropertyLanguageDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<PropertyLanguage> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<PropertyLanguage>("PropertyLanguage_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public PropertyLanguage SelectByKey(int LanguageId, int PropertyId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("LanguageId", LanguageId),
			new KeyValuePair<string, object>("PropertyId", PropertyId)
			};
			return _commonRepository.GetObjectByStoredProcedure<PropertyLanguage>("PropertyLanguage_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_PropertyLanguage(PropertyLanguage objPropertyLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objPropertyLanguage.LanguageId),
			new KeyValuePair<string, object>("PropertyId", objPropertyLanguage.PropertyId),
			new KeyValuePair<string, object>("DisplayName", objPropertyLanguage.DisplayName),
			new KeyValuePair<string, object>("DefaultValue", objPropertyLanguage.DefaultValue)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("PropertyLanguage_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PropertyLanguage(PropertyLanguage objPropertyLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objPropertyLanguage.LanguageId),
			new KeyValuePair<string, object>("PropertyId", objPropertyLanguage.PropertyId),
			new KeyValuePair<string, object>("DisplayName", objPropertyLanguage.DisplayName),
			new KeyValuePair<string, object>("DefaultValue", objPropertyLanguage.DefaultValue)
};
objReturn.Success =_commonRepository.ExcuteStore("PropertyLanguage_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PropertyLanguage2(PropertyLanguage objPropertyLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objPropertyLanguage.LanguageId),
			new KeyValuePair<string, object>("PropertyId", objPropertyLanguage.PropertyId),
			new KeyValuePair<string, object>("DisplayName", objPropertyLanguage.DisplayName),
			new KeyValuePair<string, object>("DefaultValue", objPropertyLanguage.DefaultValue)
};
objReturn.Success =_commonRepository.ExcuteStore("PropertyLanguage_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<PropertyLanguage> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<PropertyLanguage>("PropertyLanguage_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<PropertyLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<PropertyLanguage>("PropertyLanguage_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int LanguageId, int PropertyId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("LanguageId", LanguageId),
			new KeyValuePair<string, object>("PropertyId", PropertyId)
			};
			 objReturn= _commonRepository.ExcuteStore("PropertyLanguage_DeleteByKey",arg);
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
