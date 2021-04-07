using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IPropertyValueService
{
	List<PropertyValue> SelectAll();
	PropertyValue SelectByKey(int Id);
BaseResponse Create_PropertyValue(PropertyValue objPropertyValue);
BaseResponse Update_PropertyValue(PropertyValue objPropertyValue);
BaseResponse Update_PropertyValue2(PropertyValue objPropertyValue);
	List<PropertyValue> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<PropertyValue> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
