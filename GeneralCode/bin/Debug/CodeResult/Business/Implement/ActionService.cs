using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ActionService : IActionService
{
private readonly IActionDataAccess _ActionDataAccess;
public ActionService(IActionDataAccess ActionDataAccess)
{
_ActionDataAccess = ActionDataAccess;
}
public List<Action> SelectAll()
{
	return _ActionDataAccess.SelectAll();
}
public Action SelectByKey(int Id)
{
	return _ActionDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Action(Action objAction)
{
	return _ActionDataAccess.Create_Action(objAction);
}
public BaseResponse Update_Action(Action objAction)
{
	return _ActionDataAccess.Update_Action(objAction);
}
public BaseResponse Update_Action2(Action objAction)
{
	return _ActionDataAccess.Update_Action2(objAction);
}
public List<Action> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ActionDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Action> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ActionDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _ActionDataAccess.DeleteByKey(Id);
}
}
}
