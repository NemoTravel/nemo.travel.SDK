using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию об идентификации сгруппированного перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPriceInfo_1_1")]
	public class FlightPriceInfo
	{
		/// <summary>
		/// ИД перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string FlightID { get; set; }

		/// <summary>
		/// ИД цены, которая определяет данный перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public IDList PriceIDs { get; set; }

		/// <summary>
		/// Информация о типизации данного перелёта по различным критериям
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public FlightTypeInfo TypeInfo { get; set; }

		/// <summary>
		/// Дополнительная ценовая информация перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public AdditionalPriceInfo AdditionalPriceInfo { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public int? ExpectedTicketCount { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string BookingURL { get; set; }
	}
}