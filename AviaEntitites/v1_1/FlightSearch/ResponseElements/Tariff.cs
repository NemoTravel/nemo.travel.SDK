using GeneralEntities.Shared.v1_1;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию об определённом тарифе из цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Tariff_1_1")]
	public class Tariff
	{
		/// <summary>
		/// Код тарифа
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Code { get; set; }

		/// <summary>
		/// Индикатор приватности цен
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public FareTypes Type { get; set; }

		/// <summary>
		/// Признак что данный тариф является системным трансфером (сквозным тарифом)
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool? IsSystemTransfer { get; set; }

		/// <summary>
		/// Номер сегмента
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public int? SegNum { get; set; }

		/// <summary>
		/// Допустимая мера багажа для данного класса перелёта
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Baggage FreeBaggage { get; set; }

		/// <summary>
		/// Бренд(Имя семейства цены)
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public int? FareFamilyDescID { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string FareFamilyCode { get; set; }

		/// <summary>
		/// Идентификатор информации о субсидии
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public int? SubsidyInfoID { get; set; }
	}
}