using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class PortalsView
	{
		public int PortalId {get; set;}
		public int ViewId {get; set;}
		public int? CreatorId {get; set;}
		public DateTime? CreateDate {get; set;}
		public int? UpdatorId {get; set;}
		public DateTime? UpdateDate {get; set;}
	}
}
