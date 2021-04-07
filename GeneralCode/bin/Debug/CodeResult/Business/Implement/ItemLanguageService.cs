using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ItemLanguageService : IItemLanguageService
{
private readonly IItemLanguageDataAccess _ItemLanguageDataAccess;
public ItemLanguageService(IItemLanguageDataAccess ItemLanguageDataAccess)
{
_ItemLanguageDataAccess = ItemLanguageDataAccess;
}
public List<ItemLanguage> SelectAll()
{
	return _ItemLanguageDataAccess.SelectAll();
}
public ItemLanguage SelectByKey(int LanguageId, int ItemId)
{
	return _ItemLanguageDataAccess.SelectByKey(LanguageId, ItemId);
}
public BaseResponse Create_ItemLanguage(ItemLanguage objItemLanguage)
{
	return _ItemLanguageDataAccess.Create_ItemLanguage(objItemLanguage);
}
public BaseResponse Update_ItemLanguage(ItemLanguage objItemLanguage)
{
	return _ItemLanguageDataAccess.Update_ItemLanguage(objItemLanguage);
}
public BaseResponse Update_ItemLanguage2(ItemLanguage objItemLanguage)
{
	return _ItemLanguageDataAccess.Update_ItemLanguage2(objItemLanguage);
}
public List<ItemLanguage> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ItemLanguageDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<ItemLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ItemLanguageDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int LanguageId, int ItemId)
{
	return _ItemLanguageDataAccess.DeleteByKey(LanguageId, ItemId);
}
}
}
