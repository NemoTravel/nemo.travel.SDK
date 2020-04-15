using GeneralEntities.ExtendedDateTime;
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

		/// <summary>
		/// Валюта, для которой запрашивался курс
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string FromCurrencyCode { get; set; }

		/// <summary>
		/// Дата, на которую запрашивался курс
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public DateTimeEx Date { get; set; }
	}
}