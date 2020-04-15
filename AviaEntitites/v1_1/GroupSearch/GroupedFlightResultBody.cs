using AviaEntities.v1_1.GroupSearch.ResponseElements;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch
{
	/// <summary>
	/// Результаты поиска в сгруппированном виде
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "GroupedFlightResultBody_1_1")]
	public class GroupedFlightResultBody
	{
		/// <summary>
		/// Все сегменты в результатах поисках, из которых будут комбинироваться перелёты
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public AirItineraryList AirItineraries { get; set; }

		/// <summary>
		/// Цены, которые будут использоваться для формирования перелётов
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public GroupedPriceList Prices { get; set; }

		/// <summary>
		/// Содержит информацию, специфичную для каждого отдельного уникального сегмента перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public FlightSegmentList FlightSegments { get; set; }

		/// <summary>
		/// Связь перелётов (набор сегментов перелёта) с ценами
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public FlightPriceGroupList FlightPriceGroups { get; set; }

		/// <summary>
		/// Допустимые по дефолту комбинации плечей мультиOW
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public List<FlightLegCrossCombination> FlightLegCrossCombinations { get; set; }

		[DataMember(Order = 7)]
		public bool ResultsFiltersApplied { get; set; }

		/// <summary>
		/// Создание нового объекта класса с дефолтной инициализацией необходимых параметров
		/// </summary>
		public GroupedFlightResultBody()
		{
			FlightPriceGroups = new FlightPriceGroupList();
			Prices = new GroupedPriceList();
			FlightSegments = new FlightSegmentList();
			AirItineraries = new AirItineraryList();
		}
	}
}
