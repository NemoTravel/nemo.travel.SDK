using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GeneralEntities.Market
{
	public interface ICurrencyDepended
	{
		/// <summary>
		/// Сумма денег
		/// </summary>
		double Value { get; set; }

		/// <summary>
		/// ISO Alpha 3 код валюты
		/// </summary>
		string Currency { get; set; }

		/// <summary>
		/// Объект для конвертирования валют
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		ICurrencyConverter CurrencyConverter { get; set; }
	}
}
