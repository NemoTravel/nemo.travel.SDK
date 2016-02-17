using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание общих элементов DataItem
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BasePNRDataItem : ItemIdentification<int>
	{
		/// <summary>
		/// Ссылка на пассажиров, которым принадлежат данные
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public RefList<int> TravellerRef { get; set; }

		/// <summary>
		/// Ссылка на услугу
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public RefList<int> ServiceRef { get; set; }

		/// <summary>
		/// Ссылка на сегменты, к которым относятся данные
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public RefList<int> SegmentRef { get; set; }

		/// <summary>
		/// Тип данных в этом блоке
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public PNRDataItemType Type { get; set; }



		/// <summary>
		/// Ремарка
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public RemarkDataItem Remark { get; set; }

		/// <summary>
		/// Тайм-лимиты
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public TimeLimitDataItem TimeLimits { get; set; }

		/// <summary>
		/// SSRка
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public SSRDataItem SSR { get; set; }

		/// <summary>
		/// Комиссия
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public CommissionDataItem Commission { get; set; }

		/// <summary>
		/// ФОП для выписки
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public FOPDataItem FOPInfo { get; set; }

		/// <summary>
		/// Информация об источнике где была создана бронь
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public SourceInfoDataItem SourceInfo { get; set; }

		/// <summary>
		/// Идентификационный документ пассажира
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public DocumentInfoDataItem Document { get; set; }

		/// <summary>
		/// Контактные данные в ПНРе
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public ContactInfoDataItem ContactInfo { get; set; }

		/// <summary>
		/// Карточка участника программы лояльности
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public LoyaltyCardDataItem LoyaltyCard { get; set; }

		/// <summary>
		/// Спецпитание
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public SSRDataItem Meal { get; set; }

		/// <summary>
		/// Электронный документ
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public ElectronicDocumentDataItem ElectronicDocument { get; set; }

		/// <summary>
		/// Бумажный документ
		/// </summary>
		[DataMember(Order = 15, EmitDefaultValue = false)]
		public PaperDocumentDataItem PaperDocument { get; set; }

		/// <summary>
		/// Эндорсменты
		/// </summary>
		[DataMember(Order = 16, EmitDefaultValue = false)]
		public EndorsementDataItem Endorsements { get; set; }

		/// <summary>
		/// Виза
		/// </summary>
		[DataMember(Order = 17, EmitDefaultValue = false)]
		public VisaDataItem Visa { get; set; }

		/// <summary>
		/// Адрес пребывания
		/// </summary>
		[DataMember(Order = 18, EmitDefaultValue = false)]
		public ArrivalAddressDataItem ArrivalAddress { get; set; }

		/// <summary>
		/// Информация о забронированном месте
		/// </summary>
		[DataMember(Order = 19, EmitDefaultValue = false)]
		public BookedSeatDataItem BookedSeat { get; set; }

		/// <summary>
		/// Переопределенный ВП
		/// </summary>
		[DataMember(Order = 20, EmitDefaultValue = false)]
		public ValidatingCompanyDataItem ValidatingCompany { get; set; }
		/// <summary>
		/// Тур код
		/// </summary>
		[DataMember(Order = 21, EmitDefaultValue = false)]
		public TourCodeDataItem TourCode { get; set; }

		/// <summary>
		/// Скидка
		/// </summary>
		[DataMember(Order = 22, EmitDefaultValue = false)]
		public DiscountDataItem Discount { get; set; }

		/// <summary>
		/// Информация об уникальном коде тарифа
		/// </summary>
		[DataMember(Order = 23, EmitDefaultValue = false)]
		public FareSourceCodeDataItem FareSourceCode { get; set; }


		/// <summary>
		/// Проверяет данный элемент на привязку к определённому пассажиру в брони
		/// </summary>
		/// <param name="travellerNumber">Номер пассажира в брони, на привязку к которому требуется проверить данный элемент</param>
		/// <returns>Признак привязки данного элемент к указанному пассажиру</returns>
		public bool IsLinkedToTraveller(int travellerNumber)
		{
			return TravellerRef != null && TravellerRef.Contains(travellerNumber);
		}

		/// <summary>
		/// Выполняет проверку что данный элемент привязан к определённой услуге
		/// </summary>
		/// <param name="serviceID">ИД услуги, привязку элемента к которой требуется проверить</param>
		/// <returns>Результат проверки</returns>
		public bool IsLinkedToService(int serviceID)
		{
			return ServiceRef == null || ServiceRef.Contains(serviceID);
		}
	}
}