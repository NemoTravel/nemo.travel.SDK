using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.GetCurrencyConversion
{
	/// <summary>
	/// Содержит описание тела запроса на получение курса валюты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetCurrencyConversionRQBody
	{
		/// <summary>
		/// ИД источника, из которого требуется получить курс валюты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int Source { get; set; }

		/// <summary>
		/// Код валюты, курс которой требуется получить
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string CurrencyCode { get; set; }

		/// <summary>
		/// Код валюты, относительно которой запрашивается курс
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string FromCurrencyCode { get; set; }

		/// <summary>
		/// Дата, на которую запрашивается курс
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public DateTimeEx Date { get; set; }
	}
}