using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	/// <summary>
	/// Список правил маршрутизации
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo.travel/Avia", ItemName = "RouterRule")]
	public class RouterRulesList : List<RouterRule>
	{
	}
}
