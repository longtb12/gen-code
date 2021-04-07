using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PortalsService : IPortalsService
{
private readonly IPortalsDataAccess _PortalsDataAccess;
public PortalsService(IPortalsDataAccess PortalsDataAccess)
{
_PortalsDataAccess = PortalsDataAccess;
}
public List<Portals> SelectAll()
{
	return _PortalsDataAccess.SelectAll();
}
public Portals SelectByKey(int Id)
{
	return _PortalsDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Portals(Portals objPortals)
{
	return _PortalsDataAccess.Create_Portals(objPortals);
}
public BaseResponse Update_Portals(Portals objPortals)
{
	return _PortalsDataAccess.Update_Portals(objPortals);
}
public BaseResponse Update_Portals2(Portals objPortals)
{
	return _PortalsDataAccess.Update_Portals2(objPortals);
}
public List<Portals> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PortalsDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Portals> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PortalsDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _PortalsDataAccess.DeleteByKey(Id);
}
}
}
