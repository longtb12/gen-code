using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class Item
	{
		public int Id {get; set;}
		public int ParentId {get; set;}
		public int Type {get; set;}
		public bool Top {get; set;}
		public bool Left {get; set;}
		public bool Right {get; set;}
		public bool Bottom {get; set;}
		public int CreatorId {get; set;}
		public DateTime CreateDate {get; set;}
		public int UpdatorId {get; set;}
		public DateTime UpdateDate {get; set;}
		public DateTime PublishDate {get; set;}
		public bool Checked {get; set;}
		public bool Deleted {get; set;}
		public bool DisplayHome {get; set;}
		public int Order {get; set;}
		public int PortalId {get; set;}
		public int LayoutId {get; set;}
		public int ViewId {get; set;}
		public int ViewCount {get; set;}
		public bool? Active {get; set;}
		public string? Tags {get; set;}
	}
}
