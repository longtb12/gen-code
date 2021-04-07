using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class ViewDataAccess : IViewDataAccess
{
private readonly ICommonRepository _commonRepository;
public ViewDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<View> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<View>("View_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public View SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<View>("View_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_View(View objView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Name", objView.Name),
			new KeyValuePair<string, object>("Path", objView.Path),
			new KeyValuePair<string, object>("Order", objView.Order),
			new KeyValuePair<string, object>("Deleted", objView.Deleted),
			new KeyValuePair<string, object>("Actived", objView.Actived),
			new KeyValuePair<string, object>("CreatorId", objView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objView.UpdateDate)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("View_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_View(View objView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objView.Id),
			new KeyValuePair<string, object>("Name", objView.Name),
			new KeyValuePair<string, object>("Path", objView.Path),
			new KeyValuePair<string, object>("Order", objView.Order),
			new KeyValuePair<string, object>("Deleted", objView.Deleted),
			new KeyValuePair<string, object>("Actived", objView.Actived),
			new KeyValuePair<string, object>("CreatorId", objView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objView.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("View_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_View2(View objView)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objView.Id),
			new KeyValuePair<string, object>("Name", objView.Name),
			new KeyValuePair<string, object>("Path", objView.Path),
			new KeyValuePair<string, object>("Order", objView.Order),
			new KeyValuePair<string, object>("Deleted", objView.Deleted),
			new KeyValuePair<string, object>("Actived", objView.Actived),
			new KeyValuePair<string, object>("CreatorId", objView.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objView.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objView.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objView.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("View_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<View> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<View>("View_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<View> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<View>("View_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("View_DeleteByKey",arg);
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
