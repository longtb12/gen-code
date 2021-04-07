using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace DataAccess.Interfaces
{
public interface IDocumentDataAccess
{
List<Document> SelectAll();
Document SelectByKey(int Id);
BaseResponse Create_Document(Document objDocument);
BaseResponse Update_Document(Document objDocument);
BaseResponse Update_Document2(Document objDocument);
List<Document> SelectDynamic(string WhereCondition, string OrderByExpression);
List<Document> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
BaseResponse DeleteByKey(int Id);
}
}
