using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class Fare
	{
		[XmlElement(Order = 0)]
		public string fareCode { get; set; }

		[XmlElement(Order = 1)]
		public CategoryTypeEnum passengerCategory { get; set; }

		[XmlElement(Order = 2)]
		public string categoryCode { get; set; }

		[XmlElement(Order = 3)]
		public string additionalInfo { get; set; }
	}
}
