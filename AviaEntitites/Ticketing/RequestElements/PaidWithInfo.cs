using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.Ticketing.RequestElements
{
	/// <summary>
	/// Содержит описание информации о способе оплаты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class PaidWithInfo
	{
		/// <summary>
		/// ПШ, с помощью которого было оплачено
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PaymentGateway Gateway { get; set; }

		/// <summary>
		/// Дополнительные параметры для проксирования запроса выписки
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string ProxingParams { get; set; }
	}
}