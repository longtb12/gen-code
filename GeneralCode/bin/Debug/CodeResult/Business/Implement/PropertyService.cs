using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PropertyService : IPropertyService
{
private readonly IPropertyDataAccess _PropertyDataAccess;
public PropertyService(IPropertyDataAccess PropertyDataAccess)
{
_PropertyDataAccess = PropertyDataAccess;
}
public List<Property> SelectAll()
{
	return _PropertyDataAccess.SelectAll();
}
public Property SelectByKey(int Id)
{
	return _PropertyDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Property(Property objProperty)
{
	return _PropertyDataAccess.Create_Property(objProperty);
}
public BaseResponse Update_Property(Property objProperty)
{
	return _PropertyDataAccess.Update_Property(objProperty);
}
public BaseResponse Update_Property2(Property objProperty)
{
	return _PropertyDataAccess.Update_Property2(objProperty);
}
public List<Property> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PropertyDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Property> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PropertyDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _PropertyDataAccess.DeleteByKey(Id);
}
}
}
