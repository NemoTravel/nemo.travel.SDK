using AviaEntities.SharedElements;
using AviaEntities.SharedElements.Ancillaries;
using AviaEntities.SharedElements.Ancillaries.RequestElements;
using GeneralEntities.PNRDataContent;
using GeneralEntities.Shared;
using GeneralEntities.Traveller;
using System.Runtime.Serialization;

namespace AviaEntities.v2.BookFlight
{
	/// <summary>
	/// Содержит описание запроса на создание брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookFlightRQBody_2_0")]
	public class BookFlightRQBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Информация о клиентах
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public TravellerList Travellers { get; set; }

		/// <summary>
		/// Унифицированные данные брони
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }

		/// <summary>
		/// Дополнительные действия при создании брони
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public AdditionalBookingActions AdditionalActions { get; set; }

		/// <summary>
		/// Опции тарификации брони
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public PricingOptions PricingOptions { get; set; }

		/// <summary>
		/// Список допуслуг для бронирования
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public AncillaryServices<AncillaryServiceRQ> AncillaryServices { get; set; }

		/// <summary>
		/// Теги для ЦО
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public int? RefererID { get; set; }
	}
}