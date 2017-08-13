using AviaEntities.AgencyAPISearch.Shared;
using GeneralEntities.ExtendedDateTime;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType]
	public class ODPair
	{
		[XmlElement(Order = 0)]
		public DateTimeEx DepDate { get; set; }

		[XmlElement(Order = 1)]
		public TripPoint DepAirp { get; set; }

		[XmlElement(Order = 2)]
		public TripPoint ArrAirp { get; set; }
	}
}
