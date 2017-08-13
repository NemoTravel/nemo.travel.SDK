using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.RequestElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchPreferences
	{
		[XmlElement(Order = 0)]
		public string preferredLanguage { get; set; }

		[XmlElement(Order = 1)]
		public bool directFlightsOnly { get; set; }

		[XmlElement(Order = 2)]
		public bool retrieveAircompanyLogo { get; set; }

		[XmlElement(Order = 3, IsNullable = true)]
		public string prefferedAirconmpany { get; set; }
	}
}
