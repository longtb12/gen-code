using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PortalsViewDataAccess : IPortalsViewDataAccess
{
private readonly ICommonRepository _commonRepository;
public PortalsViewDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<PortalsView> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<PortalsView>("PortalsView_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public PortalsView SelectByKey(int PortalId, int ViewId)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PortalId", PortalId),
			new KeyValuePair<string, object>("ViewId", ViewId)
			};
			return _commonRepository.GetObjectByStoredProcedure<PortalsView>("PortalsView_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_PortalsView(PortalsView objPortalsView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsView.PortalId),
			new KeyValuePair<string, object>("ViewId", objPortalsView.ViewId),
			new KeyValuePair<string, object>("CreatorId", objPortalsView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objPortalsView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objPortalsView.UpdateDate)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("PortalsView_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PortalsView(PortalsView objPortalsView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsView.PortalId),
			new KeyValuePair<string, object>("ViewId", objPortalsView.ViewId),
			new KeyValuePair<string, object>("CreatorId", objPortalsView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objPortalsView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objPortalsView.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("PortalsView_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_PortalsView2(PortalsView objPortalsView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("PortalId", objPortalsView.PortalId),
			new KeyValuePair<string, object>("ViewId", objPortalsView.ViewId),
			new KeyValuePair<string, object>("CreatorId", objPortalsView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objPortalsView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objPortalsView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objPortalsView.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("PortalsView_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<PortalsView> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<PortalsView>("PortalsView_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<PortalsView> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<PortalsView>("PortalsView_SelectDynamicPaping",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse DeleteByKey(int PortalId, int ViewId)
{
var objReturn=new BaseResponse();
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("PortalId", PortalId),
			new KeyValuePair<string, object>("ViewId", ViewId)
			};
			 objReturn= _commonRepository.ExcuteStore("PortalsView_DeleteByKey",arg);
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
