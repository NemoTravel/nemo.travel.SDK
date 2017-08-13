using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType()]
	public class Source
	{
		[XmlElement(Order = 0)]
		public string ClientId { get; set; }

		[XmlElement(Order = 1)]
		public string APIKey { get; set; }

		[XmlElement(Order = 2)]
		public string Language { get; set; }

		[XmlElement(Order = 3)]
		public string Currency { get; set; }

		[XmlElement(Order = 4)]
		public bool ShowNames { get; set; }

		[XmlElement(Order = 5)]
		public EndUserData EndUserData { get; set; }
	}
}
