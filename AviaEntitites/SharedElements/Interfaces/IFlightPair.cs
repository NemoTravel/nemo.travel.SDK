using AviaEntities.v1_2.SearchFlights.RequestElements;

namespace AviaEntities.SharedElements.Interfaces
{
	public interface IFlightPair
	{
		RequestedTripPoint DeparturePoint { get; }

		RequestedTripPoint ArrivalPoint { get; }
	}
}
