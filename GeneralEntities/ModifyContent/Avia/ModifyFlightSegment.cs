using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent.Avia
{
	/// <summary>
	/// Содержит описание данных для модификации сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ModifyFlightSegment : BaseModifyItem
	{
		/// <summary>
		/// ИД сегмента в брони
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int SegmentID { get; set; }

		/// <summary>
		/// Аэропорт вылета
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string DepatureAirport { get; set; }

		/// <summary>
		/// Аэропорт прилёт
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string ArrivalAirport { get; set; }

		/// <summary>
		/// А/к предоставляющая рейс
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public string MarketingAirline { get; set; }

		/// <summary>
		/// Номер рейса
		/// </summary>
		[DataMember(Order = 5, IsRequired = true)]
		public string FlightNumber { get; set; }

		/// <summary>
		/// Дата и время вылета
		/// </summary>
		[DataMember(Order = 6, IsRequired = true)]
		public DateTimeEx DepatureDateTime { get; set; }

		/// <summary>
		/// Литера класса бронирования
		/// </summary>
		[DataMember(Order = 7, IsRequired = true)]
		public string BookingClassCode { get; set; }

		/// <summary>
		/// ID связанного сервиса
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public int? ServiceRef { get; set; }

		public ModifyFlightSegment Copy()
		{
			var result = new ModifyFlightSegment();
			CopyTo(result);

			result.SegmentID = SegmentID;
			result.DepatureAirport = DepatureAirport;
			result.ArrivalAirport = ArrivalAirport;
			result.MarketingAirline = MarketingAirline;
			result.FlightNumber = FlightNumber;
			result.BookingClassCode = BookingClassCode;
			result.ServiceRef = ServiceRef;
			result.DepatureDateTime = DepatureDateTime?.Copy();

			return result;
		}
	}
}