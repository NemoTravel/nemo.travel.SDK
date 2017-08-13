using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class Tariff
	{
		[XmlAttribute]
		public string Code { get; set; }

		[XmlAttribute]
		public int SegNum { get; set; }
	}
}
