using GeneralEntities.Shared;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Базовая информация о сегменте перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class AirItinerary : ItemIdentification<long>
	{
		/// <summary>
		/// Аэропорт отправления
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public AirportInformation DepAirp { get; set; }

		/// <summary>
		/// Аэропорт прибытия
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public AirportInformation ArrAirp { get; set; }

		/// <summary>
		/// Число остановок
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public int StopNum { get; set; }

		/// <summary>
		/// Индикатор возможности выписки электронного билета
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public bool ETicket { get; set; }

		/// <summary>
		/// Дефолтный конструктор без параметров
		/// </summary>
		public AirItinerary()
		{
			DepAirp = new AirportInformation();
			ArrAirp = new AirportInformation();
		}
	}
}