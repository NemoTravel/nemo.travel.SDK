using AviaEntities.AgencyAPISearch.RequestElements;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch
{
	[XmlRoot(Namespace ="")]
	public class RequestBin
	{
		[XmlElement(Order = 0)]
		public AgencyAPISearchRQBody Request { get; set; }

		[XmlElement(Order = 1)]
		public Source Source { get; set; }
	}
}
