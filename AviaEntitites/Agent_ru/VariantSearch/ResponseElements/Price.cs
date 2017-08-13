using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class Price
	{
		public Price()
		{
			categoryPriceBreakdown = new List<CategoryPriceBreakdown>();
		}

		[XmlElement(Order = 0)]
		public string currency { get; set; }

		[XmlElement(Order = 1)]
		public decimal totalCost { get; set; }

		[XmlElement(Order = 2)]
		public decimal aexCost { get; set; }

		[XmlElement(Order = 3)]
		public List<CategoryPriceBreakdown> categoryPriceBreakdown { get; set; }

		[XmlElement(Order = 4)]
		public TaxBreakdown taxBreakdown { get; set; }

		[XmlElement(Order = 5)]
		public decimal insuranceCost { get; set; }
	}
}
