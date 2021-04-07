using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IPropertyLanguageDataAccess
{
List<PropertyLanguage> SelectAll();
PropertyLanguage SelectByKey(int LanguageId, int PropertyId);
BaseResponse Create_PropertyLanguage(PropertyLanguage objPropertyLanguage);
BaseResponse Update_PropertyLanguage(PropertyLanguage objPropertyLanguage);
BaseResponse Update_PropertyLanguage2(PropertyLanguage objPropertyLanguage);
List<PropertyLanguage> SelectDynamic(string WhereCondition, string OrderByExpression);
List<PropertyLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int LanguageId, int PropertyId);
}
}
