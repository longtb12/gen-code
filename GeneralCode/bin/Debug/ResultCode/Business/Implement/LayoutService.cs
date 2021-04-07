using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class LayoutService : ILayoutService
{
private readonly ILayoutDataAccess _LayoutDataAccess;
public LayoutService(ILayoutDataAccess LayoutDataAccess)
{
_LayoutDataAccess = LayoutDataAccess;
}
public List<Layout> SelectAll()
{
	return _LayoutDataAccess.SelectAll();
}
public Layout SelectByKey(int Id)
{
	return _LayoutDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Layout(Layout objLayout)
{
	return _LayoutDataAccess.Create_Layout(objLayout);
}
public BaseResponse Update_Layout(Layout objLayout)
{
	return _LayoutDataAccess.Update_Layout(objLayout);
}
public BaseResponse Update_Layout2(Layout objLayout)
{
	return _LayoutDataAccess.Update_Layout2(objLayout);
}
public List<Layout> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _LayoutDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Layout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _LayoutDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _LayoutDataAccess.DeleteByKey(Id);
}
}
}
