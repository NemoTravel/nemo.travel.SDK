using System.Runtime.Serialization;

namespace AviaEntities.GetCurrencyConversion
{
	/// <summary>
	/// Содержит описание тела ответа с курсами обмена валюты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetCurrencyConversionRSBody
	{
		/// <summary>
		/// Курсы обмена на другие валюты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public CurrencyConversionList Conversions { get; set; }
	}
}