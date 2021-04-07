using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Role
	{
		public int Id {get; set;}
		public string RoleName {get; set;}
		public bool Actived {get; set;}
		public string? Description {get; set;}
		public int Order {get; set;}
		public int? CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
		public bool? Deleted {get; set;}
	}
}
