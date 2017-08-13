using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch
{
	[XmlRoot(Namespace = "")]
	public class ResponseBin
	{
		[XmlElement]
		public Response Response { get; set; }
	}
}
