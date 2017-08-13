using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType(Namespace = "")]
	public class TimeZone
	{
		[XmlAttribute]
		public int Departure { get; set; }

		[XmlAttribute]
		public int Arrival { get; set; }
	}
}
