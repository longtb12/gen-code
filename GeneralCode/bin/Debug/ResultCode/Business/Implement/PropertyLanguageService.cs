using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class PropertyLanguageService : IPropertyLanguageService
{
private readonly IPropertyLanguageDataAccess _PropertyLanguageDataAccess;
public PropertyLanguageService(IPropertyLanguageDataAccess PropertyLanguageDataAccess)
{
_PropertyLanguageDataAccess = PropertyLanguageDataAccess;
}
public List<PropertyLanguage> SelectAll()
{
	return _PropertyLanguageDataAccess.SelectAll();
}
public PropertyLanguage SelectByKey(int LanguageId, int PropertyId)
{
	return _PropertyLanguageDataAccess.SelectByKey(LanguageId, PropertyId);
}
public BaseResponse Create_PropertyLanguage(PropertyLanguage objPropertyLanguage)
{
	return _PropertyLanguageDataAccess.Create_PropertyLanguage(objPropertyLanguage);
}
public BaseResponse Update_PropertyLanguage(PropertyLanguage objPropertyLanguage)
{
	return _PropertyLanguageDataAccess.Update_PropertyLanguage(objPropertyLanguage);
}
public BaseResponse Update_PropertyLanguage2(PropertyLanguage objPropertyLanguage)
{
	return _PropertyLanguageDataAccess.Update_PropertyLanguage2(objPropertyLanguage);
}
public List<PropertyLanguage> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _PropertyLanguageDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<PropertyLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _PropertyLanguageDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int LanguageId, int PropertyId)
{
	return _PropertyLanguageDataAccess.DeleteByKey(LanguageId, PropertyId);
}
}
}
