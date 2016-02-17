using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание данных SSRки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class SSRDataItem
	{
		/// <summary>
		/// Код
		/// </summary>
		[DataMember(Order = 0)]
		public string Code { get; set; }

		/// <summary>
		/// Текст
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Text { get; set; }

		/// <summary>
		/// Статус
		/// </summary>
		[DataMember(Order = 2)]
		public PNRContentStatus? Status { get; set; }

		/// <summary>
		/// Код статуса
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string StatusCode { get; set; }
	}
}