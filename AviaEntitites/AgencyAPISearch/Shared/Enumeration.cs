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
		/// <summary>
		/// Galileo uAPI
		/// </summary>
		[XmlEnum("GALILEOUAPI")]
		GalileoUAPI = 10,
		/// <summary>
		/// PEGAS Touristik
		/// </summary>
		[XmlEnum("PEGASYS")]
		Pegasys = 11,
		/// <summary>
		/// Немо-немо
		/// </summary>
		[XmlEnum("NEMO")]
		Nemo = 12,
		/// <summary>
		/// Farelogix
		/// </summary>
		[XmlEnum("FARELOGIX")]
		Farelogix = 14,
		/// <summary>
		/// S7 NDC API
		/// </summary>
		[XmlEnum("S7NDC")]
		S7NDC = 15,

		// [XmlEnum("ATLASGLOBAL")]
		// Atlasglobal = 16 - (Удален)

		/// <summary>
		/// Навитэир
		/// </summary>
		[XmlEnum("NAVITAIRE")]
		Navitaire = 17,
		/// <summary>
		/// Radixx
		/// </summary>
		[XmlEnum("RADIXX")]
		Radixx = 18,
		/// <summary>
		/// AccelAero
		/// </summary>
		[XmlEnum("ACCELAERO")]
		AccelAero = 19,
		/// <summary>
		/// Kiwi.com
		/// </summary>
		[XmlEnum("KIWI")]
		Kiwi = 22,
		/// <summary>
		/// Aeroflot
		/// </summary>
		[XmlEnum("AEROFLOTNDC")]
		AeroflotNDC = 24,
		/// <summary>
		/// Hitit
		/// </summary>
		[XmlEnum("HITIT")]
		Hitit = 25,
		/// <summary>
		/// SolringNDC
		/// </summary>
		[XmlEnum("SOLRINGNDC")]
		SolringNDC = 26
	}
}
