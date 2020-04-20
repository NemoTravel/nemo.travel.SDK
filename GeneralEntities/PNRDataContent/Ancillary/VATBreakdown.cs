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
		public VatTariffBreakdown Tariff { get; set; }

		/// <summary>
		/// НДС с такс
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false, Name = "Taxes")]
		public VatTaxesBreakdown TaxesBreakdown { get; set; }

		/// <summary>
		/// Полное значение НДС
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public Money Total { get; set; }


		public VATBreakdown Copy()
		{
			var result = new VATBreakdown();
			result.Tariff = Tariff?.Copy();
			result.TaxesBreakdown = TaxesBreakdown?.Copy();
			result.Total = Total?.Copy();

			return result;
		}


		public static bool CompareWithoutTaxBreakdown(VATBreakdown first, VATBreakdown second)
		{
			if (ReferenceEquals(first, second))
			{
				return true;
			}

			if (first == null || second == null)
			{
				return false;
			}

			return PercentCurrencyAmount.Equals(first.Tariff, second.Tariff) &&
				CurrencyAmount.Equals(first.TaxesBreakdown, second.TaxesBreakdown) &&
				first.Total == second.Total;
		}
	}
}