using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит данные, необходимые для корректного проксирования выписки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TicketingProxyDataItem
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

		public TicketingProxyDataItem Copy()
		{
			var result = new TicketingProxyDataItem();

			result.Gateway = Gateway;
			result.ProxingParams = ProxingParams;

			return result;
		}
	}
}