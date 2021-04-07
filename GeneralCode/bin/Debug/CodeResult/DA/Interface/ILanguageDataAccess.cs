using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface ILanguageDataAccess
{
List<Language> SelectAll();
Language SelectByKey(int Id);
BaseResponse Create_Language(Language objLanguage);
BaseResponse Update_Language(Language objLanguage);
BaseResponse Update_Language2(Language objLanguage);
List<Language> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Language> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
