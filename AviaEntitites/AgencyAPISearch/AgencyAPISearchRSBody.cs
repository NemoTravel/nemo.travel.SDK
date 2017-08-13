using AviaEntities.AgencyAPISearch.ResponseElements;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch
{
	[XmlType()]
	public class AgencyAPISearchRSBody
	{
		[XmlElement(Order = 0)]
		public FlightsContainer Flights { get; set; }

		[XmlArray(Order = 1)]
		[XmlArrayItem()]
		public List<Error> Errors { get; set; }

		public AgencyAPISearchRSBody()
		{
			Flights = new FlightsContainer();
		}
	}
}
