using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IActionService
{
	List<Action> SelectAll();
	Action SelectByKey(int Id);
BaseResponse Create_Action(Action objAction);
BaseResponse Update_Action(Action objAction);
BaseResponse Update_Action2(Action objAction);
	List<Action> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<Action> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
