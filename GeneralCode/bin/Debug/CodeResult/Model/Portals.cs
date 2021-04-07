using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Portals
	{
		public int Id {get; set;}
		public string? Name {get; set;}
		public int? Order {get; set;}
		public bool? Status {get; set;}
		public bool? Deleted {get; set;}
	}
}
