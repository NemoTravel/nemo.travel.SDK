using System.Runtime.Serialization;

namespace AviaEntities.GetBookHistory
{
	/// <summary>
	/// Элемент истории брони (по сути ревизия ПНРа)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookHistoryElement
	{
		/// <summary>
		/// Дата и время изменения в брони
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string DateTime { get; set; }

		/// <summary>
		/// Источник изменения
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string ChangeSource { get; set; }

		/// <summary>
		/// Изменения в рамках данной ревизии ПНРа
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public BookHistoryInfo HistoryRemarks { get; set; }


		public BookHistoryElement()
		{
			HistoryRemarks = new BookHistoryInfo();
		}
	}
}