using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class RoleActionService : IRoleActionService
{
private readonly IRoleActionDataAccess _RoleActionDataAccess;
public RoleActionService(IRoleActionDataAccess RoleActionDataAccess)
{
_RoleActionDataAccess = RoleActionDataAccess;
}
public List<RoleAction> SelectAll()
{
	return _RoleActionDataAccess.SelectAll();
}
public RoleAction SelectByKey(int RoleId, int ActionId)
{
	return _RoleActionDataAccess.SelectByKey(RoleId, ActionId);
}
public BaseResponse Create_RoleAction(RoleAction objRoleAction)
{
	return _RoleActionDataAccess.Create_RoleAction(objRoleAction);
}
public BaseResponse Update_RoleAction(RoleAction objRoleAction)
{
	return _RoleActionDataAccess.Update_RoleAction(objRoleAction);
}
public BaseResponse Update_RoleAction2(RoleAction objRoleAction)
{
	return _RoleActionDataAccess.Update_RoleAction2(objRoleAction);
}
public List<RoleAction> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _RoleActionDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<RoleAction> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _RoleActionDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int RoleId, int ActionId)
{
	return _RoleActionDataAccess.DeleteByKey(RoleId, ActionId);
}
}
}
