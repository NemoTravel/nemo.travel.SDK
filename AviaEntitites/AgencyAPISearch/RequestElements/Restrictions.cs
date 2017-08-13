using GeneralEntities;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType()]
	public class Restrictions
	{
		[XmlElement(Order = 0)]
		public Shared.ClassType? ClassPref { get; set; }

		[XmlArray(Order = 1)]
		[XmlArrayItem(ElementName = "AirVPref")]
		public List<AirVPref> AirVPrefs { get; set; }

		[XmlElement(Order = 2)]
		public bool IncludePrivateFare { get; set; }

		[XmlElement(Order = 3)]
		public string CurrencyCode { get; set; }

		[XmlElement(Order = 4)]
		public PriceRefundType? PriceRefundType { get; set; }
	}
}
