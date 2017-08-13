using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// Содержит описание ФОПа из ПНРа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PNRFOP
	{
		/// <summary>
		/// Тип ФОПа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public FOPType Type { get; set; }

		/// <summary>
		/// Замаскированный номер кредитной карты из ПНРа
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string CreditCardNumber { get; set; }

		/// <summary>
		/// Номер ФОПа в ПНРе
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Number { get; set; }
	}
}