using System.Collections.Generic;
using ModelEntity.Model;
using ModelEntity.BaseModel;
namespace ServiceBusiness.Interfaces
{
public interface IImageService
{
	List<Image> SelectAll();
	Image SelectByKey(int Id);
BaseResponse Create_Image(Image objImage);
BaseResponse Update_Image(Image objImage);
BaseResponse Update_Image2(Image objImage);
	List<Image> SelectDynamic(string WhereCondition, string OrderByExpression);
	List<Image> SelectDynamicPaping(string WhereCondition, string OrderByExpression, int PageIndex, int PageSize);
	BaseResponse DeleteByKey(int Id);
}
}
