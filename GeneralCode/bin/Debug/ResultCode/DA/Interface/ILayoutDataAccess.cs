using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface ILayoutDataAccess
{
List<Layout> SelectAll();
Layout SelectByKey(int Id);
BaseResponse Create_Layout(Layout objLayout);
BaseResponse Update_Layout(Layout objLayout);
BaseResponse Update_Layout2(Layout objLayout);
List<Layout> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Layout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
