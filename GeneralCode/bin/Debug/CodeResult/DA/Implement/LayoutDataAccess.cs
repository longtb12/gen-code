using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class LayoutDataAccess : ILayoutDataAccess
{
private readonly ICommonRepository _commonRepository;
public LayoutDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Layout> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Layout>("Layout_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Layout SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Layout>("Layout_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Layout(Layout objLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Name", objLayout.Name),
			new KeyValuePair<string, object>("Path", objLayout.Path),
			new KeyValuePair<string, object>("Actived", objLayout.Actived),
			new KeyValuePair<string, object>("Deleted", objLayout.Deleted),
			new KeyValuePair<string, object>("Order", objLayout.Order),
			new KeyValuePair<string, object>("CreatorId", objLayout.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objLayout.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objLayout.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objLayout.UpdateDate)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Layout_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Layout(Layout objLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objLayout.Id),
			new KeyValuePair<string, object>("Name", objLayout.Name),
			new KeyValuePair<string, object>("Path", objLayout.Path),
			new KeyValuePair<string, object>("Actived", objLayout.Actived),
			new KeyValuePair<string, object>("Deleted", objLayout.Deleted),
			new KeyValuePair<string, object>("Order", objLayout.Order),
			new KeyValuePair<string, object>("CreatorId", objLayout.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objLayout.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objLayout.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objLayout.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("Layout_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Layout2(Layout objLayout)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objLayout.Id),
			new KeyValuePair<string, object>("Name", objLayout.Name),
			new KeyValuePair<string, object>("Path", objLayout.Path),
			new KeyValuePair<string, object>("Actived", objLayout.Actived),
			new KeyValuePair<string, object>("Deleted", objLayout.Deleted),
			new KeyValuePair<string, object>("Order", objLayout.Order),
			new KeyValuePair<string, object>("CreatorId", objLayout.CreatorId),
			new KeyValuePair<string, object>("CreateDate", objLayout.CreateDate),
			new KeyValuePair<string, object>("UpdatorId", objLayout.UpdatorId),
			new KeyValuePair<string, object>("UpdateDate", objLayout.UpdateDate)
};
objReturn.Success =_commonRepository.ExcuteStore("Layout_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Layout> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Layout>("Layout_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Layout> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Layout>("Layout_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Layout_DeleteByKey",arg);
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
