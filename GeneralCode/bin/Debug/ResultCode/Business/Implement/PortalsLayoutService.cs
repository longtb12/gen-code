using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PortalsLayoutService : IPortalsLayoutService
{
private readonly IPortalsLayoutDataAccess _PortalsLayoutDataAccess;
public PortalsLayoutService(IPortalsLayoutDataAccess PortalsLayoutDataAccess)
{
_PortalsLayoutDataAccess = PortalsLayoutDataAccess;
}
public List<PortalsLayout> SelectAll()
{
	return _PortalsLayoutDataAccess.SelectAll();
}
public PortalsLayout SelectByKey(int PortalId, int LayoutId)
{
	return _PortalsLayoutDataAccess.SelectByKey(PortalId, LayoutId);
}
public BaseResponse Create_PortalsLayout(PortalsLayout objPortalsLayout)
{
	return _PortalsLayoutDataAccess.Create_PortalsLayout(objPortalsLayout);
}
public BaseResponse Update_PortalsLayout(PortalsLayout objPortalsLayout)
{
	return _PortalsLayoutDataAccess.Update_PortalsLayout(objPortalsLayout);
}
public BaseResponse Update_PortalsLayout2(PortalsLayout objPortalsLayout)
{
	return _PortalsLayoutDataAccess.Update_PortalsLayout2(objPortalsLayout);
}
public List<PortalsLayout> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PortalsLayoutDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<PortalsLayout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PortalsLayoutDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int PortalId, int LayoutId)
{
	return _PortalsLayoutDataAccess.DeleteByKey(PortalId, LayoutId);
}
}
}
