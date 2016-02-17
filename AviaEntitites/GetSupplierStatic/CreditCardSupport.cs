using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic
{
	/// <summary>
	/// Содержит данные для получения информации о поддержке кредитных карты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CreditCardSupport
	{
		/// <summary>
		/// Код а/к
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Airline { get; set; }

		/// <summary>
		/// Код страны
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Country { get; set; }
	}
}