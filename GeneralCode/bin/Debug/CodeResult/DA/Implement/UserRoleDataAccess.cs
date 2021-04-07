using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class UserRoleDataAccess : IUserRoleDataAccess
{
private readonly ICommonRepository _commonRepository;
public UserRoleDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<UserRole> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<UserRole>("UserRole_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public UserRole SelectByKey(int UserId, int RoleId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("UserId", UserId),
			new KeyValuePair<string, object>("RoleId", RoleId)
			};
			return _commonRepository.GetObjectByStoredProcedure<UserRole>("UserRole_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_UserRole(UserRole objUserRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("UserId", objUserRole.UserId),
			new KeyValuePair<string, object>("RoleId", objUserRole.RoleId),
			new KeyValuePair<string, object>("CreatorId", objUserRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objUserRole.CreateDate)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("UserRole_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_UserRole(UserRole objUserRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("UserId", objUserRole.UserId),
			new KeyValuePair<string, object>("RoleId", objUserRole.RoleId),
			new KeyValuePair<string, object>("CreatorId", objUserRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objUserRole.CreateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("UserRole_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_UserRole2(UserRole objUserRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("UserId", objUserRole.UserId),
			new KeyValuePair<string, object>("RoleId", objUserRole.RoleId),
			new KeyValuePair<string, object>("CreatorId", objUserRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objUserRole.CreateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("UserRole_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<UserRole> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<UserRole>("UserRole_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<UserRole> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<UserRole>("UserRole_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int UserId, int RoleId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("UserId", UserId),
			new KeyValuePair<string, object>("RoleId", RoleId)
			};
			 objReturn= _commonRepository.ExcuteStore("UserRole_DeleteByKey",arg);
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
