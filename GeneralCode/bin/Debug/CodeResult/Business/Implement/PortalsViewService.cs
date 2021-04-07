using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PortalsViewService : IPortalsViewService
{
private readonly IPortalsViewDataAccess _PortalsViewDataAccess;
public PortalsViewService(IPortalsViewDataAccess PortalsViewDataAccess)
{
_PortalsViewDataAccess = PortalsViewDataAccess;
}
public List<PortalsView> SelectAll()
{
	return _PortalsViewDataAccess.SelectAll();
}
public PortalsView SelectByKey(int PortalId, int ViewId)
{
	return _PortalsViewDataAccess.SelectByKey(PortalId, ViewId);
}
public BaseResponse Create_PortalsView(PortalsView objPortalsView)
{
	return _PortalsViewDataAccess.Create_PortalsView(objPortalsView);
}
public BaseResponse Update_PortalsView(PortalsView objPortalsView)
{
	return _PortalsViewDataAccess.Update_PortalsView(objPortalsView);
}
public BaseResponse Update_PortalsView2(PortalsView objPortalsView)
{
	return _PortalsViewDataAccess.Update_PortalsView2(objPortalsView);
}
public List<PortalsView> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PortalsViewDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<PortalsView> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PortalsViewDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int PortalId, int ViewId)
{
	return _PortalsViewDataAccess.DeleteByKey(PortalId, ViewId);
}
}
}
