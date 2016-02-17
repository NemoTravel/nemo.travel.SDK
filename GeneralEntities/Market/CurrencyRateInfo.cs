using GeneralEntities.ExtendedDateTime;
using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Market
{
	/// <summary>
	/// Содержит описание курса валюты
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CurrencyRateInfo : CurrencyRate
	{
		/// <summary>
		/// Дата и время когда был получен данный курс
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public DateTimeEx Received { get; set; }

		/// <summary>
		/// Источник курса
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public CurrencyRateSource Source { get; set; }
	}
}