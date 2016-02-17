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

		/// <summary>
		/// Генерирует строковое представление данного объекта
		/// </summary>
		/// <returns>Строкое представление объекта</returns>
		public override string ToString()
		{
			if (Percent.HasValue)
			{
				return Percent.ToString() + "%";
			}
			else if (Amount.HasValue)
			{
				return Amount.ToString() + Currency;
			}
			else
			{
				return null;
			}
		}
	}
}