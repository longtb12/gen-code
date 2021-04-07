using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class sysdiagramsService : IsysdiagramsService
{
private readonly IsysdiagramsDataAccess _sysdiagramsDataAccess;
public sysdiagramsService(IsysdiagramsDataAccess sysdiagramsDataAccess)
{
_sysdiagramsDataAccess = sysdiagramsDataAccess;
}
public List<sysdiagrams> SelectAll()
{
	return _sysdiagramsDataAccess.SelectAll();
}
public sysdiagrams SelectByKey(int diagram_id)
{
	return _sysdiagramsDataAccess.SelectByKey(diagram_id);
}
public BaseResponse Create_sysdiagrams(sysdiagrams objsysdiagrams)
{
	return _sysdiagramsDataAccess.Create_sysdiagrams(objsysdiagrams);
}
public BaseResponse Update_sysdiagrams(sysdiagrams objsysdiagrams)
{
	return _sysdiagramsDataAccess.Update_sysdiagrams(objsysdiagrams);
}
public BaseResponse Update_sysdiagrams2(sysdiagrams objsysdiagrams)
{
	return _sysdiagramsDataAccess.Update_sysdiagrams2(objsysdiagrams);
}
public List<sysdiagrams> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _sysdiagramsDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<sysdiagrams> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _sysdiagramsDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int diagram_id)
{
	return _sysdiagramsDataAccess.DeleteByKey(diagram_id);
}
}
}
