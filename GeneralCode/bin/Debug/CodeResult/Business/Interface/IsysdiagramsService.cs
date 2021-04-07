using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IsysdiagramsService
{
	List<sysdiagrams> SelectAll();
	sysdiagrams SelectByKey(int diagram_id);
BaseResponse Create_sysdiagrams(sysdiagrams objsysdiagrams);
BaseResponse Update_sysdiagrams(sysdiagrams objsysdiagrams);
BaseResponse Update_sysdiagrams2(sysdiagrams objsysdiagrams);
	List<sysdiagrams> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<sysdiagrams> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int diagram_id);
}
}
