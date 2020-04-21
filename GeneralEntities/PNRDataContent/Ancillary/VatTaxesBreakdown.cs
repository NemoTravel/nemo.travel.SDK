using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class VatTaxesBreakdown : CurrencyAmount
	{
		[DataMember(Order = 0, EmitDefaultValue = false, Name = "Breakdown")]
		public VatTaxList TaxList { get; set; }


		public VatTaxesBreakdown() { }

		public VatTaxesBreakdown(decimal amount, string currency, IReadOnlyCollection<VatTax> taxes)
			: base(amount, currency)
		{
			if (taxes != null && taxes.Count > 0)
			{
				TaxList = new VatTaxList(taxes.Count);
				TaxList.AddRange(taxes.Select(t => t.Copy()));
			}
		}


		public VatTaxesBreakdown Copy()
		{
			var other = new VatTaxesBreakdown();

			base.CopyTo(other);

			if (TaxList != null && TaxList.Count > 0)
			{
				other.TaxList = new VatTaxList(TaxList.Count);
				other.TaxList.AddRange(TaxList.Select(v => v.Copy()));
			}

			return other;
		}
	}
}