using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Pay
{
	/// <summary>
	/// Данные для подтверждения оплаты через 3-D Secure
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Payment")]
	public class ThreeDSecureConfirmationData
	{
		/// <summary>
		/// Ссылка, на которую клиент должен сделать запрос
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string ActionUrl { get; set; }

		/// <summary>
		/// Метод запроса, по умолчанию - POST
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string Method { get; set; } = "POST";

		/// <summary>
		/// Параметры для подтверждения оплаты
		/// </summary>
		[DataMember(IsRequired = false, Order = 3)]
		public List<ConfirmationParameter> ConfirmationParameters { get; set; }
	}

	[DataContract(Namespace = "http://nemo-ibe.com/Payment")]
	public class ConfirmationParameter
	{
		[DataMember(IsRequired = true)]
		public string ParName { get; set; }

		[DataMember(IsRequired = true)]
		public string ParValue { get; set; }
	}
}
