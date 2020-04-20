using AviaEntities.SharedElements;
using AviaEntities.SharedElements.Ancillaries;
using AviaEntities.v1_1.SharedElements.Ancillaries.RequestElements;
using AviaEntities.v2.BookFlight;
using GeneralEntities.PNRDataContent;
using GeneralEntities.Shared;
using GeneralEntities.Traveller;
using SharedAssembly.Extensions;
using System.Linq;
using System.Runtime.Serialization;

namespace AviaEntities.v2_1.BookFlight
{
	/// <summary>
	/// Содержит описание запроса на создание брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookFlightRQBody_2_1")]
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

		public BookFlightRQBody Clone()
		{
			var result = new BookFlightRQBody();

			result.FlightID = FlightID;

			if (Travellers != null)
			{
				result.Travellers = new TravellerList(Travellers.Select(t => t.Copy()));
			}

			if (DataItems != null)
			{
				result.DataItems = new PNRDataItemList(DataItems.Select(di => di.Copy()));
			}

			result.AdditionalActions = AdditionalActions?.Copy();
			result.PricingOptions = PricingOptions?.Clone();

			if (AncillaryServices != null)
			{
				result.AncillaryServices = new AncillaryServices<AncillaryServiceRQ>(AncillaryServices.Select(s => s.Copy()));
			}

			if (RequestorTags != null)
			{
				result.RequestorTags = new TagList(RequestorTags);
			}

			result.RefererID = RefererID;

			return result;
		}
	}
}