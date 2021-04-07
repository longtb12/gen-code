using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ModelEntity.Model
{
	public class ItemLanguage
	{
		public int LanguageId {get; set;}
		public int ItemId {get; set;}
		public string? ItemUrl {get; set;}
		public string? Name {get; set;}
		public string? Title {get; set;}
		public string? ShortDescription {get; set;}
		public string? Description {get; set;}
		public string? KeywordMeta {get; set;}
		public string? DescriptionMeta {get; set;}
		public string? GeneratorMeta {get; set;}
		public string? Tags {get; set;}
		public bool? Active {get; set;}
	}
}
