using System.Runtime.Serialization;

namespace AviaEntities.GetSearchResults
{
	/// <summary>
	/// Содержит описание тела запроса на получение результатов определённого поиска
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSearchResultsRQBody
	{
		/// <summary>
		/// ИД поиска, чьи результаты требуется получить
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public long? SearchID { get; set; }

		/// <summary>
		/// ИД конкретного перелёта, который требуется получить
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string FlightID { get; set; }

		/// <summary>
		/// Вернуть контент общения с поставщиком
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool RawData { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool ReturnPropagationLog { get; set; }

		/// <summary>
		/// Содержит параметры, необходимые для корректной обработки запрошенных результатов
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public SearchContext SearchContext { get; set; }
	}
}