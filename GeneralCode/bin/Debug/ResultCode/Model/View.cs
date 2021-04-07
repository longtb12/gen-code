using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class View
	{
		public int Id {get; set;}
		public string? Name {get; set;}
		public string? Path {get; set;}
		public int? Order {get; set;}
		public bool? Deleted {get; set;}
		public bool? Actived {get; set;}
		public int? CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
		public int? UpdatorId {get; set;}
		public int? UpdateDate {get; set;}
	}
}
