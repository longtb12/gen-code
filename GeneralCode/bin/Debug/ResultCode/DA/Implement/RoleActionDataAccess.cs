using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class RoleActionDataAccess : IRoleActionDataAccess
{
private readonly ICommonRepository _commonRepository;
public RoleActionDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<RoleAction> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<RoleAction>("RoleAction_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public RoleAction SelectByKey(int RoleId, int ActionId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("RoleId", RoleId),
			new KeyValuePair<string, object>("ActionId", ActionId)
			};
			return _commonRepository.GetObjectByStoredProcedure<RoleAction>("RoleAction_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_RoleAction(RoleAction objRoleAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("RoleId", objRoleAction.RoleId),
			new KeyValuePair<string, object>("ActionId", objRoleAction.ActionId),
			new KeyValuePair<string, object>("CreatorId", objRoleAction.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRoleAction.CreateDate)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("RoleAction_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_RoleAction(RoleAction objRoleAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("RoleId", objRoleAction.RoleId),
			new KeyValuePair<string, object>("ActionId", objRoleAction.ActionId),
			new KeyValuePair<string, object>("CreatorId", objRoleAction.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRoleAction.CreateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("RoleAction_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_RoleAction2(RoleAction objRoleAction)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("RoleId", objRoleAction.RoleId),
			new KeyValuePair<string, object>("ActionId", objRoleAction.ActionId),
			new KeyValuePair<string, object>("CreatorId", objRoleAction.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRoleAction.CreateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("RoleAction_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<RoleAction> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<RoleAction>("RoleAction_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<RoleAction> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<RoleAction>("RoleAction_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int RoleId, int ActionId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("RoleId", RoleId),
			new KeyValuePair<string, object>("ActionId", ActionId)
			};
			 objReturn= _commonRepository.ExcuteStore("RoleAction_DeleteByKey",arg);
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
