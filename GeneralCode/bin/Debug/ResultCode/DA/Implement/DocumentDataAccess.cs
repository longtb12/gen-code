using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Interfaces;
using Repository;
namespace DataAccess.Implements
{
public class DocumentDataAccess : IDocumentDataAccess
{
private readonly ICommonRepository _commonRepository;
public DocumentDataAccess(ICommonRepository commonRepository)
{
_commonRepository = commonRepository;
}
public List<Document> SelectAll()
{
	try
		{
			return _commonRepository.GetListByStoredProcedure<Document>("Document_SelectAll");
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public Document SelectByKey(int Id)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("Id", Id)
			};
			return _commonRepository.GetObjectByStoredProcedure<Document>("Document_SelectByKey",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public BaseResponse Create_Document(Document objDocument)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("ItemId", objDocument.ItemId),
			new KeyValuePair<string, object>("Url", objDocument.Url),
			new KeyValuePair<string, object>("Order", objDocument.Order),
			new KeyValuePair<string, object>("Title", objDocument.Title)
};
objReturn.Id =_commonRepository.ExcuteStoreAndGetSingleValue("Document_Insert","Id",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Document(Document objDocument)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objDocument.Id),
			new KeyValuePair<string, object>("ItemId", objDocument.ItemId),
			new KeyValuePair<string, object>("Url", objDocument.Url),
			new KeyValuePair<string, object>("Order", objDocument.Order),
			new KeyValuePair<string, object>("Title", objDocument.Title)
};
objReturn.Success =_commonRepository.ExcuteStore("Document_Update",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public BaseResponse Update_Document2(Document objDocument)
{
var objReturn=new BaseResponse();
try
{
var arg = new[]
{
			new KeyValuePair<string, object>("Id", objDocument.Id),
			new KeyValuePair<string, object>("ItemId", objDocument.ItemId),
			new KeyValuePair<string, object>("Url", objDocument.Url),
			new KeyValuePair<string, object>("Order", objDocument.Order),
			new KeyValuePair<string, object>("Title", objDocument.Title)
};
objReturn.Success =_commonRepository.ExcuteStore("Document_Update2",arg);
}
catch (Exception ex)
{
objReturn.Success=false;
objReturn.Message=ex.ToString();
}
return objReturn;
}
public List<Document> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	try
		{
			var arg = new[]
			{
			new KeyValuePair<string, object>("WhereCondition", WhereCondition ),
			new KeyValuePair<string, object>("OrderByExpression", OrderByExpression )
			};
			return _commonRepository.GetListByStoredProcedure<Document>("Document_SelectDynamic",arg);
		}
	catch (Exception ex)
		{
			throw new Exception(ex.ToString());
		}
}
public List<Document> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
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
			return _commonRepository.GetListByStoredProcedure<Document>("Document_SelectDynamicPaping",arg);
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
			 objReturn= _commonRepository.ExcuteStore("Document_DeleteByKey",arg);
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
