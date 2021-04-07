using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IRoleActionDataAccess
{
List<RoleAction> SelectAll();
RoleAction SelectByKey(int RoleId, int ActionId);
BaseResponse Create_RoleAction(RoleAction objRoleAction);
BaseResponse Update_RoleAction(RoleAction objRoleAction);
BaseResponse Update_RoleAction2(RoleAction objRoleAction);
List<RoleAction> SelectDynamic(string WhereCondition, string OrderByExpression);
List<RoleAction> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int RoleId, int ActionId);
}
}
