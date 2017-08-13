using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class DiscountedPrice
	{
		[XmlElement(Order = 0)]
		public decimal discountedTotal { get; set; }

		[XmlElement(Order = 1)]
		public string payTypeName { get; set; }
	}
}
