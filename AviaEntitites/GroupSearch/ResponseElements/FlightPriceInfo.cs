using AviaEntities.FlightSearch.ResponseElements;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию об идентификации сгруппированного перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightPriceInfo
	{
		/// <summary>
		/// ИД перелёта
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string FlightID { get; set; }

		/// <summary>
		/// ИД цены, которая определяет данный перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public long PriceID { get; set; }

		/// <summary>
		/// Информация о типизации данного перелёта по различным критериям
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public FlightTypeInfo TypeInfo { get; set; }

		/// <summary>
		/// Дополнительная ценовая информация перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public AdditionalPriceInfo AdditionalPriceInfo { get; set; }

		/// <summary>
		/// Содержит некие идентификаторы данного перелёта в системах поставщиков, необходимые для дальнейших операций с ним (бронирование или ещё что-то)
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public FlightSupplierLinkageInfo SupplierLinkageInfo { get; set; }


		/// <summary>
		/// Создание объекта класс с инициализацией необходимых полей
		/// </summary>
		public FlightPriceInfo()
		{
			TypeInfo = new FlightTypeInfo();
		}
	}
}