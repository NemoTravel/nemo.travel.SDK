using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType]
	public class Error
	{
		[XmlElement(Order = 0)]
		public string Code { get; set; }

		[XmlElement(Order = 1)]
		public string ServiceErrorMessage { get; set; }

		[XmlElement(Order = 2)]
		public string Message { get; set; }
	}
}
