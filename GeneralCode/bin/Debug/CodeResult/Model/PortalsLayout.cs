using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class PortalsLayout
	{
		public int PortalId {get; set;}
		public int LayoutId {get; set;}
		public int? CreatorId {get; set;}
		public int? UpdatorId {get; set;}
		public DateTime? CreateDate {get; set;}
		public DateTime? UpdateDate {get; set;}
	}
}
