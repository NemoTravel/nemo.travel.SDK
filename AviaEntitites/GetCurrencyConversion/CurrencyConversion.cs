using System.Runtime.Serialization;

namespace AviaEntities.GetCurrencyConversion
{
	/// <summary>
	/// Содержит информацию о курсе обмена запрошенной валюты к некой валюте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CurrencyConversion
	{
		/// <summary>
		/// Код валюты, для которой применяется данный курс конвертации
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Курс конвертации
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public float Rate { get; set; }
	}
}