using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class UserService : IUserService
{
private readonly IUserDataAccess _UserDataAccess;
public UserService(IUserDataAccess UserDataAccess)
{
_UserDataAccess = UserDataAccess;
}
public List<User> SelectAll()
{
	return _UserDataAccess.SelectAll();
}
public User SelectByKey(int Id)
{
	return _UserDataAccess.SelectByKey(Id);
}
public BaseResponse Create_User(User objUser)
{
	return _UserDataAccess.Create_User(objUser);
}
public BaseResponse Update_User(User objUser)
{
	return _UserDataAccess.Update_User(objUser);
}
public BaseResponse Update_User2(User objUser)
{
	return _UserDataAccess.Update_User2(objUser);
}
public List<User> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _UserDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<User> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _UserDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _UserDataAccess.DeleteByKey(Id);
}
}
}
