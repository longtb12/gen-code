using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PropertyDataAccess : IPropertyDataAccess
{
private readonly ICommonRepository _commonRepository;
public PropertyDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Property> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Property>("Property_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Property SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Property>("Property_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Property(Property objProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Name", objProperty.Name),
			new KeyValuePair<string, object>("DataType", objProperty.DataType),
			new KeyValuePair<string, object>("Length", objProperty.Length),
			new KeyValuePair<string, object>("Order", objProperty.Order),
			new KeyValuePair<string, object>("Deleted", objProperty.Deleted),
			new KeyValuePair<string, object>("Required", objProperty.Required),
			new KeyValuePair<string, object>("MultiSelect", objProperty.MultiSelect),
			new KeyValuePair<string, object>("MultiLanguage", objProperty.MultiLanguage),
			new KeyValuePair<string, object>("Description", objProperty.Description),
			new KeyValuePair<string, object>("Active", objProperty.Active)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Property_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Property(Property objProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objProperty.Id),
			new KeyValuePair<string, object>("Name", objProperty.Name),
			new KeyValuePair<string, object>("DataType", objProperty.DataType),
			new KeyValuePair<string, object>("Length", objProperty.Length),
			new KeyValuePair<string, object>("Order", objProperty.Order),
			new KeyValuePair<string, object>("Deleted", objProperty.Deleted),
			new KeyValuePair<string, object>("Required", objProperty.Required),
			new KeyValuePair<string, object>("MultiSelect", objProperty.MultiSelect),
			new KeyValuePair<string, object>("MultiLanguage", objProperty.MultiLanguage),
			new KeyValuePair<string, object>("Description", objProperty.Description),
			new KeyValuePair<string, object>("Active", objProperty.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("Property_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Property2(Property objProperty)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objProperty.Id),
			new KeyValuePair<string, object>("Name", objProperty.Name),
			new KeyValuePair<string, object>("DataType", objProperty.DataType),
			new KeyValuePair<string, object>("Length", objProperty.Length),
			new KeyValuePair<string, object>("Order", objProperty.Order),
			new KeyValuePair<string, object>("Deleted", objProperty.Deleted),
			new KeyValuePair<string, object>("Required", objProperty.Required),
			new KeyValuePair<string, object>("MultiSelect", objProperty.MultiSelect),
			new KeyValuePair<string, object>("MultiLanguage", objProperty.MultiLanguage),
			new KeyValuePair<string, object>("Description", objProperty.Description),
			new KeyValuePair<string, object>("Active", objProperty.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("Property_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Property> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Property>("Property_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Property> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Property>("Property_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Property_DeleteByKey",arg);
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
