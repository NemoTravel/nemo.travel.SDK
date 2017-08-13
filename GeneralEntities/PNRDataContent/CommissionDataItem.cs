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

		/// <summary>
		/// Генерирует строковое представление данного объекта
		/// </summary>
		/// <returns>Строкое представление объекта</returns>
		public string ToString(bool currencyFirst = false)
		{
			if (Percent.HasValue)
			{
				return Percent.ToString() + "%";
			}
			else if (Amount.HasValue)
			{
				if (currencyFirst)
				{
					return Currency + " " + Amount.Value.ToString(Locale.UsCulture);
				}
				else
				{
					return Amount.ToString() + Currency;
				}
			}

			return null;
		}

		public override bool Equals(object obj)
		{
			var anotherCommission = obj as CommissionDataItem;
			return anotherCommission != null &&
				Amount == anotherCommission.Amount &&
				Currency == anotherCommission.Currency &&
				Percent == anotherCommission.Percent;
		}

		public bool Equals(CommissionDataItem comm, bool checkFareCommProperty = true)
		{
			return Equals((object)comm) && (!checkFareCommProperty || IsFareCommission == comm.IsFareCommission);
		}
	}
}