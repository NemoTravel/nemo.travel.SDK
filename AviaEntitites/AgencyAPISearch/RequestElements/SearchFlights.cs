using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType]
	public class SearchFlights
	{
		[XmlAttribute]
		public bool LinkOnly { get; set; }

		[XmlElement(Order = 0)]
		public ODPairsContainer ODPairs { get; set; }

		[XmlArray(Order = 1)]
		[XmlArrayItem(ElementName = "Traveller")]
		public List<Traveller> Travellers { get; set; }

		[XmlElement(Order = 2)]
		public Restrictions Restrictions { get; set; }
	}
}
