using AviaEntities.FlightSearch.ResponseElements;
using AviaEntities.GroupSearch.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch
{
	/// <summary>
	/// Результаты поиска в сгруппированном виде
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GroupedFlightResultBody
	{
		/// <summary>
		/// Все сегменты в результатах поисках, из которых будут комбинироваться перелёты
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public List<AirItinerary> AirItineraries { get; set; }

		/// <summary>
		/// Цены, которые будут использоваться для формирования перелётов
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public List<GroupedPrice> Prices { get; set; }

		/// <summary>
		/// Содержит информацию, специфичную для каждого отдельного уникального сегмента перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public List<FlightSegment> FlightSegments { get; set; }

		/// <summary>
		/// Связь перелётов (набор сегментов перелёта) с ценами
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public List<FlightPriceGroup> FlightPriceGroups { get; set; }

		/// <summary>
		/// Допустимые по дефолту комбинации плечей мультиOW
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public List<FlightLegCrossCombination> FlightLegCrossCombinations { get; set; }

		/// <summary>
		/// Создание нового объекта класса с дефолтной инициализацией необходимых параметров
		/// </summary>
		public GroupedFlightResultBody()
		{
			FlightPriceGroups = new List<FlightPriceGroup>();
			Prices = new List<GroupedPrice>();
			FlightSegments = new List<FlightSegment>();
			AirItineraries = new List<AirItinerary>();
		}
	}
}