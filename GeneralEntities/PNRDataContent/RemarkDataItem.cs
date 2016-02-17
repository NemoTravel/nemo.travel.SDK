using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание некой ремарки в ПНРе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class RemarkDataItem
	{
		/// <summary>
		/// Тип ремарки
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PNRRemarkType Type { get; set; }

		/// <summary>
		/// Текст ремарки
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Text { get; set; }
	}
}