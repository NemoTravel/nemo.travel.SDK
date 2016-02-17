using System.Runtime.Serialization;

namespace GeneralEntities.Market
{
	/// <summary>
	/// Содержит описание данных о курсе валют
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CurrencyRate
	{
		/// <summary>
		/// Код валюты, из которой конвертируем
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string From { get; set; }

		/// <summary>
		/// Код валюты, в которую конвертируем
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string To { get; set; }

		/// <summary>
		/// Курс валют - сколько единиц валюты From нужно потратить на 1 единицу валюты To
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public double Rate { get; set; }
	}
}