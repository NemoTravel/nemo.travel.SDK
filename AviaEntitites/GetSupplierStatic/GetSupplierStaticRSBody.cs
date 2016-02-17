using AviaEntities.GetAllowedCC;
using AviaEntities.GetSupplierStatic.FFPPartnership;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic
{
	/// <summary>
	/// Тело ответа с статикой от поставщика
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSupplierStaticRSBody
	{
		/// <summary>
		/// Информация о поддержке кредитных карт
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public CCCodeList CreditCardSupport { get; set; }

		/// <summary>
		/// Информация о партнерских программах авиакомпаний приема номеров карт часто летающих пассажиров авиакомпаний
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public AirlinePartnersList FFPPartnership { get; set; }
	}
}