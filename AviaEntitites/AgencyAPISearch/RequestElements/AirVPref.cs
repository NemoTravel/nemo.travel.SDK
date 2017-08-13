using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType()]
	public class AirVPref
	{
		[XmlAttribute]
		public string Code { get; set; }

		[XmlAttribute]
		public bool Include { get; set; }

		[XmlAttribute]
		public string Type { get; set; }
	}
}
