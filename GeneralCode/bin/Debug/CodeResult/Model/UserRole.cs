using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class UserRole
	{
		public int UserId {get; set;}
		public int RoleId {get; set;}
		public int? CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
	}
}
