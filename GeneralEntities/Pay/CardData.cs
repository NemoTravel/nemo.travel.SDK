using System.Runtime.Serialization;

namespace GeneralEntities.Pay
{
	/// <summary>
	/// Данные банковской карты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Payment")]
	public class CardData
	{
		/// <summary>
		/// Номер карты
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Number { get; set; }

		/// <summary>
		/// Владелец карты
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string Holder { get; set; }

		/// <summary>
		/// CVC/CVV код
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public string Code { get; set; }

		/// <summary>
		/// Месяц, до которого действительна карта (MM)
		/// </summary>
		[DataMember(IsRequired = true, Order = 4)]
		public string Month { get; set; }

		/// <summary>
		/// Год, до которого действительна карта (YYYY)
		/// </summary>
		[DataMember(IsRequired = true, Order = 5)]
		public string Year { get; set; }
	}
}
