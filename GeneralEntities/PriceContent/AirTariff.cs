using GeneralEntities.Shared.v1_1;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Авиа тариф в составе цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class AirTariff : BaseTariff
	{
		/// <summary>
		/// Тип тарифа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public TariffType Type { get; set; }

		/// <summary>
		/// Класс обслуживания по данному тарифу
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public BaseClass ClassOfService { get; set; }

		/// <summary>
		/// Класс бронирования для данного тарифа
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string BookingClassCode { get; set; }

		/// <summary>
		/// Номер сегмента
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public int SegmentID { get; set; }

		/// <summary>
		/// Бесплатный багаж по данному тарифу
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Baggage FreeBaggage { get; set; }

		/// <summary>
		/// Тип питания в данном классе обслуживания на данном сегменте перелёта
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public MealTypeList FreeMeal { get; set; }

		/// <summary>
		/// Признак что данный тариф является системным трансфером (сквозным тарифом)
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public bool? IsSystemTransfer { get; set; }

		/// <summary>
		/// ID описания семейства тарифов
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public int? FareFamilyDescID { get; set; }

		/// <summary>
		/// Код а/к семейства цены
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string FareFamilyCode { get; set; }

		/// <summary>
		/// Обратная совместимость для S7
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public string FareFamilyName { get; set; }

		/// <summary>
		/// Код тарифа без кода скидки
		/// </summary>
		public override string GetFareBasisCode(bool forceSplit = false)
		{
			if (Type == TariffType.Public || forceSplit)
			{
				return FareBasisCode;
			}
			else
			{
				return Code;
			}
		}
	}
}