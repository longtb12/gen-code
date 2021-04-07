using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Document
	{
		public int Id {get; set;}
		public int? ItemId {get; set;}
		public string? Url {get; set;}
		public int? Order {get; set;}
		public string? Title {get; set;}
	}
}
