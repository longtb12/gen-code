using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IFeedBackDataAccess
{
List<FeedBack> SelectAll();
FeedBack SelectByKey(int Id);
BaseResponse Create_FeedBack(FeedBack objFeedBack);
BaseResponse Update_FeedBack(FeedBack objFeedBack);
BaseResponse Update_FeedBack2(FeedBack objFeedBack);
List<FeedBack> SelectDynamic(string WhereCondition, string OrderByExpression);
List<FeedBack> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
