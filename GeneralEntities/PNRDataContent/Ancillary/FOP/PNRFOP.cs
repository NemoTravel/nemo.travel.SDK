using GeneralEntities.Market;
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

		/// <summary>
		/// Возвращает или задает код типа карты.
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string VendorCode { get; set; }

		/// <summary>
		/// Возвращает или задает дату истечения карты.
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string ExpireDate { get; set; }

		/// <summary>
		/// Возвращает или задает код авторизации.
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string AuthorizationCode { get; set; }

		/// <summary>
		/// Возвращает или задает сумму оплаты.
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public Money Amount { get; set; }

		/// <summary>
		/// Ссылка для подтверждения оплаты пользователем
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string PaymentConfirmationLink { get; set; }

		public PNRFOP Copy()
		{
			var result = new PNRFOP();

			result.Type = Type;
			result.CreditCardNumber = CreditCardNumber;
			result.Number = Number;
			result.VendorCode = VendorCode;
			result.ExpireDate = ExpireDate;
			result.AuthorizationCode = AuthorizationCode;
			result.Amount = Amount?.Copy();
			result.PaymentConfirmationLink = PaymentConfirmationLink;

			return result;
		}
	}
}