using GeneralEntities;
using GeneralEntities.Market;
using GeneralEntities.PriceContent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Описание семейства цен
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FareFamilyDescription
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int ID { get; set; }

		/// <summary>
		/// Название семейства
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Ручная кладь
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Carryon { get; set; }

		/// <summary>
		/// Типы бесплатного питания по тарифу
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public MealTypeList FreeMeal { get; set; }

		/// <summary>
		/// Возможность выбирать спецпитание
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool SpecialMealSelection { get; set; }

		/// <summary>
		/// Возвратность билетов по данному тарифу
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public RefundableEnum Refundable { get; set; }

		/// <summary>
		/// Посегментный сбор при возврате
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public Money PerSegmentRefundPenalty { get; set; }

		/// <summary>
		/// Сбор за билет при возврате
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public Money PerTicketRefundPenalty { get; set; }

		/// <summary>
		/// Билет может быть обменян
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public bool Exchangable { get; set; }

		/// <summary>
		/// Посегментный сбор за обмен
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money PerSegmentExchangePenalty { get; set; }

		/// <summary>
		/// Сбор за обмен билета
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public Money PerTicketExchangePenalty { get; set; }

		/// <summary>
		/// % миль к начислению
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public int FlownMiles { get; set; }

		/// <summary>
		/// Наличие ВИП услуг
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public bool VIPServices { get; set; }

		[DataMember(Order = 13, EmitDefaultValue = false)]
		public string AmadeusFFParams { get; set; }

		/// <summary>
		/// Универсальные парметры
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public List<FareFamilyParameter> UniversalParameters { get; set; }

		public FareFamilyDescription()
		{
			this.UniversalParameters = new List<FareFamilyParameter>();
		}
	}
}
