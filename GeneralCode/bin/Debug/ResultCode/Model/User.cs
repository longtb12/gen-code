using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class User
	{
		public int Id {get; set;}
		public string UserName {get; set;}
		public string Password {get; set;}
		public bool? Actived {get; set;}
		public bool? Status {get; set;}
		public string? DisplayName {get; set;}
		public string? Email {get; set;}
		public string? Phone {get; set;}
		public DateTime? CreateDate {get; set;}
		public DateTime? UpdateDate {get; set;}
	}
}
