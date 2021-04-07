using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IItemDataAccess
{
List<Item> SelectAll();
Item SelectByKey(int Id);
BaseResponse Create_Item(Item objItem);
BaseResponse Update_Item(Item objItem);
BaseResponse Update_Item2(Item objItem);
List<Item> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Item> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
