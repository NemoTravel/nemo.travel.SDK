using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class Tax
	{
		[XmlAttribute(AttributeName = "CurCode")]
		public string Currency { get; set; }

		[XmlAttribute(AttributeName = "TaxCode")]
		public string Code { get; set; }

		[XmlAttribute]
		public double Amount { get; set; }
	}
}
