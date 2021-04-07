using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Property
	{
		public int Id {get; set;}
		public string Name {get; set;}
		public string DataType {get; set;}
		public int? Length {get; set;}
		public int? Order {get; set;}
		public bool? Deleted {get; set;}
		public bool? Required {get; set;}
		public bool? MultiSelect {get; set;}
		public bool? MultiLanguage {get; set;}
		public string? Description {get; set;}
		public bool Active {get; set;}
	}
}
