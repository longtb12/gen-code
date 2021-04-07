using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IPortalsDataAccess
{
List<Portals> SelectAll();
Portals SelectByKey(int Id);
BaseResponse Create_Portals(Portals objPortals);
BaseResponse Update_Portals(Portals objPortals);
BaseResponse Update_Portals2(Portals objPortals);
List<Portals> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Portals> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
