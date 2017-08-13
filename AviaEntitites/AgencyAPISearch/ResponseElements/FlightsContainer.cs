using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class FlightsContainer
	{
		[XmlAttribute]
		public long SearchId { get; set; }

		[XmlAttribute]
		public string ResultURL { get; set; }

		[XmlElement(Order = 0, ElementName = "Flight")]
		public List<Flight> Flights { get; set; }
	}
}
