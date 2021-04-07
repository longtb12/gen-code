using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Image
	{
		public int Id {get; set;}
		public int ItemId {get; set;}
		public string? ImageUrl {get; set;}
		public int? Order {get; set;}
		public bool? Active {get; set;}
	}
}
