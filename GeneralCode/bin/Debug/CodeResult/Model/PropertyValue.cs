using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class PropertyValue
	{
		public int Id {get; set;}
		public int ItemId {get; set;}
		public int PropertyId {get; set;}
		public int LanguageId {get; set;}
		public string? Value {get; set;}
		public bool? Deleted {get; set;}
		public int? Order {get; set;}
	}
}
