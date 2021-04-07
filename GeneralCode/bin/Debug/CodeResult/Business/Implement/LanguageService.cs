using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class LanguageService : ILanguageService
{
private readonly ILanguageDataAccess _LanguageDataAccess;
public LanguageService(ILanguageDataAccess LanguageDataAccess)
{
_LanguageDataAccess = LanguageDataAccess;
}
public List<Language> SelectAll()
{
	return _LanguageDataAccess.SelectAll();
}
public Language SelectByKey(int Id)
{
	return _LanguageDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Language(Language objLanguage)
{
	return _LanguageDataAccess.Create_Language(objLanguage);
}
public BaseResponse Update_Language(Language objLanguage)
{
	return _LanguageDataAccess.Update_Language(objLanguage);
}
public BaseResponse Update_Language2(Language objLanguage)
{
	return _LanguageDataAccess.Update_Language2(objLanguage);
}
public List<Language> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _LanguageDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Language> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _LanguageDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _LanguageDataAccess.DeleteByKey(Id);
}
}
}
