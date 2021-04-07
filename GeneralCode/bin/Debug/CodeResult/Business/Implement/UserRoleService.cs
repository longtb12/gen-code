using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class UserRoleService : IUserRoleService
{
private readonly IUserRoleDataAccess _UserRoleDataAccess;
public UserRoleService(IUserRoleDataAccess UserRoleDataAccess)
{
_UserRoleDataAccess = UserRoleDataAccess;
}
public List<UserRole> SelectAll()
{
	return _UserRoleDataAccess.SelectAll();
}
public UserRole SelectByKey(int UserId, int RoleId)
{
	return _UserRoleDataAccess.SelectByKey(UserId, RoleId);
}
public BaseResponse Create_UserRole(UserRole objUserRole)
{
	return _UserRoleDataAccess.Create_UserRole(objUserRole);
}
public BaseResponse Update_UserRole(UserRole objUserRole)
{
	return _UserRoleDataAccess.Update_UserRole(objUserRole);
}
public BaseResponse Update_UserRole2(UserRole objUserRole)
{
	return _UserRoleDataAccess.Update_UserRole2(objUserRole);
}
public List<UserRole> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _UserRoleDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<UserRole> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _UserRoleDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int UserId, int RoleId)
{
	return _UserRoleDataAccess.DeleteByKey(UserId, RoleId);
}
}
}
