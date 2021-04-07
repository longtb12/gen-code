using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface ICategoryPropertyDataAccess
{
List<CategoryProperty> SelectAll();
CategoryProperty SelectByKey(int CategoryId, int PropertyId);
BaseResponse Create_CategoryProperty(CategoryProperty objCategoryProperty);
BaseResponse Update_CategoryProperty(CategoryProperty objCategoryProperty);
BaseResponse Update_CategoryProperty2(CategoryProperty objCategoryProperty);
List<CategoryProperty> SelectDynamic(string WhereCondition, string OrderByExpression);
List<CategoryProperty> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int CategoryId, int PropertyId);
}
}
