using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ProductService : IProductService
{
private readonly IProductDataAccess _ProductDataAccess;
public ProductService(IProductDataAccess ProductDataAccess)
{
_ProductDataAccess = ProductDataAccess;
}
public List<Product> SelectAll()
{
	return _ProductDataAccess.SelectAll();
}
public Product SelectByKey(int Id)
{
	return _ProductDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Product(Product objProduct)
{
	return _ProductDataAccess.Create_Product(objProduct);
}
public BaseResponse Update_Product(Product objProduct)
{
	return _ProductDataAccess.Update_Product(objProduct);
}
public BaseResponse Update_Product2(Product objProduct)
{
	return _ProductDataAccess.Update_Product2(objProduct);
}
public List<Product> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ProductDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Product> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ProductDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _ProductDataAccess.DeleteByKey(Id);
}
}
}
