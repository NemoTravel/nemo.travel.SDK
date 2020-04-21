using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class VatTax : PercentCurrencyAmount
	{
		[DataMember(Order = 0, EmitDefaultValue = false, Name = "Code")]
		public string TaxCode { get; set; }


		public VatTax() { }

		public VatTax(decimal amount, string currency, double? percent, string taxCode)
			: base(amount, currency, percent)
		{
			TaxCode = taxCode;
		}


		public VatTax Copy()
		{
			var other = new VatTax();

			base.CopyTo(other);

			other.TaxCode = TaxCode;

			return other;
		}


		public static bool Equals(VatTax first, VatTax second)
		{
			return PercentCurrencyAmount.Equals(first, second) &&
				first.TaxCode == second.TaxCode;
		}
	}
}