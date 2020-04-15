using GeneralEntities.ExtendedDateTime;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит описание сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "CompleteSegment_1_1")]
	public class CompleteSegment : AirItinerary
	{
		/// <summary>
		/// Номер рейса
		/// </summary>
		[DataMember(IsRequired = true, Order = 5)]
		public string FlightNumber { get; set; }

		/// <summary>
		/// Время в пути в минутах
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public int? FlightTime { get; set; }

		/// <summary>
		/// А/к, непосредственно выполняющая рейс
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string OpAirline { get; set; }

		/// <summary>
		/// Код авиаперевозчика, предоставляющего данный рейс
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string MarkAirline { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public string Charterer { get; set; }

		/// <summary>
		/// Тип самолёта
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public string AircraftType { get; set; }

		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public DateTimeEx DepDateTime { get; set; }

		/// <summary>
		/// Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public DateTimeEx ArrDateTime { get; set; }

		/// <summary>
		/// Доступные классы перелёта для данного сегмента
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public BookingClass BookingClass { get; set; }

		/// <summary>
		/// Индикатор возможности выписки электронного билета
		/// </summary>
		[DataMember(Order = 14)]
		public bool ETicket { get; set; }

		/// <summary>
		/// Содержит информацию об остановке на данном сегменте
		/// </summary>
		[DataMember(Order = 15, EmitDefaultValue = false)]
		public List<StopPoint> StopPoints { get; set; }

		/// <summary>
		/// Информация о данном сегменте от поставщика
		/// </summary>
		[DataMember(Order = 16, EmitDefaultValue = false)]
		public SupplierSegmentInfo SupplierInfo { get; set; }

		/// <summary>
		/// Порядковый номер сегмента из запроса на поиск
		/// </summary>
		[DataMember(Order = 17, EmitDefaultValue = false)]
		public int? RequestedSegment { get; set; }

		/// <summary>
		/// Номер рейса а/к выполняющей рейс
		/// </summary>
		[DataMember(Order = 18, EmitDefaultValue = false)]
		public string OpFlightNumber { get; set; }

		/// <summary>
		/// Выброс CO2 в кг/км
		/// </summary>
		[DataMember(Order = 19, EmitDefaultValue = false)]
		public double CO2Emission { get; set; }

		/// <summary>
		/// Длина пути в милях
		/// </summary>
		[DataMember(Order = 20, EmitDefaultValue = false)]
		public double FlightDistance { get; set; }

		/// <summary>
		/// Индикатор наземного сегмента
		/// </summary>
		[DataMember(Order = 22, EmitDefaultValue = false)]
		public bool NotAirplaneSegmentInd { get; set; }
	}
}