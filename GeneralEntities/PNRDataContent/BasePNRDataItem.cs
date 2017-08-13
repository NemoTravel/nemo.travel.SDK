using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание общих элементов DataItem
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BasePNRDataItem : ItemIdentification<int>
	{
		[IgnoreDataMember]
		public string IDInPNR { get; set; }


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
		/// Содержит дополнительные локаторы ПНРа от поставщика
		/// </summary>
		[DataMember(Order = 24, EmitDefaultValue = false)]
		public AdditionalLocatorsDataItem AdditionalLocators { get; set; }
		/// <summary>
		/// OSI - Other service information (Прочая служебная информация)
		/// </summary>
		[DataMember(Order = 25, EmitDefaultValue = false)]
		public OSIDataItem OSI { get; set; }

		/// <summary>
		/// Данные о связных бронях (родительской и дочерней)
		/// Появляются после разделения брони
		/// </summary>
		[DataMember(Order = 26, EmitDefaultValue = false)]
		public ReferencedBooksDataItem ReferencedBooks { get; set; }

		/// <summary>
		/// Документ - основание скидки
		/// </summary>
		[DataMember(Order = 28, EmitDefaultValue = false)]
		public DiscountDocumentDataItem DiscountDocument { get; set; }


		public BasePNRDataItem() { }

		public BasePNRDataItem(BasePNRDataItem item)
		{
			Type = item.Type;

			if (item.ServiceRef != null && item.ServiceRef.Count > 0)
			{
				ServiceRef = new RefList<int>(item.ServiceRef);
			}

			if (item.SegmentRef != null && item.SegmentRef.Count > 0)
			{
				SegmentRef = new RefList<int>(item.SegmentRef);
			}

			if (item.TravellerRef != null && item.TravellerRef.Count > 0)
			{
				TravellerRef = new RefList<int>(item.TravellerRef);
			}
		}


		/// <summary>
		/// Проверяет данный элемент на привязку к определённому пассажиру в брони
		/// </summary>
		/// <param name="travellerID">Номер пассажира в брони, на привязку к которому требуется проверить данный элемент</param>
		/// <param name="includeNotLinked">Включает определение DataItem'ов без привязки к пассажирам, как привязанных ко всем</param>
		/// <returns>Признак привязки данного элемент к указанному пассажиру</returns>
		public bool IsLinkedToTraveller(int travellerID, bool includeNotLinked = false)
		{
			return IsLinked(TravellerRef, travellerID, includeNotLinked);
		}

		/// <summary>
		/// Проверяет данный элемент на привязку к какому либо из указанных пассажиров брони
		/// </summary>
		/// <param name="passRefs">Список ИД пассажиров в брони, принадлежность к которым требуется проверить</param>
		/// <param name="includeNotLinked">Включает определение DataItem'ов без привязки к пассажирам, как привязанных ко всем</param>
		/// <returns>Признак привязки данного элемент к одному из указанных пассажиров</returns>
		public bool IsLinkedToTravellers(IEnumerable<int> passRefs, bool includeNotLinked = false)
		{
			return (passRefs == null || !passRefs.Any()) ||
				(TravellerRef != null && TravellerRef.Any() && TravellerRef.Intersect(passRefs).Any()) ||
				((TravellerRef == null || !TravellerRef.Any()) && includeNotLinked);
		}

		/// <summary>
		/// Выполняет проверку что данный элемент привязан к определённой услуге
		/// </summary>
		/// <param name="serviceID">ИД услуги, привязку элемента к которой требуется проверить</param>
		/// <param name="includeNotLinked">Включает определение DataItem'ов без привязки к услугам, как привязанных ко всем</param>
		/// <returns>Результат проверки</returns>
		public bool IsLinkedToService(int serviceID, bool includeNotLinked = false)
		{
			return IsLinked(ServiceRef, serviceID, includeNotLinked);
		}

		/// <summary>
		/// Проверяет данный элемент на привязку к какой либо из указанных услуг брони
		/// </summary>
		/// <param name="serviceREfs">Список ИД услуг в брони, принадлежность к которым требуется проверить</param>
		/// <param name="notLinkedAsAll">Включает определение DataItem'ов без привязки к услугам, как привязанных ко всем</param>
		/// <returns>Признак привязки данного элемент к одной из указанных услуг</returns>
		public bool IsLinkedToServices(IEnumerable<int> serviceREfs, bool notLinkedAsAll = false)
		{
			if (serviceREfs == null || !serviceREfs.Any())
			{
				return true;
			}

			if (ServiceRef == null || !ServiceRef.Any())
			{
				return notLinkedAsAll;
			}

			return ServiceRef.Intersect(serviceREfs).Any();
		}

		/// <summary>
		/// Выполняет проверку что данный элемент привязан к определённому сегменту
		/// </summary>
		/// <param name="segmentID">ИД сегмента, привязку элемента к которому требуется проверить</param>
		/// <param name="includeNotLinked">Включает определение DataItem'ов без привязки к сегментам, как привязанных ко всем</param>
		/// <returns>Результат проверки</returns>
		public bool IsLinkedToSegment(int segmentID, bool includeNotLinked = false)
		{
			return IsLinked(SegmentRef, segmentID, includeNotLinked);
		}

		/// <summary>
		/// Выполняет проверку что данный элемент привязан к одному из указанных сегментов
		/// </summary>
		/// <param name="segmentRefs">Список ИД сегментов брони, привязку элемента к которому требуется проверить</param>
		/// <returns>Результат проверки</returns>
		public bool IsLinkedToSegments(IEnumerable<int> segmentRefs)
		{
			return (segmentRefs == null || !segmentRefs.Any()) || (SegmentRef == null || !segmentRefs.Any()) || SegmentRef.Intersect(segmentRefs).Any();
		}


		/// <summary>
		/// Привязан ли элемент к коллекции
		/// </summary>
		/// <param name="links">Коллекция привязок</param>
		/// <param name="chekedElementID">ИД элемента, который проверяется на привязку</param>
		/// <param name="includeNotLinked">Считать, что элемент привязан, если коллекция с привязками null или пуста</param>
		/// <returns></returns>
		private bool IsLinked(RefList<int> links, int chekedElementID, bool includeNotLinked)
		{
			if (links == null || links.Count == 0)
			{
				return includeNotLinked;
			}
			else
			{
				return links.Contains(chekedElementID);
			}
		}
	}
}