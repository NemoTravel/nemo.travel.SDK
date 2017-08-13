using AviaEntities.SharedElements;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.GetExchangeVariants
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetExchangeVariantsRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Список пассажиров, билеты которых требуется обменять
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public RefList<int> Passengers { get; set; }

		/// <summary>
		/// Содержит техническую информацию о сегметах запрашиваемого перелёта
		/// (время вылета, прямой или с пересадками и т.д.)
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public AviaEntities.v1_2.SearchFlights.RequestElements.FlightDirection RequestedFlightInfo { get; set; }

		/// <summary>
		/// Допольнительный условия/ограничея, накладываемые на поиск перелётов
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public AviaEntities.v1_2.SearchFlights.RequestElements.AdditionalSearchInfo Restrictions { get; set; }
	}
}