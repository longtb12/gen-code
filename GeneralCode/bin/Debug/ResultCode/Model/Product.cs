using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Product
	{
		public int Id {get; set;}
		public double? Cost {get; set;}
		public double? Discount {get; set;}
		public bool? Percent {get; set;}
		public DateTime? DateBegin {get; set;}
		public DateTime? DateEnd {get; set;}
		public bool? InStock {get; set;}
	}
}
