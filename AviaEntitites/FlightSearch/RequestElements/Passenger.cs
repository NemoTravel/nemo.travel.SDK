using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Содержит информацию о пассажирах, для которых выполняется поиск перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Passenger
	{
		/// <summary>
		/// Тип пассажира(-ов)
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public PassTypes Type { get; set; }

		/// <summary>
		/// Количество пассажиров данного типа
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int Count { get; set; }
	}
}