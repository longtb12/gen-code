using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class CategoryPropertyService : ICategoryPropertyService
{
private readonly ICategoryPropertyDataAccess _CategoryPropertyDataAccess;
public CategoryPropertyService(ICategoryPropertyDataAccess CategoryPropertyDataAccess)
{
_CategoryPropertyDataAccess = CategoryPropertyDataAccess;
}
public List<CategoryProperty> SelectAll()
{
	return _CategoryPropertyDataAccess.SelectAll();
}
public CategoryProperty SelectByKey(int CategoryId, int PropertyId)
{
	return _CategoryPropertyDataAccess.SelectByKey(CategoryId, PropertyId);
}
public BaseResponse Create_CategoryProperty(CategoryProperty objCategoryProperty)
{
	return _CategoryPropertyDataAccess.Create_CategoryProperty(objCategoryProperty);
}
public BaseResponse Update_CategoryProperty(CategoryProperty objCategoryProperty)
{
	return _CategoryPropertyDataAccess.Update_CategoryProperty(objCategoryProperty);
}
public BaseResponse Update_CategoryProperty2(CategoryProperty objCategoryProperty)
{
	return _CategoryPropertyDataAccess.Update_CategoryProperty2(objCategoryProperty);
}
public List<CategoryProperty> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _CategoryPropertyDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<CategoryProperty> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _CategoryPropertyDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int CategoryId, int PropertyId)
{
	return _CategoryPropertyDataAccess.DeleteByKey(CategoryId, PropertyId);
}
}
}
