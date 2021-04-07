using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class RoleService : IRoleService
{
private readonly IRoleDataAccess _RoleDataAccess;
public RoleService(IRoleDataAccess RoleDataAccess)
{
_RoleDataAccess = RoleDataAccess;
}
public List<Role> SelectAll()
{
	return _RoleDataAccess.SelectAll();
}
public Role SelectByKey(int Id)
{
	return _RoleDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Role(Role objRole)
{
	return _RoleDataAccess.Create_Role(objRole);
}
public BaseResponse Update_Role(Role objRole)
{
	return _RoleDataAccess.Update_Role(objRole);
}
public BaseResponse Update_Role2(Role objRole)
{
	return _RoleDataAccess.Update_Role2(objRole);
}
public List<Role> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _RoleDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Role> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _RoleDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _RoleDataAccess.DeleteByKey(Id);
}
}
}
