using GeneralEntities.ExtendedDateTime;
using GeneralEntities.Market;
using GeneralEntities.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит описание сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class CompleteSegment : AirItinerary
	{
		/// <summary>
		/// Номер рейса
		/// </summary>
		[DataMember(IsRequired = true, Order = 5)]
		public int FlightNumber { get; set; }

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

		/// <summary>
		/// Тип самолёта
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public string AircraftType { get; set; }

		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public DateTimeEx DepDateTime { get; set; }

		/// <summary>
		/// Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public DateTimeEx ArrDateTime { get; set; }

		/// <summary>
		/// Доступные классы перелёта для данного сегмента
		/// </summary>
		[DataMember(Order = 12, Name = "BookingClass", EmitDefaultValue = false)]
		public BookingClass BookingClassInfo { get; set; }

		/// <summary>
		/// Информация о данном сегменте от поставщика
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public SupplierSegmentInfo SupplierInfo { get; set; }

		/// <summary>
		/// Порядковый номер сегмента из запроса на поиск
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public int? RequestedSegment { get; set; }

		/// <summary>
		/// Индикатор конект сегмента
		/// </summary>
		[IgnoreDataMember]
		[JsonProperty]
		public bool Connection { get; set; }


		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public CompleteSegment()
		{
		}

		/// <summary>
		/// Полное копирование текущего объекта
		/// </summary>
		/// <returns>Полная копия объекта</returns>
		public CompleteSegment FullCopy()
		{
			var result = new CompleteSegment();

			result.AircraftType = AircraftType;
			result.ArrDateTime = ArrDateTime;
			result.Connection = Connection;
			result.DepDateTime = DepDateTime;
			result.ETicket = ETicket;
			result.FlightNumber = FlightNumber;
			result.FlightTime = FlightTime;
			result.ID = ID;
			result.MarkAirline = MarkAirline;
			result.OpAirline = OpAirline;
			result.RequestedSegment = RequestedSegment;
			result.StopNum = StopNum;

			if (ArrAirp != null)
			{
				result.ArrAirp = new AirportInformation();
				result.ArrAirp.AirportCode = ArrAirp.AirportCode;
				result.ArrAirp.CityCode = ArrAirp.CityCode;
				result.ArrAirp.Terminal = ArrAirp.Terminal;
				result.ArrAirp.UTC = ArrAirp.UTC;
			}

			if (BookingClassInfo != null)
			{
				result.BookingClassInfo = new BookingClass();
				result.BookingClassInfo.BaseClass = BookingClassInfo.BaseClass;
				result.BookingClassInfo.BookingClassCode = BookingClassInfo.BookingClassCode;
				result.BookingClassInfo.FreeSeatCount = BookingClassInfo.FreeSeatCount;
				result.BookingClassInfo.MealType = BookingClassInfo.MealType;

				if (BookingClassInfo.Baggage != null)
				{
					result.BookingClassInfo.Baggage = new Baggage();
					result.BookingClassInfo.Baggage.Measure = BookingClassInfo.Baggage.Measure;
					result.BookingClassInfo.Baggage.Value = BookingClassInfo.Baggage.Value;
				}

				if (BookingClassInfo.AdditionalServices != null)
				{
					result.BookingClassInfo.AdditionalServices = new List<AdditionalService>();
					foreach (var addService in BookingClassInfo.AdditionalServices)
					{
						var tmp = new AdditionalService();

						tmp.AircompanyCode = addService.AircompanyCode;
						tmp.Price = new Money(addService.Price);
						tmp.Code = addService.Code;
						tmp.Name = addService.Name;

						result.BookingClassInfo.AdditionalServices.Add(tmp);
					}
				}
			}

			if (DepAirp != null)
			{
				result.DepAirp = new AirportInformation();
				result.DepAirp.AirportCode = DepAirp.AirportCode;
				result.DepAirp.CityCode = DepAirp.CityCode;
				result.DepAirp.Terminal = DepAirp.Terminal;
				result.DepAirp.UTC = DepAirp.UTC;
			}

			if (SupplierInfo != null)
			{
				result.SupplierInfo = new SupplierSegmentInfo();
				result.SupplierInfo.Status = SupplierInfo.Status;
				result.SupplierInfo.SupplierRef = SupplierInfo.SupplierRef;
			}

			return result;
		}
	}
}