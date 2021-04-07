using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IItemLanguageService
{
	List<ItemLanguage> SelectAll();
	ItemLanguage SelectByKey(int LanguageId, int ItemId);
BaseResponse Create_ItemLanguage(ItemLanguage objItemLanguage);
BaseResponse Update_ItemLanguage(ItemLanguage objItemLanguage);
BaseResponse Update_ItemLanguage2(ItemLanguage objItemLanguage);
	List<ItemLanguage> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<ItemLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int LanguageId, int ItemId);
}
}
