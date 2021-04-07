using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class CategoryProperty
	{
		public int CategoryId {get; set;}
		public int PropertyId {get; set;}
		public bool? Active {get; set;}
		public int? CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
		public int? UpdatetorId {get; set;}
		public DateTime? UpdateDate {get; set;}
	}
}
