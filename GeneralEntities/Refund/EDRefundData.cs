using GeneralEntities.Market;
using GeneralEntities.PriceContent;
using System.Runtime.Serialization;

namespace GeneralEntities.Refund
{
	/// <summary>
	/// Информация о возврате ЭД (электронного документа)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class EDRefundData
	{
		/// <summary>
		/// Номер электронного документа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string EDNumber { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public EDType EDType { get; set; }

		[DataMember(Order = 2, IsRequired = true)]
		public int TravellerRef { get; set; }

		/// <summary>
		/// Признак возможности сдачи ЭД
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public bool Refundable { get; set; }

		/// <summary>
		/// Общая сумма возврата
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Money RefundMoney { get; set; }

		/// <summary>
		/// Сумма к возврату для тарифов и такс
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public RefundBreakdown RefundBreakdown { get; set; }


		public EDRefundData()
		{
		}

		public EDRefundData(string number, int travellerRef, bool refundable, EDType type, Money money = null, RefundBreakdown refundBreakdown = null)
		{
			EDType = type;
			EDNumber = number;
			RefundMoney = money;
			Refundable = refundable;
			TravellerRef = travellerRef;
			RefundBreakdown = refundBreakdown;
		}
	}
}