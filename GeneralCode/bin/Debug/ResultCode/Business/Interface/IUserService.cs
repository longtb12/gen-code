using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IUserService
{
	List<User> SelectAll();
	User SelectByKey(int Id);
BaseResponse Create_User(User objUser);
BaseResponse Update_User(User objUser);
BaseResponse Update_User2(User objUser);
	List<User> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<User> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
