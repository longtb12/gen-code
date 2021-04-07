using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ItemLanguageDataAccess : IItemLanguageDataAccess
{
private readonly ICommonRepository _commonRepository;
public ItemLanguageDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<ItemLanguage> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<ItemLanguage>("ItemLanguage_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public ItemLanguage SelectByKey(int LanguageId, int ItemId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("LanguageId", LanguageId),
			new KeyValuePair<string, object>("ItemId", ItemId)
			};
			return _commonRepository.GetObjectByStoredProcedure<ItemLanguage>("ItemLanguage_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_ItemLanguage(ItemLanguage objItemLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objItemLanguage.LanguageId),
			new KeyValuePair<string, object>("ItemId", objItemLanguage.ItemId),
			new KeyValuePair<string, object>("ItemUrl", objItemLanguage.ItemUrl),
			new KeyValuePair<string, object>("Name", objItemLanguage.Name),
			new KeyValuePair<string, object>("Title", objItemLanguage.Title),
			new KeyValuePair<string, object>("ShortDescription", objItemLanguage.ShortDescription),
			new KeyValuePair<string, object>("Description", objItemLanguage.Description),
			new KeyValuePair<string, object>("KeywordMeta", objItemLanguage.KeywordMeta),
			new KeyValuePair<string, object>("DescriptionMeta", objItemLanguage.DescriptionMeta),
			new KeyValuePair<string, object>("GeneratorMeta", objItemLanguage.GeneratorMeta),
			new KeyValuePair<string, object>("Tags", objItemLanguage.Tags),
			new KeyValuePair<string, object>("Active", objItemLanguage.Active)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("ItemLanguage_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_ItemLanguage(ItemLanguage objItemLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objItemLanguage.LanguageId),
			new KeyValuePair<string, object>("ItemId", objItemLanguage.ItemId),
			new KeyValuePair<string, object>("ItemUrl", objItemLanguage.ItemUrl),
			new KeyValuePair<string, object>("Name", objItemLanguage.Name),
			new KeyValuePair<string, object>("Title", objItemLanguage.Title),
			new KeyValuePair<string, object>("ShortDescription", objItemLanguage.ShortDescription),
			new KeyValuePair<string, object>("Description", objItemLanguage.Description),
			new KeyValuePair<string, object>("KeywordMeta", objItemLanguage.KeywordMeta),
			new KeyValuePair<string, object>("DescriptionMeta", objItemLanguage.DescriptionMeta),
			new KeyValuePair<string, object>("GeneratorMeta", objItemLanguage.GeneratorMeta),
			new KeyValuePair<string, object>("Tags", objItemLanguage.Tags),
			new KeyValuePair<string, object>("Active", objItemLanguage.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("ItemLanguage_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_ItemLanguage2(ItemLanguage objItemLanguage)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("LanguageId", objItemLanguage.LanguageId),
			new KeyValuePair<string, object>("ItemId", objItemLanguage.ItemId),
			new KeyValuePair<string, object>("ItemUrl", objItemLanguage.ItemUrl),
			new KeyValuePair<string, object>("Name", objItemLanguage.Name),
			new KeyValuePair<string, object>("Title", objItemLanguage.Title),
			new KeyValuePair<string, object>("ShortDescription", objItemLanguage.ShortDescription),
			new KeyValuePair<string, object>("Description", objItemLanguage.Description),
			new KeyValuePair<string, object>("KeywordMeta", objItemLanguage.KeywordMeta),
			new KeyValuePair<string, object>("DescriptionMeta", objItemLanguage.DescriptionMeta),
			new KeyValuePair<string, object>("GeneratorMeta", objItemLanguage.GeneratorMeta),
			new KeyValuePair<string, object>("Tags", objItemLanguage.Tags),
			new KeyValuePair<string, object>("Active", objItemLanguage.Active)
};
objReturn.Success =_commonRepository.ExcuteStore("ItemLanguage_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<ItemLanguage> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<ItemLanguage>("ItemLanguage_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<ItemLanguage> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PageIndex", PageIndex ),
			new KeyValuePair<string, object>("PageSize", PageSize ),
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<ItemLanguage>("ItemLanguage_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int LanguageId, int ItemId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("LanguageId", LanguageId),
			new KeyValuePair<string, object>("ItemId", ItemId)
			};
			 objReturn= _commonRepository.ExcuteStore("ItemLanguage_DeleteByKey",arg);
		}
	catch (Exception ex)
		{
objReturn.Success=false;
objReturn.Message=ex.ToString();
		}
return objReturn;
}
}
}
