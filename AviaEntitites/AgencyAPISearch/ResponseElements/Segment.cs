using AviaEntities.AgencyAPISearch.Shared;
using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.ResponseElements
{
	[XmlType()]
	public class Segment
	{
		[XmlAttribute]
		public long SegNum { get; set; }

		[XmlAttribute]
		public int SegGroupNum { get; set; }

		[XmlIgnore]
		public bool SegGroupNumSpecified { get; set; }

		[XmlElement(Order = 0)]
		public string SupplierCode { get; set; }

		[XmlIgnore]
		public bool SupplierCodeSpecified
		{
			get
			{
				return !string.IsNullOrEmpty(SupplierCode);
			}
		}

		[XmlElement(Order = 1)]
		public TripPoint DepAirp { get; set; }

		[XmlElement(Order = 2)]
		public string DepTerminal { get; set; }

		[XmlIgnore]
		public bool DepTerminalSpecified
		{
			get
			{
				return !string.IsNullOrEmpty(DepTerminal);
			}
		}

		[XmlElement(Order = 3)]
		public TripPoint ArrAirp { get; set; }

		[XmlElement(Order = 4)]
		public string ArrTerminal { get; set; }

		[XmlIgnore]
		public bool ArrTerminalSpecified
		{
			get
			{
				return !string.IsNullOrEmpty(ArrTerminal);
			}
		}

		[XmlElement(Order = 5)]
		public string OpAirline { get; set; }

		[XmlElement(Order = 6)]
		public string OpAirlineName { get; set; }

		[XmlElement(Order = 7)]
		public string OpAirlineLogo { get; set; }

		[XmlElement(Order = 8)]
		public string MarkAirline { get; set; }

		[XmlElement(Order = 9)]
		public string MarkAirlineName { get; set; }

		[XmlElement(Order = 10)]
		public string MarkAirlineLogo { get; set; }

		[XmlElement(Order = 11)]
		public string FlightNumber { get; set; }

		[XmlElement(Order = 12)]
		public string AircraftName { get; set; }

		[XmlElement(Order = 13)]
		public string AircraftType { get; set; }

		[XmlElement(Order = 14)]
		public DateTimeEx DepDateTime { get; set; }

		[XmlElement(Order = 15)]
		public DateTimeEx ArrDateTime { get; set; }

		[XmlElement(Order = 16)]
		public int StopNum { get; set; }

		[XmlArray(Order = 17)]
		[XmlArrayItem(ElementName = "BookingCode")]
		public List<BookingCode> BookingCodes { get; set; }

		[XmlElement(Order = 18)]
		public int? FlightTime { get; set; }

		[XmlIgnore]
		public bool FlightTimeSpecified
		{
			get
			{
				return FlightTime.HasValue;
			}
		}

		[XmlElement(Order = 19)]
		public int RemainingSeats { get; set; }

		[XmlElement(Order = 20)]
		public TimeZone TimeZone { get; set; }

		[XmlIgnore]
		public bool TimeZoneSpecified
		{
			get
			{
				return TimeZone != null;
			}
		}

		[XmlElement(Order = 21)]
		public bool ETicket { get; set; }

		[XmlElement(Order = 22, ElementName = "isCharter")]
		public bool IsCharter { get; set; }

		[XmlArray(Order = 23)]
		[XmlArrayItem(ElementName = "BaggageAllowance")]
		public List<BaggageAllowance> BaggageAllowances { get; set; }

		[XmlIgnore]
		public bool BaggageAllowancesSpecified
		{
			get
			{
				return BaggageAllowances != null && BaggageAllowances.Count > 0;
			}
		}
	}
}
