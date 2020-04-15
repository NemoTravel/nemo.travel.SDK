using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание комиссии
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CommissionDataItem
	{
		/// <summary>
		/// Значение в %
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public float? Percent { get; set; }

		/// <summary>
		/// Абсолютное значение
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public float? Amount { get; set; }

		/// <summary>
		/// Валюту абсолютного значения
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Currency { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool IsFareCommission { get; set; }


		public CommissionDataItem()
		{
		}

		public CommissionDataItem(CommissionDataItem other)
		{
			Percent = other.Percent;
			Amount = other.Amount;
			Currency = other.Currency;
			IsFareCommission = other.IsFareCommission;
		}


		/// <summary>
		/// Генерирует строковое представление данного объекта
		/// </summary>
		/// <returns>Строкое представление объекта</returns>
		public string ToString(bool currencyFirst = false)
		{
			if (Percent.HasValue)
			{
				return Percent.Value.ToString("R") + "%";
			}
			else if (Amount.HasValue)
			{
				if (currencyFirst)
				{
					return Currency + " " + Amount.Value.ToString("R", Locale.UsCulture);
				}
				else
				{
					return Amount.Value.ToString("R") + Currency;
				}
			}

			return null;
		}

		public override bool Equals(object obj)
		{
			var anotherCommission = obj as CommissionDataItem;
			return anotherCommission != null && Amount == anotherCommission.Amount && Currency == anotherCommission.Currency && Percent == anotherCommission.Percent;
		}

		public bool Equals(CommissionDataItem comm, bool checkFareCommProperty = true)
		{
			return Equals((object)comm) && (!checkFareCommProperty || IsFareCommission == comm.IsFareCommission);
		}

		public static bool Equals(CommissionDataItem item1, CommissionDataItem item2)
		{
			return item1 == null && item2 == null ||
				item1 != null && item2 != null && item1.Equals(item2);
		}

		public override int GetHashCode()
		{
			int result = 0;

			result ^= Percent == null ? 0 : Percent.GetHashCode();
			result ^= Amount == null ? 0 : Amount.GetHashCode();

			if (!string.IsNullOrEmpty(Currency))
			{
				result ^= Currency.GetHashCode();
			}

			// IsFareCommission - нет проверки на равенство в перегрузке Equals, поэтому не включается в хэшкод

			return result;
		}

		public CommissionDataItem Copy()
		{
			return new CommissionDataItem(this);
		}
	}
}