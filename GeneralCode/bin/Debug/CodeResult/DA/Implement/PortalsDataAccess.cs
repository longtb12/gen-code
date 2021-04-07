using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class PortalsDataAccess : IPortalsDataAccess
{
private readonly ICommonRepository _commonRepository;
public PortalsDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Portals> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Portals>("Portals_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Portals SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Portals>("Portals_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Portals(Portals objPortals)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Name", objPortals.Name),
			new KeyValuePair<string, object>("Order", objPortals.Order),
			new KeyValuePair<string, object>("Status", objPortals.Status),
			new KeyValuePair<string, object>("Deleted", objPortals.Deleted)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Portals_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Portals(Portals objPortals)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objPortals.Id),
			new KeyValuePair<string, object>("Name", objPortals.Name),
			new KeyValuePair<string, object>("Order", objPortals.Order),
			new KeyValuePair<string, object>("Status", objPortals.Status),
			new KeyValuePair<string, object>("Deleted", objPortals.Deleted)
};
objReturn.Success =_commonRepository.ExcuteStore("Portals_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Portals2(Portals objPortals)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objPortals.Id),
			new KeyValuePair<string, object>("Name", objPortals.Name),
			new KeyValuePair<string, object>("Order", objPortals.Order),
			new KeyValuePair<string, object>("Status", objPortals.Status),
			new KeyValuePair<string, object>("Deleted", objPortals.Deleted)
};
objReturn.Success =_commonRepository.ExcuteStore("Portals_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Portals> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Portals>("Portals_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Portals> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Portals>("Portals_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Portals_DeleteByKey",arg);
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
