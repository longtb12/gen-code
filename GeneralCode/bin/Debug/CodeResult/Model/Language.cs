using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Language
	{
		public int Id {get; set;}
		public string? Name {get; set;}
		public bool? Default {get; set;}
		public string? Image {get; set;}
		public int? Order {get; set;}
		public bool? Deleted {get; set;}
		public bool? Actived {get; set;}
	}
}
