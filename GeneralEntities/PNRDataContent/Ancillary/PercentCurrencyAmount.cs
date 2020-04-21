using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PercentCurrencyAmount : CurrencyAmount
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public double? Percent { get; set; }


		public PercentCurrencyAmount() { }

		public PercentCurrencyAmount(decimal amount, string currency, double? percent)
			: base(amount, currency)
		{
			Percent = percent;
		}


		public static bool Equals(PercentCurrencyAmount first, PercentCurrencyAmount second)
		{
			if (ReferenceEquals(first, second))
			{
				return true;
			}

			if (first == null || second == null)
			{
				return false;
			}

			return CurrencyAmount.Equals(first, second) &&
				first.Percent.HasValue && second.Percent.HasValue &&
				Math.Abs(first.Percent.Value - second.Percent.Value) <= 0.001D;
		}


		protected void CopyTo(PercentCurrencyAmount other)
		{
			base.CopyTo(other);

			other.Percent = Percent;
		}
	}
}