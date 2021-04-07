using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class FeedBackService : IFeedBackService
{
private readonly IFeedBackDataAccess _FeedBackDataAccess;
public FeedBackService(IFeedBackDataAccess FeedBackDataAccess)
{
_FeedBackDataAccess = FeedBackDataAccess;
}
public List<FeedBack> SelectAll()
{
	return _FeedBackDataAccess.SelectAll();
}
public FeedBack SelectByKey(int Id)
{
	return _FeedBackDataAccess.SelectByKey(Id);
}
public BaseResponse Create_FeedBack(FeedBack objFeedBack)
{
	return _FeedBackDataAccess.Create_FeedBack(objFeedBack);
}
public BaseResponse Update_FeedBack(FeedBack objFeedBack)
{
	return _FeedBackDataAccess.Update_FeedBack(objFeedBack);
}
public BaseResponse Update_FeedBack2(FeedBack objFeedBack)
{
	return _FeedBackDataAccess.Update_FeedBack2(objFeedBack);
}
public List<FeedBack> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _FeedBackDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<FeedBack> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _FeedBackDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _FeedBackDataAccess.DeleteByKey(Id);
}
}
}
