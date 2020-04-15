using System;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GeneralEntities.Market
{
	/// <summary>
	/// Содержит описание определённой суммы денег
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Money : ICurrencyDepended, IComparable<Money>
	{
		private const double PRECISION = 0.0001;

		private static Regex regex = new Regex(@"(-?\d+(?:\.\d+)*)(?: ?(\w+))*", RegexOptions.Compiled);


		/// <summary>
		/// Сумма денег
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, Name = "Amount")]
		public string DC_Value
		{
			get { return Value.ToString(CultureInfo.InvariantCulture); }
			set
			{
				if (value != null)
				{
					Value = double.Parse(value, CultureInfo.InvariantCulture);
				}
			}
		}

		[XmlIgnore]
		[IgnoreDataMember]
		public double Value { get; set; }

		/// <summary>
		/// ISO Alpha 3 код валюты
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Currency { get; set; }

		/// <summary>
		/// Объект для конвертирования валют
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		public ICurrencyConverter CurrencyConverter { get; set; }


		public Money()
		{
		}

		/// <summary>
		/// Создаёт новый объект денег
		/// </summary>
		/// <param name="amount">Сумма денег</param>
		/// <param name="currency">Код валюты</param>
		/// <param name="currencyConverter">Объект для осуществления конвертации валют</param>
		public Money(double amount, string currency, ICurrencyConverter currencyConverter = null)
		{
			Value = amount;
			Currency = currency;
			CurrencyConverter = currencyConverter;
		}

		public Money(Money other)
		{
			Value = other.Value;
			Currency = other.Currency;
			CurrencyConverter = other.CurrencyConverter;
		}


		/// <summary>
		/// Создаёт объект денег из информации переданной в строке
		/// </summary>
		/// <param name="input">строке в формате "{AMOUNT(Double, '.' - десятичный разделитель)}[ {CURRENCY}]"</param>
		/// <returns></returns>
		public static Money Parse(string input)
		{
			var match = regex.Match(input);
			if (!match.Success)
			{
				throw new ArgumentException("Переданная строка имеет неверный формат.");
			}

			return new Money(Double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture), match.Groups[2].Success ? match.Groups[2].Value : null);
		}

		/// <summary>
		/// Проверка на нулевое значение суммы
		/// </summary>
		/// <returns></returns>
		public bool IsZeroAmount() => Math.Abs(Value) < PRECISION;


		#region Math

		public static Money operator +(Money a, Money b)
		{
			CorrectCurrency(a, ref b);
			return new Money(a.Value + b.Value, a.Currency, a.CurrencyConverter ?? b.CurrencyConverter);
		}

		public static Money operator -(Money a, Money b)
		{
			CorrectCurrency(a, ref b);
			return new Money(a.Value - b.Value, a.Currency, a.CurrencyConverter ?? b.CurrencyConverter);
		}

		[Obsolete("Нелогичная операция. Будет удалена")]
		public static Money operator *(Money a, Money b)
		{
			CorrectCurrency(a, ref b);
			return new Money(a.Value * b.Value, a.Currency, a.CurrencyConverter ?? b.CurrencyConverter);
		}

		[Obsolete("Нелогичная операция. Будет заменена на операцию, возвращающуюю число")]
		public static Money operator /(Money a, Money b)
		{
			CorrectCurrency(a, ref b);
			return new Money(a.Value / b.Value, a.Currency, a.CurrencyConverter ?? b.CurrencyConverter);
		}

		[Obsolete("Нелогичная операция. Будет удалена")]
		public static Money operator +(Money money, double k)
		{
			return new Money(money.Value + k, money.Currency, money.CurrencyConverter);
		}

		[Obsolete("Нелогичная операция. Будет удалена")]
		public static Money operator -(Money money, double k)
		{
			return new Money(money.Value - k, money.Currency, money.CurrencyConverter);
		}

		public static Money operator *(Money money, double k)
		{
			return new Money(money.Value * k, money.Currency, money.CurrencyConverter);
		}

		public static Money operator *(double k, Money money)
		{
			return money * k;
		}

		public static Money operator /(Money money, double k)
		{
			return new Money(money.Value / k, money.Currency, money.CurrencyConverter);
		}

		public static Money operator -(Money money)
		{
			return new Money(-money.Value, money.Currency, money.CurrencyConverter);
		}

		#region Comparison

		public static bool operator ==(Money a, Money b)
		{
			return Equals(a, b);
		}

		public static bool operator !=(Money a, Money b)
		{
			return !Equals(a, b);
		}

		public static bool operator >(Money a, Money b)
		{
			if (ReferenceEquals(a, null))
			{
				return false;
			}

			if (ReferenceEquals(b, null))
			{
				return false;
			}

			CorrectCurrency(a, ref b);
			return CompareValues(a.Value, b.Value) > 0;
		}

		public static bool operator >=(Money a, Money b)
		{
			if (ReferenceEquals(a, null))
			{
				return false;
			}

			if (ReferenceEquals(b, null))
			{
				return false;
			}

			CorrectCurrency(a, ref b);
			return CompareValues(a.Value, b.Value) >= 0;
		}

		public static bool operator <(Money a, Money b)
		{
			if (ReferenceEquals(a, null))
			{
				return false;
			}

			if (ReferenceEquals(b, null))
			{
				return false;
			}

			CorrectCurrency(a, ref b);
			return CompareValues(a.Value, b.Value) < 0;
		}

		public static bool operator <=(Money a, Money b)
		{
			if (ReferenceEquals(a, null))
			{
				return false;
			}

			if (ReferenceEquals(b, null))
			{
				return false;
			}

			CorrectCurrency(a, ref b);
			return CompareValues(a.Value, b.Value) <= 0;
		}

		#endregion

		#endregion

		/// <summary>
		/// Конвертирует валюту текущего экземпляра к заданной.
		/// </summary>
		/// <param name="targetCurrency"></param>
		/// <returns></returns>
		public Money ConvertToCurrency(string targetCurrency)
		{
			if (CurrencyConverter == null)
			{
				throw new NullReferenceException("Для текущего объекта денег не указан конвертер валют.");
			}

			return CurrencyConverter.Convert(this, targetCurrency);
		}

		#region ObjectOverride

		public override int GetHashCode()
		{
			unchecked
			{
				int hashCode = Value.GetHashCode();
				hashCode = (hashCode * 397) ^ (Currency != null ? Currency.GetHashCode() : 0);
				return hashCode;
			}
		}

		public override bool Equals(object obj)
		{
			var other = obj as Money;

			if (other == null)
			{
				return false;
			}

			if (ReferenceEquals(this, other))
			{
				return true;
			}

			return ByFieldsEquals(this, other);
		}

		public override string ToString()
		{
			return Value.ToString(CultureInfo.InvariantCulture) + " " + Currency;
		}

		#endregion

		public Money Copy()
		{
			return new Money(this);
		}

		public int CompareTo(Money other)
		{
			if (this > other)
			{
				return 1;
			}

			if (this < other)
			{
				return -1;
			}

			return 0;
		}


		/// <summary>
		/// Приводит (если необходимо) валюту второго аргуманта к валюте первого и возращает новый объект с нужной валютой.
		/// </summary>
		/// <param name="sample">То К ЧЕМУ мы будем приводить</param>
		/// <param name="modifiable">То, ЧЬЮ валюту мы будем приводить</param>
		/// <returns>Новый объект на базе второго параметра, но приведённого к валюте первого</returns>
		private static void CorrectCurrency(Money sample, ref Money modifiable)
		{
			if (sample.Currency == null)
			{
				sample.Currency = modifiable.Currency;
			}
			else if (!sample.Currency.Equals(modifiable.Currency))
			{
				modifiable = modifiable.ConvertToCurrency(sample.Currency);
			}
		}

		private static bool Equals(Money a, Money b)
		{
			if (ReferenceEquals(a, b))
			{
				return true;
			}

			if (ReferenceEquals(a, null))
			{
				return false;
			}

			if (ReferenceEquals(b, null))
			{
				return false;
			}

			if (a.GetType() != b.GetType())
			{
				return false;
			}

			return ByFieldsEquals(a, b);
		}

		private static bool ByFieldsEquals(Money a, Money b)
		{
			return CompareValues(a.Value, b.Value) == 0 &&
				a.Currency == b.Currency;
		}

		private static int CompareValues(double first, double second)
		{
			if (Math.Abs(first - second) <= PRECISION)
			{
				return 0;
			}
			else if (first > second)
			{
				return 1;
			}

			return -1;
		}
	}
}