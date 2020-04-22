using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class VatTariffBreakdown : PercentCurrencyAmount
	{
		[DataMember(Order = 0)]
		public VatTariffList Breakdown { get; set; }


		public VatTariffBreakdown() { }

		public VatTariffBreakdown(decimal amount, string currency, double? percent, IReadOnlyCollection<VatTariff> tariffVatBreakdown) : base(amount, currency, percent)
		{
			if (tariffVatBreakdown != null)
			{
				Breakdown = new VatTariffList(tariffVatBreakdown);
			}
		}


		public VatTariffBreakdown Copy()
		{
			var other = new VatTariffBreakdown();

			base.CopyTo(other);

			if (Breakdown != null)
			{
				other.Breakdown = new VatTariffList(Breakdown.Count);
				other.Breakdown.AddRange(Breakdown.Select(t => t.Copy()));
			}

			return other;
		}
	}
}