using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.RequestElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class Segment
	{
		[XmlElement(Order = 0)]
		public FlightPoint departurePoint { get; set; }

		[XmlElement(Order = 1)]
		public FlightPoint arrivalPoint { get; set; }

		[XmlElement(Order = 2)]
		public DateTimeEx travelDate { get; set; }

		[XmlElement(Order = 3)]
		public TimePreferenceEnum departureTimePreference { get; set; }

		[XmlElement(Order = 4, IsNullable = true)]
		public string aircompany { get; set; }

		[XmlElement(Order = 5, IsNullable = true)]
		public List<FlightPreferences> flights { get; set; }
	}
}
