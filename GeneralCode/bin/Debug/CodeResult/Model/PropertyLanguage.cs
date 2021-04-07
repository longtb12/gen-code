using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class PropertyLanguage
	{
		public int LanguageId {get; set;}
		public int PropertyId {get; set;}
		public string? DisplayName {get; set;}
		public string? DefaultValue {get; set;}
	}
}
