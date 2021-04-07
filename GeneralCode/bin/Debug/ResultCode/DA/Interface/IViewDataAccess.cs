using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IViewDataAccess
{
List<View> SelectAll();
View SelectByKey(int Id);
BaseResponse Create_View(View objView);
BaseResponse Update_View(View objView);
BaseResponse Update_View2(View objView);
List<View> SelectDynamic(string WhereCondition, string OrderByExpression);
List<View> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
