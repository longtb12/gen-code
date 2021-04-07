using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class sysdiagramsDataAccess : IsysdiagramsDataAccess
{
private readonly ICommonRepository _commonRepository;
public sysdiagramsDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<sysdiagrams> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<sysdiagrams>("sysdiagrams_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public sysdiagrams SelectByKey(int diagram_id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("diagram_id", diagram_id)
			};
			return _commonRepository.GetObjectByStoredProcedure<sysdiagrams>("sysdiagrams_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_sysdiagrams(sysdiagrams objsysdiagrams)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("name", objsysdiagrams.name),
			new KeyValuePair<string, object>("principal_id", objsysdiagrams.principal_id),
			new KeyValuePair<string, object>("version", objsysdiagrams.version),
			new KeyValuePair<string, object>("definition", objsysdiagrams.definition)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("sysdiagrams_Insert","diagram_id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_sysdiagrams(sysdiagrams objsysdiagrams)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("name", objsysdiagrams.name),
			new KeyValuePair<string, object>("principal_id", objsysdiagrams.principal_id),
			new KeyValuePair<string, object>("diagram_id", objsysdiagrams.diagram_id),
			new KeyValuePair<string, object>("version", objsysdiagrams.version),
			new KeyValuePair<string, object>("definition", objsysdiagrams.definition)
};
objReturn.Success =_commonRepository.ExcuteStore("sysdiagrams_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_sysdiagrams2(sysdiagrams objsysdiagrams)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("name", objsysdiagrams.name),
			new KeyValuePair<string, object>("principal_id", objsysdiagrams.principal_id),
			new KeyValuePair<string, object>("diagram_id", objsysdiagrams.diagram_id),
			new KeyValuePair<string, object>("version", objsysdiagrams.version),
			new KeyValuePair<string, object>("definition", objsysdiagrams.definition)
};
objReturn.Success =_commonRepository.ExcuteStore("sysdiagrams_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<sysdiagrams> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<sysdiagrams>("sysdiagrams_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<sysdiagrams> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<sysdiagrams>("sysdiagrams_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int diagram_id)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("diagram_id", diagram_id)
			};
			 objReturn= _commonRepository.ExcuteStore("sysdiagrams_DeleteByKey",arg);
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
