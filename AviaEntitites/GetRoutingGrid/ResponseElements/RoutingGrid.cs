using GeneralEntities.Services;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetRoutingGrid
{
	/// <summary>
	/// Маршрутная сетка
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Routes", KeyName = "Departure", ValueName = "Arrival")]
	public class RoutingGrid : Dictionary<TripPointInformation, HashSet<Route>>
	{
	}
}
