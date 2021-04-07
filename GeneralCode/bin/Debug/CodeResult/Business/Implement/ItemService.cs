using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ItemService : IItemService
{
private readonly IItemDataAccess _ItemDataAccess;
public ItemService(IItemDataAccess ItemDataAccess)
{
_ItemDataAccess = ItemDataAccess;
}
public List<Item> SelectAll()
{
	return _ItemDataAccess.SelectAll();
}
public Item SelectByKey(int Id)
{
	return _ItemDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Item(Item objItem)
{
	return _ItemDataAccess.Create_Item(objItem);
}
public BaseResponse Update_Item(Item objItem)
{
	return _ItemDataAccess.Update_Item(objItem);
}
public BaseResponse Update_Item2(Item objItem)
{
	return _ItemDataAccess.Update_Item2(objItem);
}
public List<Item> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ItemDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Item> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ItemDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _ItemDataAccess.DeleteByKey(Id);
}
}
}
