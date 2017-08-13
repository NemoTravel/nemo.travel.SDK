using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class PassengerFare
	{
		[XmlAttribute]
		public PassTypes Type { get; set; }

		[XmlAttribute]
		public int Quantity { get; set; }

		[XmlElement(Order = 0)]
		public Money BaseFare { get; set; }

		[XmlElement(Order = 1)]
		public Money EquiveFare { get; set; }

		[XmlElement(Order = 2)]
		public Money TotalFare { get; set; }

		[XmlArray(Order = 3)]
		[XmlArrayItem(ElementName = "Tax")]
		public List<Tax> Taxes { get; set; }

		[XmlArray(Order = 4)]
		[XmlArrayItem(ElementName = "Tariff")]
		public List<Tariff> Tariffs { get; set; }

		[XmlElement(Order = 5)]
		public string FareCalc { get; set; }

		[XmlElement(Order = 6)]
		public DateTimeEx LastTicketDateTime { get; set; }
	}
}
