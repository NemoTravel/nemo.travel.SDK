using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class TaxBreakdown
	{
		[XmlElement(Order = 0)]
		public decimal totalAircompanyTaxCost { get; set; }

		[XmlElement(Order = 1)]
		public decimal totalAgencyTaxCost { get; set; }
	}
}
