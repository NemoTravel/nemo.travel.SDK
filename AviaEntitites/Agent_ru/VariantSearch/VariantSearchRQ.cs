using AviaEntities.Agent_ru.VariantSearch.RequestElements;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class VariantSearchRQ
	{
		[XmlElement(Order = 0)]
		public List<Segment> segment { get; set; }

		[XmlElement(Order = 1)]
		public PassengersInformation passengers { get; set; }

		[XmlElement(Order = 2)]
		public SearchPreferences searchPreferences { get; set; }

		[XmlElement(Order = 3)]
		public BookingClassEnum bookingClass { get; set; }
	}
}
