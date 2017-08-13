using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class CategoryPriceBreakdown
	{
		[XmlElement(Order = 0)]
		public CategoryTypeEnum category { get; set; }

		[XmlElement(Order = 1)]
		public int count { get; set; }

		[XmlElement(Order = 2)]
		public decimal fareCost { get; set; }
		
		[XmlElement(Order = 3)]
		public decimal taxCost { get; set; }

		[XmlElement(Order = 4)]
		public decimal aircompanyTaxCost { get; set; }

		[XmlElement(Order = 5)]
		public decimal agencyTaxCost { get; set; }
	}
}
