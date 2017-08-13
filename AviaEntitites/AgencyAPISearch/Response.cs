using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch
{
	[XmlType()]
	public class Response
	{
		[XmlElement]
		public AgencyAPISearchRSBody SearchFlights { get; set; }
	}
}
