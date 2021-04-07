using System;
using System.Collections.Generic; 
using ModelEntity.Model;
using ModelEntity.BaseModel;
using DataAccess.Implements;
using ServiceBusiness.Interfaces;
namespace ServiceBusiness.Implements
{
public class ImageService : IImageService
{
private readonly IImageDataAccess _ImageDataAccess;
public ImageService(IImageDataAccess ImageDataAccess)
{
_ImageDataAccess = ImageDataAccess;
}
public List<Image> SelectAll()
{
	return _ImageDataAccess.SelectAll();
}
public Image SelectByKey(int Id)
{
	return _ImageDataAccess.SelectByKey(Id);
}
public BaseResponse Create_Image(Image objImage)
{
	return _ImageDataAccess.Create_Image(objImage);
}
public BaseResponse Update_Image(Image objImage)
{
	return _ImageDataAccess.Update_Image(objImage);
}
public BaseResponse Update_Image2(Image objImage)
{
	return _ImageDataAccess.Update_Image2(objImage);
}
public List<Image> SelectDynamic(string WhereCondition, string OrderByExpression)
{
	return _ImageDataAccess.SelectDynamic(WhereCondition, OrderByExpression);
}
public List<Image> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize)
{
	return _ImageDataAccess.SelectDynamicPaping(WhereCondition, OrderByExpression, PageIndex, PageSize);
}
public BaseResponse DeleteByKey(int Id)
{
	return _ImageDataAccess.DeleteByKey(Id);
}
}
}
