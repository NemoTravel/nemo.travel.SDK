using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class ItinerarySegment
	{
		[XmlAttribute]
		public int stopover { get; set; }

		[XmlElement]
		public List<Flight> flight { get; set; }
	}
}
