using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// ФОП с кредитной картой
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CreditCardFOP : BaseFOP
	{
		/// <summary>
		/// Код типа карты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string VendorCode { get; set; }

		/// <summary>
		/// Номер карты
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Дата истечения карты
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string ExpireDate { get; set; }

		/// <summary>
		/// Код транзакции
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string ManualApprovalCode { get; set; }
	}
}