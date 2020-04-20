using AviaEntities.AgencyAPISearch.Shared;
using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
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

		[XmlArray("DepAltAirports", Order = 2)]
		[XmlArrayItem("AltAirport")]
		public List<TripPoint> DepAltAirp { get; set; }

		[XmlElement(Order = 3)]
		public TripPoint ArrAirp { get; set; }

		[XmlArray("ArrAltAirports", Order = 4)]
		[XmlArrayItem("AltAirport")]
		public List<TripPoint> ArrAltAirp { get; set; }
	}
}