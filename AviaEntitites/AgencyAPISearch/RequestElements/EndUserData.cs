using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.RequestElements
{
	[XmlType()]
	public class EndUserData
	{
		[XmlElement(IsNullable = false)]
		public string EndUserIP { get; set; }

		[XmlElement(IsNullable = false)]
		public string EndUserBrowserAgent { get; set; }

		[XmlElement(IsNullable = false)]
		public string RequestOrigin { get; set; }
	}
}
