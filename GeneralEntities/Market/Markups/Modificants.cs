using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GeneralEntities.Market.Markups
{
	[KnownType(typeof(SubagentCommission))]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Modificants : ICurrencyDepended
	{
		/// <summary>
		/// Абсолютное значение модификанты, например "+ 100 рублей"
		/// </summary>
		[DataMember(Order = 0, Name = "AbsoluteValue")]
		public double Value { get; set; }

		/// <summary>
		/// Относительное значение модификанты (в процентах)
		/// </summary>
		[DataMember(Order = 1)]
		public double RelativeValue { get; set; } //Double на 64-х битных архитектурах работает чуточку быстрее, что критичнее чем экономия памяти

		/// <summary>
		/// Валюта
		/// </summary>
		[DataMember(Order = 2)]
		public string Currency { get; set; }


		/// <summary>
		/// Объект для конвертирования валют
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		public ICurrencyConverter CurrencyConverter { get; set; }

		public static readonly Modificants MAX_VALUE, MIN_VALUE;

		static Modificants()
		{
			MAX_VALUE = new Modificants { Value = Double.MaxValue, RelativeValue = Double.MaxValue };
			MIN_VALUE = new Modificants { Value = Double.MinValue, RelativeValue = Double.MinValue };
		}


		/// <summary>
		/// Считает значение, на которое измениться цена при текущих значениях модификанты.
		/// </summary>
		/// <param name="price"></param>
		/// <returns></returns>
		public virtual Money Calc(Money price)
		{
			var result = new Money 
			{
				Value = price.Value * RelativeValue / 100 + Value,
				Currency = price.Currency,
				CurrencyConverter = price.CurrencyConverter ?? CurrencyConverter
			};
			if (Currency != null && result.Currency != Currency)
				result = (CurrencyConverter ?? result.CurrencyConverter).Convert(result, Currency);
			return result;
		}


        public static Modificants operator +(Modificants a, Modificants b)
        {
            if (!a.Currency.Equals(b.Currency))
            {
				b = b.ConvertToCurrency(a.Currency);
            }
            return new Modificants
            {
                Value = a.Value + b.Value,
                RelativeValue = a.RelativeValue + b.RelativeValue,
				Currency = a.Currency,
				CurrencyConverter = a.CurrencyConverter ?? b.CurrencyConverter
            };
        }

		public static Modificants operator -(Modificants a, Modificants b)
		{
			if (!a.Currency.Equals(b.Currency))
			{
				b = b.ConvertToCurrency(a.Currency);
			}
			return new Modificants
			{
				Value = a.Value - b.Value,
				RelativeValue = a.RelativeValue - b.RelativeValue,
				Currency = a.Currency,
				CurrencyConverter = a.CurrencyConverter ?? b.CurrencyConverter
			};
		}

		public static Modificants operator *(double k, Modificants m)
		{
			return new Modificants
			{
				Value = k * m.Value,
				RelativeValue = k * m.RelativeValue,
				Currency = m.Currency,
				CurrencyConverter = m.CurrencyConverter
			};
		}

		/// <summary>
		/// Конвертирует валюту текущего экземпляра к заданной.
		/// </summary>
		/// <param name="targetCurrency"></param>
		/// <returns></returns>
		public Modificants ConvertToCurrency(string targetCurrency)
		{
			if (CurrencyConverter == null)
				throw new NullReferenceException("Для текущей модификанты не указан конвертер валют.");
			return CurrencyConverter.Convert(this, targetCurrency);
		}

        public override bool Equals(object obj)
        {
            var other = obj as Modificants;
            if (other == null) return false;

            return  Value == other.Value &&
                    RelativeValue == other.RelativeValue &&
                    Currency == other.Currency &&
					(CurrencyConverter == null || CurrencyConverter.Equals(other.CurrencyConverter));
        }

		public override int GetHashCode()
		{
			unchecked
			{
				return Value.GetHashCode() +
						   RelativeValue.GetHashCode() +
						   (Currency != null ? Currency.GetHashCode() : 0) +
						   (CurrencyConverter != null ? CurrencyConverter.GetHashCode() : 0); 
			}
		}
	}
}