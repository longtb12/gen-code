using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ItemDataAccess : IItemDataAccess
{
private readonly ICommonRepository _commonRepository;
public ItemDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Item> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Item>("Item_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Item SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Item>("Item_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Item(Item objItem)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("ParentId", objItem.ParentId),
			new KeyValuePair<string, object>("Type", objItem.Type),
			new KeyValuePair<string, object>("Top", objItem.Top),
			new KeyValuePair<string, object>("Left", objItem.Left),
			new KeyValuePair<string, object>("Right", objItem.Right),
			new KeyValuePair<string, object>("Bottom", objItem.Bottom),
			new KeyValuePair<string, object>("CreatorId", objItem.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objItem.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objItem.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objItem.UpdateDate),
			new KeyValuePair<string, object>("PublishDate", objItem.PublishDate),
			new KeyValuePair<string, object>("Checked", objItem.Checked),
			new KeyValuePair<string, object>("Deleted", objItem.Deleted),
			new KeyValuePair<string, object>("DisplayHome", objItem.DisplayHome),
			new KeyValuePair<string, object>("Order", objItem.Order),
			new KeyValuePair<string, object>("PortalId", objItem.PortalId),
			new KeyValuePair<string, object>("LayoutId", objItem.LayoutId),
			new KeyValuePair<string, object>("ViewId", objItem.ViewId),
			new KeyValuePair<string, object>("ViewCount", objItem.ViewCount),
			new KeyValuePair<string, object>("Active", objItem.Active),
			new KeyValuePair<string, object>("Tags", objItem.Tags)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Item_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Item(Item objItem)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objItem.Id),
			new KeyValuePair<string, object>("ParentId", objItem.ParentId),
			new KeyValuePair<string, object>("Type", objItem.Type),
			new KeyValuePair<string, object>("Top", objItem.Top),
			new KeyValuePair<string, object>("Left", objItem.Left),
			new KeyValuePair<string, object>("Right", objItem.Right),
			new KeyValuePair<string, object>("Bottom", objItem.Bottom),
			new KeyValuePair<string, object>("CreatorId", objItem.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objItem.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objItem.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objItem.UpdateDate),
			new KeyValuePair<string, object>("PublishDate", objItem.PublishDate),
			new KeyValuePair<string, object>("Checked", objItem.Checked),
			new KeyValuePair<string, object>("Deleted", objItem.Deleted),
			new KeyValuePair<string, object>("DisplayHome", objItem.DisplayHome),
			new KeyValuePair<string, object>("Order", objItem.Order),
			new KeyValuePair<string, object>("PortalId", objItem.PortalId),
			new KeyValuePair<string, object>("LayoutId", objItem.LayoutId),
			new KeyValuePair<string, object>("ViewId", objItem.ViewId),
			new KeyValuePair<string, object>("ViewCount", objItem.ViewCount),
			new KeyValuePair<string, object>("Active", objItem.Active),
			new KeyValuePair<string, object>("Tags", objItem.Tags)
};
objReturn.Success =_commonRepository.ExcuteStore("Item_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Item2(Item objItem)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objItem.Id),
			new KeyValuePair<string, object>("ParentId", objItem.ParentId),
			new KeyValuePair<string, object>("Type", objItem.Type),
			new KeyValuePair<string, object>("Top", objItem.Top),
			new KeyValuePair<string, object>("Left", objItem.Left),
			new KeyValuePair<string, object>("Right", objItem.Right),
			new KeyValuePair<string, object>("Bottom", objItem.Bottom),
			new KeyValuePair<string, object>("CreatorId", objItem.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objItem.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objItem.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objItem.UpdateDate),
			new KeyValuePair<string, object>("PublishDate", objItem.PublishDate),
			new KeyValuePair<string, object>("Checked", objItem.Checked),
			new KeyValuePair<string, object>("Deleted", objItem.Deleted),
			new KeyValuePair<string, object>("DisplayHome", objItem.DisplayHome),
			new KeyValuePair<string, object>("Order", objItem.Order),
			new KeyValuePair<string, object>("PortalId", objItem.PortalId),
			new KeyValuePair<string, object>("LayoutId", objItem.LayoutId),
			new KeyValuePair<string, object>("ViewId", objItem.ViewId),
			new KeyValuePair<string, object>("ViewCount", objItem.ViewCount),
			new KeyValuePair<string, object>("Active", objItem.Active),
			new KeyValuePair<string, object>("Tags", objItem.Tags)
};
objReturn.Success =_commonRepository.ExcuteStore("Item_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Item> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Item>("Item_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Item> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Item>("Item_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int Id)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			 objReturn= _commonRepository.ExcuteStore("Item_DeleteByKey",arg);
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
