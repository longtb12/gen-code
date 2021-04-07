using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ActionDataAccess : IActionDataAccess
{
private readonly ICommonRepository _commonRepository;
public ActionDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Action> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Action>("Action_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Action SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Action>("Action_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Action(Action objAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("ActionName", objAction.ActionName),
			new KeyValuePair<string, object>("ControllerName", objAction.ControllerName),
			new KeyValuePair<string, object>("AreaName", objAction.AreaName),
			new KeyValuePair<string, object>("Order", objAction.Order),
			new KeyValuePair<string, object>("Deleted", objAction.Deleted),
			new KeyValuePair<string, object>("Actived", objAction.Actived),
			new KeyValuePair<string, object>("CreatorId", objAction.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objAction.UpdatorId),
			new KeyValuePair<string, object>("DisplayName", objAction.DisplayName)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Action_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Action(Action objAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objAction.Id),
			new KeyValuePair<string, object>("ActionName", objAction.ActionName),
			new KeyValuePair<string, object>("ControllerName", objAction.ControllerName),
			new KeyValuePair<string, object>("AreaName", objAction.AreaName),
			new KeyValuePair<string, object>("Order", objAction.Order),
			new KeyValuePair<string, object>("Deleted", objAction.Deleted),
			new KeyValuePair<string, object>("Actived", objAction.Actived),
			new KeyValuePair<string, object>("CreatorId", objAction.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objAction.UpdatorId),
			new KeyValuePair<string, object>("DisplayName", objAction.DisplayName)
};
objReturn.Success =_commonRepository.ExcuteStore("Action_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Action2(Action objAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objAction.Id),
			new KeyValuePair<string, object>("ActionName", objAction.ActionName),
			new KeyValuePair<string, object>("ControllerName", objAction.ControllerName),
			new KeyValuePair<string, object>("AreaName", objAction.AreaName),
			new KeyValuePair<string, object>("Order", objAction.Order),
			new KeyValuePair<string, object>("Deleted", objAction.Deleted),
			new KeyValuePair<string, object>("Actived", objAction.Actived),
			new KeyValuePair<string, object>("CreatorId", objAction.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objAction.UpdatorId),
			new KeyValuePair<string, object>("DisplayName", objAction.DisplayName)
};
objReturn.Success =_commonRepository.ExcuteStore("Action_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Action> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Action>("Action_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Action> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Action>("Action_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Action_DeleteByKey",arg);
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
