using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements.Classifiers
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public abstract class AbstractClassifier
	{
		[XmlElement(Order = 0)]
		public string refId { get; set; }

		[XmlElement(Order = 1)]
		public string code { get; set; }

		[XmlElement(Order = 2)]
		public string iataCode { get; set; }

		[XmlElement(Order = 3)]
		public LocalizedName name { get; set; }
	}
}
