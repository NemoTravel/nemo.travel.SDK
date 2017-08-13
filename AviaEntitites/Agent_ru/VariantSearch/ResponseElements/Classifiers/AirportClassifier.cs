using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements.Classifiers
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class AirportClassifier : AbstractClassifier
	{
		[XmlElement(Order = 4)]
		public CityClassifier city { get; set; }

		[XmlElement(Order = 5)]
		public decimal latitude { get; set; }

		[XmlElement(Order = 6)]
		public decimal longitude { get; set; }

		[XmlElement(Order = 7)]
		public string timezone { get; set; }

		[XmlElement(Order = 8)]
		public string icaoCode { get; set; }
	}
}
