using AviaEntities.SharedElements;
using GeneralEntities.PNRDataContent;
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
	}
}