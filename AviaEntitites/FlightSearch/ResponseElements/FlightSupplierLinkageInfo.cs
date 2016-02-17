using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит некие идентификаторы данного перелёта в системах поставщиков, необходимые для дальнейших операций с ним (бронирование или ещё что-то)
	/// </summary>
	[Serializable]
	public class FlightSupplierLinkageInfo
	{
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string SIGSessionID { get; set; }

		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string SIGShopOptionRef { get; set; }

		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public List<string> SIGItineraryRefs { get; set; }

		/// <summary>
		/// Идентификатор фарианта перелёта для ГДС SpecialFares
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string VariantID { get; set; }
	}
}