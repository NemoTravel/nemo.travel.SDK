using AviaEntities.v1_1.FlightSearch.ResponseElements;
using GeneralEntities;
using GeneralEntities.ExtendedDateTime;
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

		/// <summary>
		/// Полное копирование текущего объекта
		/// </summary>
		/// <returns>Полная копия объекта</returns>
		public ScheduleCompleteSegment FullCopy()
		{
			var result = new ScheduleCompleteSegment();

			result.AircraftType = AircraftType;
			result.ArrivalDaysChange = ArrivalDaysChange;
			result.ArrivalTime = ArrivalTime;
			result.ArrivalTimeString = ArrivalTimeString;
			result.Charterer = Charterer;
			result.DepartureDaysChange = DepartureDaysChange;
			result.DepartureTime = DepartureTime;
			result.DepartureTimeString = DepartureTimeString;
			result.EndDate = EndDate;
			result.ETicket = ETicket;
			result.FlightNumber = FlightNumber;
			result.FlightTime = FlightTime;
			result.ID = ID;
			result.MarkAirline = MarkAirline;
			result.OpAirline = OpAirline;
			result.StartDate = StartDate;

			if (ArrAirp != null)
			{
				result.ArrAirp = new AirportInformation();
				result.ArrAirp.AirportCode = ArrAirp.AirportCode;
				result.ArrAirp.CityCode = ArrAirp.CityCode;
				result.ArrAirp.Terminal = ArrAirp.Terminal;
				result.ArrAirp.UTC = ArrAirp.UTC;
			}

			if (DepAirp != null)
			{
				result.DepAirp = new AirportInformation();
				result.DepAirp.AirportCode = DepAirp.AirportCode;
				result.DepAirp.CityCode = DepAirp.CityCode;
				result.DepAirp.Terminal = DepAirp.Terminal;
				result.DepAirp.UTC = DepAirp.UTC;
			}

			if (BaseClasses != null && BaseClasses.Count > 0)
			{
				result.BaseClasses = new List<BaseClass>();
				BaseClasses.ForEach(bc => { result.BaseClasses.Add(bc); });
			}

			if (OperatedDaysOfWeek != null && OperatedDaysOfWeek.Count > 0)
			{
				result.OperatedDaysOfWeek = new DaysOfWeekList();
				OperatedDaysOfWeek.ForEach(dow => { result.OperatedDaysOfWeek.Add(dow); });
			}

			if (StopPoints != null && StopPoints.Count > 0)
			{
				result.StopPoints = new List<StopPoint>();

				foreach (var stopPoint in StopPoints)
				{
					var point = new StopPoint();

					point.AirportCode = stopPoint.AirportCode;
					point.ArrDateTime = stopPoint.ArrDateTime;
					point.CityCode = stopPoint.CityCode;
					point.DepDateTime = stopPoint.DepDateTime;
					point.Terminal = stopPoint.Terminal;
					point.UTC = stopPoint.UTC;

					result.StopPoints.Add(point);
				}
			}

			return result;
		}
	}
}