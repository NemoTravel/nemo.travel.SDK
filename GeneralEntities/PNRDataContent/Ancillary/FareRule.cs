using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	/// <summary>
	/// Тарифное правило
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FareRule
	{
		/// <summary>
		/// Код правила
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		/// Код тарифа
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Tarrif { get; set; }

		/// <summary>
		/// Название правила
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Name { get; set; }

		/// <summary>
		/// Признак что текст правила является УРЛ ссылкой на текст где-то на внешнем сайте
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool IsURL { get; set; }

		/// <summary>
		/// Текст правила
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string RuleText { get; set; }
	}
}