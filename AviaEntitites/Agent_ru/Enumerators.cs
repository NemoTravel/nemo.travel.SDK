using System.Xml.Serialization;

namespace AviaEntities.Agent_ru
{
	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum BookingClassEnum
	{
		[XmlEnum]
		ECONOMIC,
		[XmlEnum]
		BUSINESS,
		[XmlEnum]
		FIRST
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum TimePreferenceEnum
	{
		[XmlEnum(Name = "AnyTime")]
		ANY_TIME,
		[XmlEnum(Name = "Morning")]
		MORNING,
		[XmlEnum(Name = "Day")]
		DAY,
		[XmlEnum(Name = "Evening")]
		EVENING,
		[XmlEnum(Name = "Night")]
		NIGHT
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum FlightPointTypeEnum
	{
		[XmlEnum]
		CITY,
		[XmlEnum]
		AIRPORT,
		[XmlEnum]
		CITY_PREFFERED,
		[XmlEnum]
		AIRPORT_PREFFERED
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum CategoryTypeEnum
	{
		[XmlEnum]
		ADULT,
		[XmlEnum]
		CHILD,
		[XmlEnum]
		INFANT,
		[XmlEnum]
		INFANT_WITH_SEAT
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum TicketTypeEnum
	{
		[XmlEnum]
		PAPER_TICKET,
		[XmlEnum]
		ELECTRONIC_TICKET
	}

	[XmlType(Namespace = "http://nemo-ibe.com/Avia")]
	public enum GDSEnum
	{
		[XmlEnum]
		SIRENA,
		[XmlEnum]
		SABRE,
		[XmlEnum]
		LOW_FARE,
		[XmlEnum]
		AMADEUS
	}
}
