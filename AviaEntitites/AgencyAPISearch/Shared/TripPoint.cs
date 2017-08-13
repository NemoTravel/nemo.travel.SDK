using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.Shared
{
	[XmlType]
	public class TripPoint
	{
		[XmlAttribute]
		public string CodeType { get; set; }

		[XmlAttribute]
		public string Name { get; set; }

		[XmlText]
		public string Code { get; set; }
	}
}
