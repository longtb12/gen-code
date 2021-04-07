using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IPropertyService
{
	List<Property> SelectAll();
	Property SelectByKey(int Id);
BaseResponse Create_Property(Property objProperty);
BaseResponse Update_Property(Property objProperty);
BaseResponse Update_Property2(Property objProperty);
	List<Property> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<Property> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
