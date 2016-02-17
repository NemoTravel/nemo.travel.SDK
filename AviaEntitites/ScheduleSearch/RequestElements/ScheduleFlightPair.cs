using AviaEntities.v1_2.SearchFlights.RequestElements;
using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.ScheduleSearch.RequestElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ScheduleFlightPair")]
	public class ScheduleFlightPair : v1_2.SearchFlights.RequestElements.FlightPair
	{
		/// <summary>
		/// Дата и время конца периода отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 0, IsRequired = false)]
		public DateTimeEx DepatureDateTime2 { get; set; }

		public new ScheduleFlightPair FullCopy()
		{
			var result = new ScheduleFlightPair();
			result.ArrivalPoint = new RequestedTripPoint();
			result.DepaturePoint = new RequestedTripPoint();

			result.DepatureDateTime = DepatureDateTime;
			result.MaxDepatureTime = MaxDepatureTime;

			result.DepatureDateTime2 = DepatureDateTime2;

			result.ArrivalPoint.Code = ArrivalPoint.Code;
			result.ArrivalPoint.IsCity = ArrivalPoint.IsCity;

			result.DepaturePoint.Code = DepaturePoint.Code;
			result.DepaturePoint.IsCity = DepaturePoint.IsCity;
			
			return result;
		}
	}
}
