using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements.Classifiers
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class LocalizedName
	{
		[XmlElement(Order = 0)]
		public string name { get; set; }

		[XmlElement(Order = 1)]
		public string lang { get; set; }
	}
}
