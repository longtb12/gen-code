using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IPortalsViewDataAccess
{
List<PortalsView> SelectAll();
PortalsView SelectByKey(int PortalId, int ViewId);
BaseResponse Create_PortalsView(PortalsView objPortalsView);
BaseResponse Update_PortalsView(PortalsView objPortalsView);
BaseResponse Update_PortalsView2(PortalsView objPortalsView);
List<PortalsView> SelectDynamic(string WhereCondition, string OrderByExpression);
List<PortalsView> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int PortalId, int ViewId);
}
}
