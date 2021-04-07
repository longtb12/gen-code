using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class FeedBackDataAccess : IFeedBackDataAccess
{
private readonly ICommonRepository _commonRepository;
public FeedBackDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<FeedBack> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<FeedBack>("FeedBack_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public FeedBack SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<FeedBack>("FeedBack_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_FeedBack(FeedBack objFeedBack)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objFeedBack.Id),
			new KeyValuePair<string, object>("ParentId", objFeedBack.ParentId),
			new KeyValuePair<string, object>("ItemId", objFeedBack.ItemId),
			new KeyValuePair<string, object>("UserId", objFeedBack.UserId),
			new KeyValuePair<string, object>("Content", objFeedBack.Content),
			new KeyValuePair<string, object>("UserFullName", objFeedBack.UserFullName),
			new KeyValuePair<string, object>("Email", objFeedBack.Email),
			new KeyValuePair<string, object>("Mobile", objFeedBack.Mobile),
			new KeyValuePair<string, object>("Address", objFeedBack.Address),
			new KeyValuePair<string, object>("TotalLike", objFeedBack.TotalLike),
			new KeyValuePair<string, object>("TotalDisLike", objFeedBack.TotalDisLike),
			new KeyValuePair<string, object>("CreateDate", objFeedBack.CreateDate),
			new KeyValuePair<string, object>("ParentIdRepply", objFeedBack.ParentIdRepply),
			new KeyValuePair<string, object>("Answer", objFeedBack.Answer)
};
objReturn.Success =_commonRepository.ExecuteStoredProcedure("FeedBack_Insert",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_FeedBack(FeedBack objFeedBack)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objFeedBack.Id),
			new KeyValuePair<string, object>("ParentId", objFeedBack.ParentId),
			new KeyValuePair<string, object>("ItemId", objFeedBack.ItemId),
			new KeyValuePair<string, object>("UserId", objFeedBack.UserId),
			new KeyValuePair<string, object>("Content", objFeedBack.Content),
			new KeyValuePair<string, object>("UserFullName", objFeedBack.UserFullName),
			new KeyValuePair<string, object>("Email", objFeedBack.Email),
			new KeyValuePair<string, object>("Mobile", objFeedBack.Mobile),
			new KeyValuePair<string, object>("Address", objFeedBack.Address),
			new KeyValuePair<string, object>("TotalLike", objFeedBack.TotalLike),
			new KeyValuePair<string, object>("TotalDisLike", objFeedBack.TotalDisLike),
			new KeyValuePair<string, object>("CreateDate", objFeedBack.CreateDate),
			new KeyValuePair<string, object>("ParentIdRepply", objFeedBack.ParentIdRepply),
			new KeyValuePair<string, object>("Answer", objFeedBack.Answer)
};
objReturn.Success =_commonRepository.ExcuteStore("FeedBack_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_FeedBack2(FeedBack objFeedBack)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objFeedBack.Id),
			new KeyValuePair<string, object>("ParentId", objFeedBack.ParentId),
			new KeyValuePair<string, object>("ItemId", objFeedBack.ItemId),
			new KeyValuePair<string, object>("UserId", objFeedBack.UserId),
			new KeyValuePair<string, object>("Content", objFeedBack.Content),
			new KeyValuePair<string, object>("UserFullName", objFeedBack.UserFullName),
			new KeyValuePair<string, object>("Email", objFeedBack.Email),
			new KeyValuePair<string, object>("Mobile", objFeedBack.Mobile),
			new KeyValuePair<string, object>("Address", objFeedBack.Address),
			new KeyValuePair<string, object>("TotalLike", objFeedBack.TotalLike),
			new KeyValuePair<string, object>("TotalDisLike", objFeedBack.TotalDisLike),
			new KeyValuePair<string, object>("CreateDate", objFeedBack.CreateDate),
			new KeyValuePair<string, object>("ParentIdRepply", objFeedBack.ParentIdRepply),
			new KeyValuePair<string, object>("Answer", objFeedBack.Answer)
};
objReturn.Success =_commonRepository.ExcuteStore("FeedBack_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<FeedBack> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<FeedBack>("FeedBack_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<FeedBack> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<FeedBack>("FeedBack_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("FeedBack_DeleteByKey",arg);
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
