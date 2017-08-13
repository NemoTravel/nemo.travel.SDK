using AviaEntities.AgencyAPISearch.Shared;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType()]
	public class BookingCode
	{
		[XmlAttribute]
		public ClassType ClassType { get; set; }

		[XmlElement(ElementName = "BookingCode")]
		public string Code { get; set; }
	}
}
