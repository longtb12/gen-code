using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Action
	{
		public int Id {get; set;}
		public string ActionName {get; set;}
		public string ControllerName {get; set;}
		public string AreaName {get; set;}
		public int Order {get; set;}
		public bool Deleted {get; set;}
		public bool Actived {get; set;}
		public int CreatorId {get; set;}
		public int UpdatorId {get; set;}
		public string? DisplayName {get; set;}
	}
}
