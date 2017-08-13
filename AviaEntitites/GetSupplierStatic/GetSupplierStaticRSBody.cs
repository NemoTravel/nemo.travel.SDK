using AviaEntities.GetAllowedCC;
using AviaEntities.GetSupplierStatic.FFPPartnership;
using System.Runtime.Serialization;
using AviaEntities.GetSupplierStatic.ClassesOfService;

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

		/// <summary>
		/// Отношение [код а/к : [литера класса : базовый класс]]
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public AirlneClassCodes AirlneClassCodes { get; set; }
	}
}