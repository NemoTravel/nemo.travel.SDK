using GeneralEntities.ExtendedDateTime;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	/// <summary>
	/// Содержит информацию о запрашиваемом сегменте перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPair_1_2")]
	public class FlightPair
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
		[DataMember(Order = 2, IsRequired = true)]
		public RequestedTripPoint DepaturePoint { get; set; }

		/// <summary>
		/// Код аэропорта (города) прибытия
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public RequestedTripPoint ArrivalPoint { get; set; }

		/// <summary>
		/// Идентификатор элемента.
		/// </summary>
		[DataMember(Order = 4, IsRequired = false)]
		public int? ID { get; set; }

		/// <summary>
		/// Выполняет полное копирование текущего объекта
		/// </summary>
		/// <returns>Результат копирования, приведённый к типу данного класса</returns>
		public FlightPair FullCopy()
		{
			var result = new FlightPair();
			result.ArrivalPoint = new RequestedTripPoint();
			result.DepaturePoint = new RequestedTripPoint();

			result.DepatureDateTime = DepatureDateTime;
			result.MaxDepatureTime = MaxDepatureTime;

			result.ArrivalPoint.Code = ArrivalPoint.Code;
			result.ArrivalPoint.IsCity = ArrivalPoint.IsCity;

			result.DepaturePoint.Code = DepaturePoint.Code;
			result.DepaturePoint.IsCity = DepaturePoint.IsCity;


			return result;
		}
	}
}