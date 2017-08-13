using AviaEntities.AgencyAPISearch.RequestElements;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch
{
	[XmlType]
	public class AgencyAPISearchRQBody
	{
		[XmlElement(Order = 0)]
		public SearchFlights SearchFlights { get; set; }
	}
}
