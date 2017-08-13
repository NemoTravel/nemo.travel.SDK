using GeneralEntities;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType()]
	public class BaggageAllowance
	{
		[XmlElement]
		public PassTypes PassengerType { get; set; }

		[XmlElement]
		public int Value { get; set; }

		[XmlElement]
		public string Measurement { get; set; }
	}
}
