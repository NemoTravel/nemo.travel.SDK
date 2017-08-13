using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.RequestElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightPoint
	{
		[XmlElement(Order = 0)]
		public string code { get; set; }

		[XmlElement(Order = 1)]
		public FlightPointTypeEnum pointType { get; set; }
	}
}
