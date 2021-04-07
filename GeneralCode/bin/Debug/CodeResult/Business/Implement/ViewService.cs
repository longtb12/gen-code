using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ViewService : IViewService
{
private readonly IViewDataAccess _ViewDataAccess;
public ViewService(IViewDataAccess ViewDataAccess)
{
_ViewDataAccess = ViewDataAccess;
}
public List<View> SelectAll()
{
	return _ViewDataAccess.SelectAll();
}
public View SelectByKey(int Id)
{
	return _ViewDataAccess.SelectByKey(Id);
}
public BaseResponse Create_View(View objView)
{
	return _ViewDataAccess.Create_View(objView);
}
public BaseResponse Update_View(View objView)
{
	return _ViewDataAccess.Update_View(objView);
}
public BaseResponse Update_View2(View objView)
{
	return _ViewDataAccess.Update_View2(objView);
}
public List<View> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ViewDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<View> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ViewDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _ViewDataAccess.DeleteByKey(Id);
}
}
}
