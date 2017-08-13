using AviaEntities.v1_1.FlightSearch.ResponseElements;
using AviaEntities.v1_1.GroupSearch;
using System.Runtime.Serialization;

namespace AviaEntities.GetExchangeVariants
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetExchangeVariantsRSBody
	{
		/// <summary>
		/// Выдача без группировки
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightList PlaneFlights { get; set; }

		/// <summary>
		/// Простая группировка
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public GroupedFlightResultBody SimpleGroupedFlights { get; set; }
	}
}