using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Содержит информацию о фильтрации по авиакомпании
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Company
	{
		/// <summary>
		/// Код авиакомпании, по которой будет проводиться фильтрация
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Code { get; set; }

		/// <summary>
		/// Тип фильтрации (включать перелёты данной а/к в результаты или нет)
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public bool Include { get; set; }

		/// <summary>
		/// Номер сегмента в запросе, к которому относится данное требование а/к
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? SegmentNumber { get; set; }
	}
}