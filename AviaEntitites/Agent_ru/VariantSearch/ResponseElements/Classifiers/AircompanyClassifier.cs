using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements.Classifiers
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class AircompanyClassifier : AbstractClassifier
	{
		[XmlElement(Order = 4)]
		public string logo { get; set; }
	}
}
