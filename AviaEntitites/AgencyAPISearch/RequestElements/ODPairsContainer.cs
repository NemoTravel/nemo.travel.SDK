using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType]
	public class ODPairsContainer
	{
		[XmlAttribute]
		public string Type { get; set; }

		[XmlAttribute]
		public bool Direct { get; set; }

		[XmlAttribute]
		public uint AroundDates { get; set; }

		[XmlElement(Order = 0)]
		public List<ODPair> ODPair { get; set; }
	}
}
