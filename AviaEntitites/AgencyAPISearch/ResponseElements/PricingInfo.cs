using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class PricingInfo
	{
		[XmlAttribute]
		public bool Refundable { get; set; }

		[XmlElement(Order = 0, ElementName = "PassengerFare")]
		public List<PassengerFare> PassengerFares { get; set; }
	}
}
