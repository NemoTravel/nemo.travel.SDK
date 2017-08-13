using System.Runtime.Serialization;

namespace AviaEntities.GetRoutingGrid
{
	/// <summary>
	/// Ответ на запрос получения маршрутной сетки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetRoutingGridRSBody
	{
		/// <summary>
		/// Маршрутная сетка
		/// </summary>
		[DataMember]
		public RoutingGrid RoutingGrid { get; set; }
	}
}
