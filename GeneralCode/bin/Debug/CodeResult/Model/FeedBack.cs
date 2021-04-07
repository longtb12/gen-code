using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class FeedBack
	{
		public int Id {get; set;}
		public int ParentId {get; set;}
		public int ItemId {get; set;}
		public int UserId {get; set;}
		public string Content {get; set;}
		public string UserFullName {get; set;}
		public string Email {get; set;}
		public string Mobile {get; set;}
		public string? Address {get; set;}
		public int? TotalLike {get; set;}
		public int? TotalDisLike {get; set;}
		public DateTime? CreateDate {get; set;}
		public int? ParentIdRepply {get; set;}
		public bool? Answer {get; set;}
	}
}
