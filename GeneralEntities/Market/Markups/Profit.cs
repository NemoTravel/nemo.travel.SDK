using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Market.Markups
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Profit : Modificants, IProfit
	{
		/// <summary>
		/// Максимально возможный доход
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public double MaxProfit { get; set; }

		/// <summary>
		/// Минимально допустимый доход
		/// </summary>
		[DataMember(EmitDefaultValue = false)]
		public double MinProfit { get; set; }

		public Profit()
		{
			InitMaxMin();
		}

		/// <summary>
		/// Возврашает модификанту, входяшую в ограничения
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>
		public virtual Modificants Normalize(Money price)
		{
			var result = new Modificants
			{
				Value = this.Value,
				RelativeValue = this.RelativeValue,
				Currency = this.Currency ?? price.Currency,
				CurrencyConverter = this.CurrencyConverter ?? price.CurrencyConverter
			};

			if (result.Currency != price.Currency)
				price = result.CurrencyConverter.Convert(price, result.Currency);

			double currentProfit = base.Calc(price).Value;
			if (currentProfit < MinProfit)
			{
				result.Value += MinProfit - currentProfit;
			}
			if (currentProfit > MaxProfit)
			{
				result.Value -= currentProfit - MaxProfit;
			}
			
			return result;
		}

		/// <summary>
		/// Нужно т.к. при десериализации конструктор не вызывается
		/// </summary>
		/// <param name="context"></param>
		[OnDeserializing]
		public void OnDeserializing(StreamingContext context)
		{
			InitMaxMin();
		}

		protected virtual void InitMaxMin()
		{
			MaxProfit = Double.MaxValue;
			MinProfit = Double.MinValue;
		}

		public new Profit ConvertToCurrency(string targetCurrency)
		{
			if (CurrencyConverter == null)
				throw new NullReferenceException("Для текущего объекта денег не указан конвертер валют.");
			return CurrencyConverter.Convert(this, targetCurrency);
		}

		public static Profit operator +(Profit a, Profit b)
		{
			if (!a.Currency.Equals(b.Currency))
			{
				b = b.ConvertToCurrency(a.Currency);
			}
			return new Profit
			{
				Value = a.Value + b.Value,
				RelativeValue = a.RelativeValue + b.RelativeValue,
				Currency = a.Currency,
				CurrencyConverter = a.CurrencyConverter ?? b.CurrencyConverter,
				MaxProfit = Math.Min(a.MaxProfit, b.MaxProfit),
				MinProfit = Math.Max(a.MinProfit, b.MinProfit)
			};
		}

		public static Profit operator *(Profit profit, float k )
		{
			return k * profit;
		}

		public static Profit operator *(float k, Profit profit)
		{
			return new Profit
			{
				Value = profit.Value * k,
				RelativeValue = profit.RelativeValue * k,
				Currency = profit.Currency,
				CurrencyConverter = profit.CurrencyConverter,
				MaxProfit = profit.MaxProfit,
				MinProfit = profit.MinProfit
			};
		}



		public override bool Equals(object obj)
		{
			var other = obj as Profit;
			if (other == null) return false;

			return base.Equals(obj) && MaxProfit == other.MaxProfit && MinProfit == other.MinProfit;
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return base.GetHashCode() + MaxProfit.GetHashCode() + MinProfit.GetHashCode(); 
			}
		}
	}
}