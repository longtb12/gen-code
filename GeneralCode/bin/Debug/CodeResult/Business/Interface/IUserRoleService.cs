using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IUserRoleService
{
	List<UserRole> SelectAll();
	UserRole SelectByKey(int UserId, int RoleId);
BaseResponse Create_UserRole(UserRole objUserRole);
BaseResponse Update_UserRole(UserRole objUserRole);
BaseResponse Update_UserRole2(UserRole objUserRole);
	List<UserRole> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<UserRole> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int UserId, int RoleId);
}
}
