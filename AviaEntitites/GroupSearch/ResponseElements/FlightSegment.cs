using AviaEntities.FlightSearch.ResponseElements;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Информация о сегменте перелёта, специфичная для конкретного перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
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
		/// Номер рейса
		/// </summary>
		[DataMember(Order = 4)]
		public int FlightNumber { get; set; }

		/// <summary>
		/// Тип самолёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string AircraftType { get; set; }

		/// <summary>
		/// Дата и время вылета
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public DateTimeEx DepatureDateTime { get; set; }

		/// <summary>
		/// Дата и время прилёта
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public DateTimeEx ArrivalDateTime { get; set; }

		/// <summary>
		/// Время в пути
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public int? FlightTime { get; set; }

		/// <summary>
		/// Пустой конструктор, нужен в том числе для сериализации объекта
		/// </summary>
		public FlightSegment()
		{ }

		/// <summary>
		/// Создание объекта сегмента сгруппированного перелёта на основании полного сегмента перелёта
		/// </summary>
		/// <param name="segment">Полный сегмент перелёта</param>
		/// <param name="itineraryID">ИД маршрута, на котором выполняется данный сегмент перелёта</param>
		public FlightSegment(CompleteSegment segment, long itineraryID)
		{
			ItineraryID = itineraryID;
			OperatingCompany = segment.OpAirline;
			MarketingCompany = segment.MarkAirline;
			FlightNumber = segment.FlightNumber;
			AircraftType = segment.AircraftType;
			DepatureDateTime = segment.DepDateTime;
			ArrivalDateTime = segment.ArrDateTime;
			FlightTime = segment.FlightTime;
		}
	}
}