using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
using SharedAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.ResponseElements
{
	/// <summary>
	/// Содержит описание сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ScheduleCompleteSegment : AirItinerary
	{
		const string TIME_FORMAT = "hh\\:mm";

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
		/// Время отправления в формате HH:mm
		/// </summary>
		[IgnoreDataMember]
		public TimeSpan DepartureTime { get; set; }

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		[DataMember(Order = 11, EmitDefaultValue = false, Name = "DepartureTime")]
		public string DepartureTimeString
		{
			get { return DepartureTime.ToString(TIME_FORMAT); }
			set { DepartureTime = TimeSpan.ParseExact(value, TIME_FORMAT, null); }
		}

		/// <summary>
		/// Время прибытия в формате HH:mm
		/// </summary>
		[IgnoreDataMember]
		public TimeSpan ArrivalTime { get; set; }

		[Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
		[DataMember(Order = 12, EmitDefaultValue = false, Name = "ArrivalTime")]
		public string ArrivalTimeString
		{
			get { return ArrivalTime.ToString(TIME_FORMAT); }
			set { ArrivalTime = TimeSpan.ParseExact(value, TIME_FORMAT, null); }
		}

		/// <summary>
		/// Смещение дня вылета относительно даты вылета первого сегмента всего перелёта
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public int DepartureDaysChange { get; set; }

		/// <summary>
		/// Смещение дня прибытия относительно дня вылета
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public int ArrivalDaysChange { get; set; }

		/// <summary>
		/// Дата начала периода вылетов в формате yyyy-MM-dd
		/// </summary>
		[DataMember(Order = 15, EmitDefaultValue = false)]
		public DateTimeEx StartDate
		{
			get { return startDate; } 
			set
			{ 
				startDate = value; 
				if (startDate != null) 
					startDate.OutFormat = Formats.DATE_WITH_DASHES_FORMAT;
			}
		}

		private DateTimeEx startDate;

		/// <summary>
		/// Дата окончания периодов вылетов в формате yyyy-MM-dd
		/// </summary>
		[DataMember(Order = 16, EmitDefaultValue = false)]
		public DateTimeEx EndDate
		{
			get { return endDate; }
			set
			{
				endDate = value;
				if (endDate != null)
					endDate.OutFormat = Formats.DATE_WITH_DASHES_FORMAT;
			}
		}

		private DateTimeEx endDate;

		/// <summary>
		/// Дни вылетов
		/// </summary>
		[DataMember(Order = 17, EmitDefaultValue = false)]
		public DaysOfWeekList OperatedDaysOfWeek { get; set; }

		/// <summary>
		/// Доступные базовые классы перелётов
		/// </summary>
		[DataMember(Order = 18, EmitDefaultValue = false)]
		public List<BaseClass> BaseClasses { get; set; }

		/// <summary>
		/// Индикатор возможности выписки электронного билета
		/// </summary>
		[DataMember(Order = 19)]
		public bool ETicket { get; set; }

		/// <summary>
		/// Содержит информацию об остановке на данном сегменте
		/// </summary>
		[DataMember(Order = 20, EmitDefaultValue = false)]
		public List<StopPoint> StopPoints { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public ScheduleCompleteSegment()
		{
			DepAirp = new AirportInformation();
			ArrAirp = new AirportInformation();
		}
	}
}