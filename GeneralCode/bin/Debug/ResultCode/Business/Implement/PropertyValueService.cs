using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PropertyValueService : IPropertyValueService
{
private readonly IPropertyValueDataAccess _PropertyValueDataAccess;
public PropertyValueService(IPropertyValueDataAccess PropertyValueDataAccess)
{
_PropertyValueDataAccess = PropertyValueDataAccess;
}
public List<PropertyValue> SelectAll()
{
	return _PropertyValueDataAccess.SelectAll();
}
public PropertyValue SelectByKey(int Id)
{
	return _PropertyValueDataAccess.SelectByKey(Id);
}
public BaseResponse Create_PropertyValue(PropertyValue objPropertyValue)
{
	return _PropertyValueDataAccess.Create_PropertyValue(objPropertyValue);
}
public BaseResponse Update_PropertyValue(PropertyValue objPropertyValue)
{
	return _PropertyValueDataAccess.Update_PropertyValue(objPropertyValue);
}
public BaseResponse Update_PropertyValue2(PropertyValue objPropertyValue)
{
	return _PropertyValueDataAccess.Update_PropertyValue2(objPropertyValue);
}
public List<PropertyValue> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PropertyValueDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<PropertyValue> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PropertyValueDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _PropertyValueDataAccess.DeleteByKey(Id);
}
}
}
