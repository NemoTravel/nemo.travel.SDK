using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Avia
{
	/// <summary>
	/// Содержит описание сегмента авиа услуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightSegment : ItemIdentification<int>
	{
		/// <summary>
		/// ИД сегмента в ПНРе поставщика
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string IDInPNR { get; set; }

		/// <summary>
		/// Аэропорт отправления
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public TripPointInformation DepatureAirport { get; set; }

		/// <summary>
		/// Аэропорт прибытия
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public TripPointInformation ArrivalAirport { get; set; }

		/// <summary>
		/// Содержит информацию об остановке на данном сегменте
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public StopPointList StopPoints { get; set; }

		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public DateTimeEx DepatureDateTime { get; set; }

		/// <summary>
		/// Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 5, IsRequired = true)]
		public DateTimeEx ArrivalDateTime { get; set; }

		/// <summary>
		/// Время в пути в минутах
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public int? FlightTime { get; set; }

		/// <summary>
		/// Номер рейса
		/// </summary>
		[DataMember(Order = 7, IsRequired = true)]
		public string FlightNumber { get; set; }

		/// <summary>
		/// Тип самолёта
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string AircraftType { get; set; }

		/// <summary>
		/// А/к, непосредственно выполняющая рейс
		/// </summary>
		[DataMember(Order = 9, IsRequired = true)]
		public string OperatingAirline { get; set; }

		/// <summary>
		/// Код авиаперевозчика, предоставляющего данный рейс
		/// </summary>
		[DataMember(Order = 10, IsRequired = true)]
		public string MarketingAirline { get; set; }

		/// <summary>
		/// Фрахтователь чартерного рейса
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public string Charterer { get; set; }

		/// <summary>
		/// Индикатор возможности выписки электронного билета
		/// </summary>
		[DataMember(Order = 12, IsRequired = true)]
		public bool ETicket { get; set; }

		/// <summary>
		/// Класс перелёта
		/// </summary>
		[DataMember(Order = 13, IsRequired = true)]
		public string BookingClassCode { get; set; }

		/// <summary>
		/// Статус сегмента в системе поставщика
		/// </summary>
		[DataMember(Order = 14, IsRequired = true)]
		public PNRContentStatus Status { get; set; }

		/// <summary>
		/// Код статуса сегмента в системе поставщика
		/// </summary>
		[DataMember(Order = 15, IsRequired = true)]
		public string StatusCode { get; set; }

		/// <summary>
		/// Код брони для данного сегмента в системе а/к
		/// </summary>
		[DataMember(Order = 16, EmitDefaultValue = false)]
		public string SupplierRef { get; set; }

		/// <summary>
		/// Порядковый номер сегмента из запроса на поиск
		/// </summary>
		[DataMember(Order = 17, EmitDefaultValue = false)]
		public int? RequestedSegment { get; set; }

		/// <summary>
		/// Номер рейса а/к выполняющей рейс
		/// </summary>
		[DataMember(Order = 18, EmitDefaultValue = false)]
		public string OperatingFlightNumber { get; set; }

		/// Выброс CO2 в кг/км
		/// </summary>
		[DataMember(Order = 19, EmitDefaultValue = false)]
		public double CO2Emission { get; set; }

		/// <summary>
		/// Длина пути в милях
		/// </summary>
		[DataMember(Order = 20, EmitDefaultValue = false)]
		public double FlightDistance { get; set; }

		/// Имя типа самолета. Специфика Фейрлоджикса
		/// </summary>
		[DataMember(Order = 21, EmitDefaultValue = false)]
		public string AircraftName { get; set; }

		/// <summary>
		/// Статус купона
		/// </summary>
		[DataMember(Order = 22, EmitDefaultValue = false)]
		public CouponStatus? CouponStatus { get; set; }

		/// <summary>
		/// Индикатор наземного сегмента
		/// </summary>
		[DataMember(Order = 23, EmitDefaultValue = false)]
		public bool NotAirplaneSegmentInd { get; set; }
	}
}