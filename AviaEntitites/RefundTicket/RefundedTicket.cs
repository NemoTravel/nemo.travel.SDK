using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.RefundTicket
{
	/// <summary>
	/// Элемент списка возвратности
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class RefundedTicket
	{
		/// <summary>
		/// Номер билета
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		[DataMember(Order = 1, Name = "PassengerRef", IsRequired = true)]
		public int TravellerRef { get; set; }

		/// <summary>
		/// Признак возможности сдачи билета
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public bool Refundable { get; set; }

		/// <summary>
		/// Возвращаемая сумма
		/// </summary>
		[DataMember(Order = 2, IsRequired = false, EmitDefaultValue = false)]
		public Money RefundMoney { get; set; }
	}
}