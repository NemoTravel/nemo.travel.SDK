using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.RequestElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightPreferences
	{
		[XmlElement(Order = 0, IsNullable = true)]
		public string aircompany { get; set; }

		[XmlElement(Order = 1)]
		public int flightNum { get; set; }

		[XmlElement(Order = 2, IsNullable = true)]
		public string letter { get; set; }
	}
}
