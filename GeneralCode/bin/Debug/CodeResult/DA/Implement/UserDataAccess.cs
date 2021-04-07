using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class UserDataAccess : IUserDataAccess
{
private readonly ICommonRepository _commonRepository;
public UserDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<User> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<User>("User_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public User SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<User>("User_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_User(User objUser)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("UserName", objUser.UserName),
			new KeyValuePair<string, object>("Password", objUser.Password),
			new KeyValuePair<string, object>("Actived", objUser.Actived),
			new KeyValuePair<string, object>("Status", objUser.Status),
			new KeyValuePair<string, object>("DisplayName", objUser.DisplayName),
			new KeyValuePair<string, object>("Email", objUser.Email),
			new KeyValuePair<string, object>("Phone", objUser.Phone),
			new KeyValuePair<string, object>("CreateDate", objUser.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objUser.UpdateDate)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("User_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_User(User objUser)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objUser.Id),
			new KeyValuePair<string, object>("UserName", objUser.UserName),
			new KeyValuePair<string, object>("Password", objUser.Password),
			new KeyValuePair<string, object>("Actived", objUser.Actived),
			new KeyValuePair<string, object>("Status", objUser.Status),
			new KeyValuePair<string, object>("DisplayName", objUser.DisplayName),
			new KeyValuePair<string, object>("Email", objUser.Email),
			new KeyValuePair<string, object>("Phone", objUser.Phone),
			new KeyValuePair<string, object>("CreateDate", objUser.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objUser.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("User_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_User2(User objUser)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objUser.Id),
			new KeyValuePair<string, object>("UserName", objUser.UserName),
			new KeyValuePair<string, object>("Password", objUser.Password),
			new KeyValuePair<string, object>("Actived", objUser.Actived),
			new KeyValuePair<string, object>("Status", objUser.Status),
			new KeyValuePair<string, object>("DisplayName", objUser.DisplayName),
			new KeyValuePair<string, object>("Email", objUser.Email),
			new KeyValuePair<string, object>("Phone", objUser.Phone),
			new KeyValuePair<string, object>("CreateDate", objUser.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objUser.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("User_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<User> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<User>("User_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<User> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<User>("User_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("User_DeleteByKey",arg);
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
