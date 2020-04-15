using GeneralEntities;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SearchContext
	{
		/// <summary>
		/// Информация об ициниализаторе поиска в системе, приславшей запрос
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		/// <summary>
		/// Формат группировки поисковой выдачи
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public SearchResultsGroupType ResultsGrouping { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? RefererID { get; set; }
	}
}