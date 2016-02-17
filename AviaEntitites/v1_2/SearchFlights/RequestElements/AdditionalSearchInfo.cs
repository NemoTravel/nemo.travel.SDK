using AviaEntities.FlightSearch.RequestElements;
using GeneralEntities;
using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	/// <summary>
	/// Содержит допольнительные условия и ограничения для поиска перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AdditionalSearchInfo_1_2")]
	public class AdditionalSearchInfo
	{
		/// <summary>
		/// Код валюты, в которой должны вернуться цены результатов поиска
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Фильтрация по авиакомпаниями
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public List<Company> CompanyFilter { get; set; }

		/// <summary>
		/// Искать только перелёты с приватными тарифами
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool PrivateFaresOnly { get; set; }

		/// <summary>
		/// Предпочитаемый класс перелёта
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public ClassPrefList ClassPreference { get; set; }

		/// <summary>
		/// Максимальное время стыковки в минутах
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public int? MaxConnectionTime { get; set; }

		/// <summary>
		/// Формат группировки поисковой выдачи
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public SearchResultsGroupType ResultsGrouping { get; set; }

		/// <summary>
		/// Список источников, в которых требуется запускать поиск перелётов
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public SourcePreferenceList SourcePreference { get; set; }

		/// <summary>
		/// Информация об ициниализаторе поиска в системе, приславшей запрос
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		/// <summary>
		/// Максимальное количество перелётов в ответе ГДС
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public int? MaxResultCount { get; set; }
	}
}
