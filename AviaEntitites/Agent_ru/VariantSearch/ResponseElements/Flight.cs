using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.Agent_ru.VariantSearch.ResponseElements
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public class Flight
	{
		[XmlElement(Order = 0)]
		public string origin { get; set; }

		[XmlElement(Order = 1)]
		public string originAirport { get; set; }

		[XmlElement(Order = 2)]
		public double originAirportScore { get; set; }

		[XmlElement(Order = 3)]
		public string destination { get; set; }

		[XmlElement(Order = 4)]
		public string destinationAirport { get; set; }

		[XmlElement(Order = 5)]
		public double destinationAirportScore { get; set; }

		[XmlElement(Order = 6)]
		public DateTimeEx departureDateTime { get; set; }

		[XmlElement(Order = 7)]
		public DateTimeEx arrivalDateTime { get; set; }

		[XmlElement(Order = 8)]
		public string flightNum { get; set; }

		[XmlElement(Order = 9)]
		public string marketingAircompany { get; set; }

		[XmlElement(Order = 10)]
		public string operatingAircompany { get; set; }

		[XmlElement(Order = 11)]
		public int flightTimeInMinutes { get; set; }

		[XmlElement(Order = 12)]
		public List<Fare> fare { get; set; }

		[XmlElement(Order = 13)]
		public string subclassCode { get; set; }

		[XmlElement(Order = 14)]
		public bool confirmed { get; set; }

		[XmlElement(Order = 15)]
		public bool connectedFlight { get; set; }

		[XmlElement(Order = 16)]
		public string vehicle { get; set; }

		[XmlElement(Order = 17)]
		public int stopsCount { get; set; }
	}
}
