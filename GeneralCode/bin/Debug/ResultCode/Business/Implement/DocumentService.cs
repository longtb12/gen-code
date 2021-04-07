using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class DocumentService : IDocumentService
{
private readonly IDocumentDataAccess _DocumentDataAccess;
public DocumentService(IDocumentDataAccess DocumentDataAccess)
{
_DocumentDataAccess = DocumentDataAccess;
}
public List<Document> SelectAll()
{
	return _DocumentDataAccess.SelectAll();
}
public Document SelectByKey(int Id)
{
	return _DocumentDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Document(Document objDocument)
{
	return _DocumentDataAccess.Create_Document(objDocument);
}
public BaseResponse Update_Document(Document objDocument)
{
	return _DocumentDataAccess.Update_Document(objDocument);
}
public BaseResponse Update_Document2(Document objDocument)
{
	return _DocumentDataAccess.Update_Document2(objDocument);
}
public List<Document> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _DocumentDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Document> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _DocumentDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _DocumentDataAccess.DeleteByKey(Id);
}
}
}
