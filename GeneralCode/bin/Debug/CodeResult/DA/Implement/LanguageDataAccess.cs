using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class LanguageDataAccess : ILanguageDataAccess
{
private readonly ICommonRepository _commonRepository;
public LanguageDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Language> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Language>("Language_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Language SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Language>("Language_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Language(Language objLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Name", objLanguage.Name),
			new KeyValuePair<string, object>("Default", objLanguage.Default),
			new KeyValuePair<string, object>("Image", objLanguage.Image),
			new KeyValuePair<string, object>("Order", objLanguage.Order),
			new KeyValuePair<string, object>("Deleted", objLanguage.Deleted),
			new KeyValuePair<string, object>("Actived", objLanguage.Actived)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Language_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Language(Language objLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objLanguage.Id),
			new KeyValuePair<string, object>("Name", objLanguage.Name),
			new KeyValuePair<string, object>("Default", objLanguage.Default),
			new KeyValuePair<string, object>("Image", objLanguage.Image),
			new KeyValuePair<string, object>("Order", objLanguage.Order),
			new KeyValuePair<string, object>("Deleted", objLanguage.Deleted),
			new KeyValuePair<string, object>("Actived", objLanguage.Actived)
};
objReturn.Success =_commonRepository.ExcuteStore("Language_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Language2(Language objLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objLanguage.Id),
			new KeyValuePair<string, object>("Name", objLanguage.Name),
			new KeyValuePair<string, object>("Default", objLanguage.Default),
			new KeyValuePair<string, object>("Image", objLanguage.Image),
			new KeyValuePair<string, object>("Order", objLanguage.Order),
			new KeyValuePair<string, object>("Deleted", objLanguage.Deleted),
			new KeyValuePair<string, object>("Actived", objLanguage.Actived)
};
objReturn.Success =_commonRepository.ExcuteStore("Language_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Language> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Language>("Language_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Language> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Language>("Language_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Language_DeleteByKey",arg);
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
