using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Market.Markups
{
	/// <summary>
	/// Доход, относительное значение которого ограничено.
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class RestrictedProfit : Profit
	{
		/// <summary>
		/// Минимальное допустимое значение процента модификанты
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public double MinRelativeValue { get; set; }

		/// <summary>
		/// Максимальное допустимое значение процента модификанты
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public double MaxRelativeValue { get; set; }





		protected override void InitMaxMin()
		{
			base.InitMaxMin();
			MinRelativeValue = Double.MinValue;
			MaxRelativeValue = Double.MaxValue;
		}

		public override Modificants Normalize(Money price)
		{
			if (RelativeValue > MaxRelativeValue)
			{
				RelativeValue = MaxRelativeValue;
			}
			if (RelativeValue < MinRelativeValue)
			{
				RelativeValue = MinRelativeValue;
			}
			return base.Normalize(price);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return base.GetHashCode() + MaxRelativeValue.GetHashCode() + MinRelativeValue.GetHashCode(); 
			}
		}

		public override bool Equals(object obj)
		{
			if (!base.Equals(obj))
				return false;
			var other = obj as RestrictedProfit;
			return MinRelativeValue == other.MinRelativeValue && MaxRelativeValue == other.MaxRelativeValue;
		}




		public static RestrictedProfit operator +(RestrictedProfit a, RestrictedProfit b)
		{
			if (!a.Currency.Equals(b.Currency))
			{
				b = b.CurrencyConverter.Convert(b, a.Currency);
			}
			return new RestrictedProfit
			{
				Value = a.Value + b.Value,
				RelativeValue = a.RelativeValue + b.RelativeValue,
				Currency = a.Currency,
				CurrencyConverter = a.CurrencyConverter ?? b.CurrencyConverter,
				MaxProfit = Math.Min(a.MaxProfit, b.MaxProfit),
				MinProfit = Math.Max(a.MinProfit, b.MinProfit),
				MaxRelativeValue = Math.Min(a.MaxRelativeValue, b.MaxRelativeValue),
				MinRelativeValue = Math.Max(a.MinRelativeValue, b.MinRelativeValue)
			};
		}

		public static RestrictedProfit operator *(RestrictedProfit profit, float k)
		{
			return k * profit;
		}

		public static RestrictedProfit operator *(float k, RestrictedProfit profit)
		{
			return new RestrictedProfit
			{
				Value = profit.Value * k,
				RelativeValue = profit.RelativeValue * k,
				Currency = profit.Currency,
				CurrencyConverter = profit.CurrencyConverter,
				MaxProfit = profit.MaxProfit,
				MinProfit = profit.MinProfit,
				MaxRelativeValue = profit.MaxRelativeValue,
				MinRelativeValue = profit.MinRelativeValue
			};
		}
	}
}
