using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch
{
	/// <summary>
	/// Содержит результат поиска перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightSearchRSBody_1_1")]
	public class FlightSearchRSBody
	{
		/// <summary>
		/// Перелёты
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, EmitDefaultValue = false)]
		public FlightList Flights { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public FlightSearchRSBody()
		{
			Flights = new FlightList();
		}
	}
}