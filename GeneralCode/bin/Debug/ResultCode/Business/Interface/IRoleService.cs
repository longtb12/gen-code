using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IRoleService
{
	List<Role> SelectAll();
	Role SelectByKey(int Id);
BaseResponse Create_Role(Role objRole);
BaseResponse Update_Role(Role objRole);
BaseResponse Update_Role2(Role objRole);
	List<Role> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<Role> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
