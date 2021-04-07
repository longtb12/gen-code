using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IProductDataAccess
{
List<Product> SelectAll();
Product SelectByKey(int Id);
BaseResponse Create_Product(Product objProduct);
BaseResponse Update_Product(Product objProduct);
BaseResponse Update_Product2(Product objProduct);
List<Product> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Product> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
