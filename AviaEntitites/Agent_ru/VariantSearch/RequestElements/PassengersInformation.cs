using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.RequestElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class PassengersInformation
	{
		[XmlElement(Order = 0)]
		public int adultsCount { get; set; }

		[XmlElement(Order = 1)]
		public int childrenCount { get; set; }

		[XmlElement(Order = 2)]
		public int infantsCount { get; set; }

		[XmlElement(Order = 3)]
		public int infantsWithoutSeatCount { get; set; }
	}
}
