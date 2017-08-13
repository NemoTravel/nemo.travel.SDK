using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class PricedVariant
	{
		[XmlElement(Order = 0)]
		public List<ItinerarySegment> itinerarySegment { get; set; }

		[XmlElement(Order = 1)]
		public Price price { get; set; }

		[XmlElement(Order = 2)]
		public Price basePrice { get; set; }

		[XmlElement(Order = 3)]
		public TicketTypeEnum ticketType { get; set; }

		[XmlElement(Order = 4)]
		public List<DiscountedPrice> discountedPrice { get; set; }

		[XmlIgnore]
		public string url { get; set; }

		[XmlElement("url", Order = 5)]
		public XmlCDataSection urlCDATA
		{
			get
			{
				return new XmlDocument().CreateCDataSection(url);
			}
			set
			{
				url = value.Value;
			}
		}


		[XmlElement(Order = 6)]
		public GDSEnum gds { get; set; }

		[XmlElement(Order = 7)]
		public bool latinRegistration { get; set; }

		[XmlElement(Order = 8)]
		public string ticketBlankHolderCode { get; set; }

		[XmlElement(Order = 9)]
		public string urlWithoutPassengers { get; set; }

		[XmlElement(Order = 10)]
		public BookingClassEnum bookingClass { get; set; }
	}
}
