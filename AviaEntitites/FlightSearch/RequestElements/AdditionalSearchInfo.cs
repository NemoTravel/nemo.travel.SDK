using GeneralEntities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Содержит допольнительные условия и ограничения для поиска перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
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
		public ClassType ClassPref { get; set; }

		/// <summary>
		/// Список типов поиска, с помощью которых требуется выполнять поиска перелётов
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public SourcePreferenceList SourcePreference { get; set; }
	}
}