using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Представляет сумму к возврату для тарифов и такс
	/// </summary>
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class RefundBreakdown
	{
		/// <summary>
		/// Сумма к возврату для всех тарифов
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Money RefundFares { get; set; }

		/// <summary>
		/// Коллекция сумм к возврату для каждой таксы в отдельности
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public TaxList RefundTaxes { get; set; }


		public RefundBreakdown()
		{
		}

		public RefundBreakdown(Money refundFares, TaxList refundTaxes)
		{
			RefundFares = refundFares;
			RefundTaxes = refundTaxes;
		}
	}
}