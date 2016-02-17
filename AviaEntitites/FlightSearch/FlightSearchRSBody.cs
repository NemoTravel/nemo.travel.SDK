using System.Collections.Generic;
using System.Runtime.Serialization;
using AviaEntities.FlightSearch.ResponseElements;

namespace AviaEntities.FlightSearch
{
	/// <summary>
	/// Содержит результат поиска перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightSearchRSBody
	{
		//TODO рассмотреть вопрос с инициализацией списков и полей в конструкторе соответствующих классов
		/// <summary>
		/// Перелёты
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, EmitDefaultValue = false)]
		public List<Flight> Flights { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public FlightSearchRSBody()
		{
			Flights = new List<Flight>();
		}
	}
}