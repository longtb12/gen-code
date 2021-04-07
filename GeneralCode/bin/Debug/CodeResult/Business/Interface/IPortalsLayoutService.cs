using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IPortalsLayoutService
{
	List<PortalsLayout> SelectAll();
	PortalsLayout SelectByKey(int PortalId, int LayoutId);
BaseResponse Create_PortalsLayout(PortalsLayout objPortalsLayout);
BaseResponse Update_PortalsLayout(PortalsLayout objPortalsLayout);
BaseResponse Update_PortalsLayout2(PortalsLayout objPortalsLayout);
	List<PortalsLayout> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<PortalsLayout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int PortalId, int LayoutId);
}
}
