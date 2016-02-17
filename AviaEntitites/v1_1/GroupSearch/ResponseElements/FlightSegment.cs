using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Информация о сегменте перелёта, специфичная для конкретного перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightSegment_1_1")]
	public class FlightSegment : ItemIdentification<long>
	{
		/// <summary>
		/// Ссылка на маршрут, к которому относится данный сегмент перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public long ItineraryID { get; set; }

		/// <summary>
		/// Авиакомпания, непосредственно выполняющая рейс
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string OperatingCompany { get; set; }

		/// <summary>
		/// Код авиаперевозчика, предоставляющего данный рейс
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string MarketingCompany { get; set; }

		/// <summary>
		/// Фрахтователь чартерного рейса
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string Charterer { get; set; }

		/// <summary>
		/// Номер рейса
		/// </summary>
		[DataMember(Order = 5)]
		public string FlightNumber { get; set; }

		/// <summary>
		/// Тип самолёта
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string AircraftType { get; set; }

		/// <summary>
		/// Дата и время вылета
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public DateTimeEx DepatureDateTime { get; set; }

		/// <summary>
		/// Дата и время прилёта
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public DateTimeEx ArrivalDateTime { get; set; }

		/// <summary>
		/// Содержит информацию об остановке на данном сегменте
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public List<StopPoint> StopPoints { get; set; }

		/// <summary>
		/// Время в пути
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public int? FlightTime { get; set; }

		/// <summary>
		/// Индикатор возможности выписки электронного билета
		/// </summary>
		[DataMember(Order = 11)]
		public bool ETicket { get; set; }
	}
}