using GeneralEntities.Shared.v1_1;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Авиа тариф в составе цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class AirTariff : BaseTariff, ITariff
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
		/// Содержит данные, необходимые для получения текста УПТ
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public string FBRuleKey { get; set; }

		/// <summary>
		/// ID информации о субсидии
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public int? SubsidyInfoID { get; set; }

		/// <summary>
		/// Ручная кладь по данному тарифу
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public Baggage CarryOn { get; set; }

		/// <summary>
		/// Полный код варианта багажа у поставщика. Используется для AccelAero
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public string SupplierBaggageCode { get; set; }

		/// <summary>
		/// Код тарифа без кода скидки
		/// </summary>
		public override string GetFareBasisCode(bool forceSplit = false)
		{
			if (Type == TariffType.Public || forceSplit)
			{
				return FareBasisCode;
			}

			return Code;
		}

		public AirTariff Copy()
		{
			var result = new AirTariff();

			result.SegmentID = this.SegmentID;
			result.Code = this.Code;
			result.BookingClassCode = this.BookingClassCode;
			result.ClassOfService = this.ClassOfService;
			result.FareFamilyCode = this.FareFamilyCode;
			result.FareFamilyDescID = this.FareFamilyDescID;
			result.FareFamilyName = this.FareFamilyName;
			result.FBRuleKey = this.FBRuleKey;
			result.IsSystemTransfer = this.IsSystemTransfer;
			result.SubsidyInfoID = this.SubsidyInfoID;
			result.Type = this.Type;
			result.FreeBaggage = this.FreeBaggage?.Copy();
			result.CarryOn = this.CarryOn?.Copy();

			if (this.FreeMeal != null)
			{
				result.FreeMeal = new MealTypeList(this.FreeMeal);
			}

			return result;
		}

		public int GetSegmentRef()
		{
			return SegmentID;
		}
	}
}