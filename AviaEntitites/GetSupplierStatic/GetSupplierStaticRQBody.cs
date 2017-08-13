using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic
{
	/// <summary>
	/// Тело запроса на получение статики от ГДС
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetSupplierStaticRQBody
	{
		/// <summary>
		/// ИД источника, из которого требуется получить курс валюты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int Source { get; set; }

		/// <summary>
		/// Тип статики
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public SupplierStaticType StaticType { get; set; }

		/// <summary>
		/// Данные для получения информации о поддержке кредитных карт
		/// </summary>
		[DataMember(Order = 2)]
		public CreditCardSupport CreditCardSupport { get; set; }

		/// <summary>
		/// Данные для получения справочника допуслуг
		/// </summary>
		[DataMember(Order = 3)]
		public AncillaryServiceCatalogue AncillaryServiceCatalogue { get; set; }
	}
}