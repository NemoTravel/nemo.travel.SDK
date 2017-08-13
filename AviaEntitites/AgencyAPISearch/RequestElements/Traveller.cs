using GeneralEntities;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType(TypeName = "TravellerAgencyFormat")]
	public class Traveller
	{
		[XmlAttribute]
		public PassTypes Type { get; set; }

		[XmlAttribute]
		public int Count { get; set; }
	}
}
