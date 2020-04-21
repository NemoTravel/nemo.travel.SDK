using System.Globalization;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CurrencyAmount
	{
		[DataMember(Order = 0, EmitDefaultValue = true)]
		public decimal Amount { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Currency { get; set; }


		public CurrencyAmount() { }

		public CurrencyAmount(decimal amount, string currency)
		{
			Amount = amount;
			Currency = currency;
		}


		public override string ToString()
		{
			return Amount.ToString(CultureInfo.InvariantCulture) + " " + Currency;
		}


		public static bool Equals(CurrencyAmount first, CurrencyAmount second)
		{
			if (ReferenceEquals(first, second))
			{
				return true;
			}

			if (first == null || second == null)
			{
				return false;
			}

			return first.Amount == second.Amount &&
				first.Currency == second.Currency;
		}


		protected void CopyTo(CurrencyAmount other)
		{
			other.Amount = Amount;
			other.Currency = Currency;
		}
	}
}