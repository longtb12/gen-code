using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class RoleAction
	{
		public int RoleId {get; set;}
		public int ActionId {get; set;}
		public int CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
	}
}
