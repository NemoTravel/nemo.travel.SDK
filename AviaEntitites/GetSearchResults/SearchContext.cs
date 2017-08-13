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
	}
}