using AviaEntities.AgencyAPISearch.Shared;
using GeneralEntities;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType()]
	public class Flight
	{
		[XmlAttribute]
		public string FlightId { get; set; }

		[XmlElement(Order = 0)]
		public Supplier WebService { get; set; }

		[XmlElement(Order = 1)]
		public string ValCompany { get; set; }

		[XmlElement(Order = 2)]
		public string URL { get; set; }

		[XmlArray(Order = 3)]
		[XmlArrayItem(ElementName = "Segment")]
		public List<Segment> Segments { get; set; }

		[XmlElement(Order = 4)]
		public PricingInfo PricingInfo { get; set; }

		[XmlElement(Order = 5)]
		public Price Commission { get; set; }

		[XmlElement(Order = 6)]
		public Price Charges { get; set; }

		[XmlElement(Order = 7)]
		public Price TotalPrice { get; set; }
	}
}
