using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PortalsLayoutDataAccess : IPortalsLayoutDataAccess
{
private readonly ICommonRepository _commonRepository;
public PortalsLayoutDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<PortalsLayout> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<PortalsLayout>("PortalsLayout_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public PortalsLayout SelectByKey(int PortalId, int LayoutId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PortalId", PortalId),
			new KeyValuePair<string, object>("LayoutId", LayoutId)
			};
			return _commonRepository.GetObjectByStoredProcedure<PortalsLayout>("PortalsLayout_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_PortalsLayout(PortalsLayout objPortalsLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsLayout.PortalId),
			new KeyValuePair<string, object>("LayoutId", objPortalsLayout.LayoutId),
			new KeyValuePair<string, object>("CreatorId", objPortalsLayout.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objPortalsLayout.UpdatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsLayout.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objPortalsLayout.UpdateDate)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("PortalsLayout_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PortalsLayout(PortalsLayout objPortalsLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsLayout.PortalId),
			new KeyValuePair<string, object>("LayoutId", objPortalsLayout.LayoutId),
			new KeyValuePair<string, object>("CreatorId", objPortalsLayout.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objPortalsLayout.UpdatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsLayout.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objPortalsLayout.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("PortalsLayout_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PortalsLayout2(PortalsLayout objPortalsLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsLayout.PortalId),
			new KeyValuePair<string, object>("LayoutId", objPortalsLayout.LayoutId),
			new KeyValuePair<string, object>("CreatorId", objPortalsLayout.CreatorId),
			new KeyValuePair<string, object>("UpdatorId", objPortalsLayout.UpdatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsLayout.CreateDate),
			new KeyValuePair<string, object>("UpdateDate", objPortalsLayout.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("PortalsLayout_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<PortalsLayout> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<PortalsLayout>("PortalsLayout_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<PortalsLayout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<PortalsLayout>("PortalsLayout_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int PortalId, int LayoutId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PortalId", PortalId),
			new KeyValuePair<string, object>("LayoutId", LayoutId)
			};
			 objReturn= _commonRepository.ExcuteStore("PortalsLayout_DeleteByKey",arg);
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
