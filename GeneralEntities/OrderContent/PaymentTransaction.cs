using GeneralEntities.Market;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	/// <summary>
	/// Содержит описание информации о транзакции оплаты в заказе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PaymentTransaction : ItemIdentification<long>
	{
		/// <summary>
		/// Статус транзакции
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PaymentTransactionStatus Status { get; set; }

		/// <summary>
		/// Сумма, оплачиваемая данной транзакцией
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public Money Amount { get; set; }

		/// <summary>
		/// Список возможных действий с данной транзакцией
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public PaymentTransactionActionList PossibleActions { get; set; }
	}
}
