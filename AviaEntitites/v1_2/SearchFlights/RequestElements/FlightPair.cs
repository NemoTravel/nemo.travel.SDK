using AviaEntities.SharedElements.Interfaces;
using GeneralEntities.ExtendedDateTime;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	/// <summary>
	/// Содержит информацию о запрашиваемом сегменте перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPair_1_2")]
	public class FlightPair : IFlightPair
	{
		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public DateTimeEx DepatureDateTime { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false, Name = "MaxDepatureTime")]
		public string DC_MaxDepatureTime
		{
			get
			{
				return MaxDepatureTime.HasValue ? MaxDepatureTime.ToString() : null;
			}
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					MaxDepatureTime = TimeSpan.Parse(value, null);
				}
			}
		}

		/// <summary>
		/// Верхняя граница допустимого диапазона времени вылета, нижняя задаётся в DepDate
		/// </summary>
		[IgnoreDataMember]
		public TimeSpan? MaxDepatureTime { get; set; }

		/// <summary>
		/// Код аэропорта (города) отправления
		/// </summary>
		[DataMember(Order = 2, Name = "DepaturePoint", IsRequired = true)]
		public RequestedTripPoint DeparturePoint { get; set; }

		/// <summary>
		/// Дополнительный код аэропорта (города) отправления
		/// </summary>
		[DataMember(Order = 3, IsRequired = false)]
		public RequestedTripPointList DepatureAltPoints { get; set; }

		/// <summary>
		/// Код аэропорта (города) прибытия
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public RequestedTripPoint ArrivalPoint { get; set; }

		/// <summary>
		/// Дополнительный код аэропорта (города) прибытия
		/// </summary>
		[DataMember(Order = 5, IsRequired = false)]
		public RequestedTripPointList ArrivalAltPoints { get; set; }

		/// <summary>
		/// Идентификатор элемента.
		/// </summary>
		[DataMember(Order = 6, IsRequired = false)]
		public int? ID { get; set; }

		/// <summary>
		/// Выполняет полное копирование текущего объекта
		/// </summary>
		/// <returns>Результат копирования, приведённый к типу данного класса</returns>
		public FlightPair FullCopy()
		{
			var result = new FlightPair();
			result.ArrivalPoint = new RequestedTripPoint();
			result.DeparturePoint = new RequestedTripPoint();

			result.DepatureDateTime = DepatureDateTime;
			result.MaxDepatureTime = MaxDepatureTime;

			result.ArrivalPoint.Code = ArrivalPoint.Code;
			result.ArrivalPoint.IsCity = ArrivalPoint.IsCity;

			if (ArrivalAltPoints != null)
			{
				result.ArrivalAltPoints = new RequestedTripPointList();
				foreach (var point in ArrivalAltPoints)
				{
					result.ArrivalAltPoints.Add(point.FullCopy());
				}
			}

			result.DeparturePoint.Code = DeparturePoint.Code;
			result.DeparturePoint.IsCity = DeparturePoint.IsCity;

			if (DepatureAltPoints != null)
			{
				result.DepatureAltPoints = new RequestedTripPointList();
				foreach (var point in DepatureAltPoints)
				{
					result.DepatureAltPoints.Add(point.FullCopy());
				}
			}

			return result;
		}
	}
}