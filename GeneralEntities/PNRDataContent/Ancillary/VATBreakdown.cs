using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class VATBreakdown
	{
		/// <summary>
		/// НДС с тарифа
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public Money Tariff { get; set; }

		/// <summary>
		/// НДС с такс
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public Money Taxes { get; set; }

		/// <summary>
		/// Полное значение НДС
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Money Total { get; set; }
	}
}
