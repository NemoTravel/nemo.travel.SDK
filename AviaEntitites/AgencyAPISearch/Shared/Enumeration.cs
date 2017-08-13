using System.Xml.Serialization;

namespace AviaEntities.AgencyAPISearch.Shared
{
	[XmlType()]
	public enum ClassType
	{
		[XmlEnum("economy")]
		Economy = 0,
		[XmlEnum("business")]
		Business = 1,
		[XmlEnum("first")]
		First = 2
	}

	[XmlType()]
	public enum Supplier
	{
		/// <summary>
		/// GDS Sabre
		/// </summary>
		[XmlEnum("SABRE")]
		Sabre = 0,
		/// <summary>
		/// ГРС Сирена
		/// </summary>
		[XmlEnum("SIRENA2000")]
		Sirena = 1,
		/// <summary>
		/// GDS Galileo
		/// </summary>
		[XmlEnum("GALILEO")]
		Galileo = 2,
		/// <summary>
		/// GDS Amadeus
		/// </summary>
		[XmlEnum("AMADEUS")]
		Amadeus = 3,
		/// <summary>
		/// GDS SITA Gabriel
		/// </summary>
		[XmlEnum("SITA")]
		SITAGabriel = 4,
		/// <summary>
		/// GDS SpecialFares
		/// </summary>
		[XmlEnum("SPECIALFARES")]
		SpecialFares = 5,
		/// <summary>
		/// Вип сервис
		/// </summary>
		[XmlEnum("SIG23")]
		SIG = 6,
		/// <summary>
		/// Немо инвентори
		/// </summary>
		[XmlEnum("INVENTORY")]
		NemoInventory = 7,
		[XmlEnum("TRAVELFUSION")]
		Travelfusion = 8,
		/// <summary>
		/// Mystifly
		/// </summary>
		[XmlEnum("MYSTIFLY")]
		Mystifly = 9,
		[XmlEnum("GALILEOUAPI")]
		GalileoUAPI = 10
	}
}
