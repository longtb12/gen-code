using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class RoleDataAccess : IRoleDataAccess
{
private readonly ICommonRepository _commonRepository;
public RoleDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Role> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Role>("Role_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Role SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Role>("Role_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Role(Role objRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("RoleName", objRole.RoleName),
			new KeyValuePair<string, object>("Actived", objRole.Actived),
			new KeyValuePair<string, object>("Description", objRole.Description),
			new KeyValuePair<string, object>("Order", objRole.Order),
			new KeyValuePair<string, object>("CreatorId", objRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRole.CreateDate),
			new KeyValuePair<string, object>("Deleted", objRole.Deleted)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Role_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Role(Role objRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objRole.Id),
			new KeyValuePair<string, object>("RoleName", objRole.RoleName),
			new KeyValuePair<string, object>("Actived", objRole.Actived),
			new KeyValuePair<string, object>("Description", objRole.Description),
			new KeyValuePair<string, object>("Order", objRole.Order),
			new KeyValuePair<string, object>("CreatorId", objRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRole.CreateDate),
			new KeyValuePair<string, object>("Deleted", objRole.Deleted)
};
objReturn.Success =_commonRepository.ExcuteStore("Role_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Role2(Role objRole)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objRole.Id),
			new KeyValuePair<string, object>("RoleName", objRole.RoleName),
			new KeyValuePair<string, object>("Actived", objRole.Actived),
			new KeyValuePair<string, object>("Description", objRole.Description),
			new KeyValuePair<string, object>("Order", objRole.Order),
			new KeyValuePair<string, object>("CreatorId", objRole.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objRole.CreateDate),
			new KeyValuePair<string, object>("Deleted", objRole.Deleted)
};
objReturn.Success =_commonRepository.ExcuteStore("Role_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Role> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Role>("Role_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Role> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Role>("Role_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Role_DeleteByKey",arg);
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
