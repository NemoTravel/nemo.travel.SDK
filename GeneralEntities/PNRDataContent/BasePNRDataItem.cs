using GeneralEntities.Shared;
using SharedAssembly.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание общих элементов DataItem
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BasePNRDataItem : DataItemIdentification
	{
		public static DataItemReferenceEqualityComparer DATAITEM_REFERENCE_EQUALITY_COMPARER  = new DataItemReferenceEqualityComparer();


		[IgnoreDataMember]
		public string IDInPNR { get; set; }

		[IgnoreDataMember]
		public bool IsVisible
		{
			get
			{
				return Type != PNRDataItemType.FareRules && Type != PNRDataItemType.TFBookData;
			}
		}

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
		/// Доп. данные, распарсенные из тарифных правил
		/// </summary>
		[DataMember(Order = 27, EmitDefaultValue = false)]
		public FareInfoDataItem FareInfo { get; set; }

		/// <summary>
		/// Документ - основание скидки
		/// </summary>
		[DataMember(Order = 28, EmitDefaultValue = false)]
		public DiscountDocumentDataItem DiscountDocument { get; set; }


		/// <summary>
		/// файл ваучера
		/// </summary>
		[DataMember(Order = 29, EmitDefaultValue = false)]
		public VoucherFileDataItem Voucher { get; set; }

		/// <summary>
		/// Связанные заказы
		/// </summary>
		[DataMember(Order = 30, EmitDefaultValue = false)]
		public LinkedBooksDataItem LinkedBooks { get; set; }

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
		/// <param name="serviceRefs">Список ИД услуг в брони, принадлежность к которым требуется проверить</param>
		/// <param name="notLinkedAsAll">Включает определение DataItem'ов без привязки к услугам, как привязанных ко всем</param>
		/// <returns>Признак привязки данного элемент к одной из указанных услуг</returns>
		public bool IsLinkedToServices(IEnumerable<int> serviceRefs, bool notLinkedAsAll = false)
		{
			if (serviceRefs == null || !serviceRefs.Any())
			{
				return true;
			}

			if (ServiceRef == null || !ServiceRef.Any())
			{
				return notLinkedAsAll;
			}

			return ServiceRef.Intersect(serviceRefs).Any();
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
			return (segmentRefs == null || !segmentRefs.Any()) || 
				(SegmentRef == null || !SegmentRef.Any()) || 
				SegmentRef.Intersect(segmentRefs).Any();
		}

		public BasePNRDataItem Copy()
		{
			var result = new BasePNRDataItem();
			CopyTo(result);
			return result;
		}

		public bool Equals(BasePNRDataItem other, bool checkTravellerRefs = true, bool checkServiceRefs = true, bool checkSegmentsRef = true)
		{
			if (other == null)
			{
				return false;
			}

			if (Type != other.Type)
			{
				return false;
			}

			if (checkTravellerRefs && !RefList<int>.Equals(TravellerRef, other.TravellerRef))
			{
				return false;
			}

			if (checkServiceRefs && !RefList<int>.Equals(ServiceRef, other.ServiceRef))
			{
				return false;
			}

			if (checkSegmentsRef && !RefList<int>.Equals(SegmentRef, other.SegmentRef))
			{
				return false;
			}

			return DataItemElementEquals(other);
		}

		protected virtual bool DataItemElementEquals(BasePNRDataItem other)
		{
			switch (Type)
			{
				case PNRDataItemType.Remark:
					return Equals(Remark, other.Remark);
				case PNRDataItemType.TL:
					return Equals(TimeLimits, other.TimeLimits);
				case PNRDataItemType.SSR:
					return Equals(SSR, other.SSR);
				case PNRDataItemType.Commission:
					return CommissionDataItem.Equals(Commission, other.Commission);
				case PNRDataItemType.FOP:
					return Equals(FOPInfo, other.FOPInfo);
				case PNRDataItemType.SourceInfo:
					return Equals(SourceInfo, other.SourceInfo);
				case PNRDataItemType.IDDocument:
					return Equals(Document, other.Document);
				case PNRDataItemType.ContactInfo:
					return Equals(ContactInfo, other.ContactInfo);
				case PNRDataItemType.LoyaltyCard:
					return Equals(LoyaltyCard, other.LoyaltyCard);
				case PNRDataItemType.Meal:
					return Equals(Meal, other.Meal);
				case PNRDataItemType.ED:
					return Equals(ElectronicDocument, other.ElectronicDocument);
				case PNRDataItemType.PD:
					return Equals(PaperDocument, other.PaperDocument);
				case PNRDataItemType.FE:
					return Equals(Endorsements, other.Endorsements);
				case PNRDataItemType.Visa:
					return Equals(Visa, other.Visa);
				case PNRDataItemType.ArrivalAddress:
					return Equals(ArrivalAddress, other.ArrivalAddress);
				case PNRDataItemType.BookedSeat:
					return Equals(BookedSeat, other.BookedSeat);
				case PNRDataItemType.ValidatingCompany:
					return Equals(ValidatingCompany, other.ValidatingCompany);
				case PNRDataItemType.TourCode:
					return Equals(TourCode, other.TourCode);
				case PNRDataItemType.Discount:
					return Equals(Discount, other.Discount);
				case PNRDataItemType.FareSourceCode:
					return Equals(FareSourceCode, other.FareSourceCode);
				case PNRDataItemType.AdditionalLocators:
					return Equals(AdditionalLocators, other.AdditionalLocators);
				case PNRDataItemType.OSI:
					return Equals(OSI, other.OSI);
				case PNRDataItemType.ReferencedBooks:
					return Equals(ReferencedBooks, other.ReferencedBooks);
				case PNRDataItemType.FareInfo:
					return Equals(FareInfo, other.FareInfo);
				case PNRDataItemType.DiscountDocument:
					return Equals(DiscountDocument, other.DiscountDocument);
				case PNRDataItemType.VoucherFile:
					return Equals(Voucher, other.Voucher);
				case PNRDataItemType.LinkedBooks:
					return Equals(LinkedBooks, other.LinkedBooks);
				default:
					return false;
			}
		}

		protected void CopyTo<T>(T dataItem) where T : BasePNRDataItem
		{
			dataItem.ID = ID;
			dataItem.IDInPNR = IDInPNR;
			dataItem.Type = Type;

			if (TravellerRef != null)
			{
				dataItem.TravellerRef = new RefList<int>(TravellerRef);
			}
			if (ServiceRef != null)
			{
				dataItem.ServiceRef = new RefList<int>(ServiceRef);
			}
			if (SegmentRef != null)
			{
				dataItem.SegmentRef = new RefList<int>(SegmentRef);
			}

			#region Клонирование внутренних элементов
			switch (Type)
			{
				case PNRDataItemType.Remark:
					dataItem.Remark = Remark?.Copy();
					break;
				case PNRDataItemType.TL:
					dataItem.TimeLimits = TimeLimits?.Copy();
					break;
				case PNRDataItemType.SSR:
					dataItem.SSR = SSR?.DeepCopy();
					break;
				case PNRDataItemType.Commission:
					dataItem.Commission = Commission?.Copy();
					break;
				case PNRDataItemType.FOP:
					dataItem.FOPInfo = FOPInfo?.Copy();
					break;
				case PNRDataItemType.SourceInfo:
					dataItem.SourceInfo = SourceInfo?.Copy();
					break;
				case PNRDataItemType.IDDocument:
					dataItem.Document = Document?.Copy();
					break;
				case PNRDataItemType.ContactInfo:
					dataItem.ContactInfo = ContactInfo?.Copy();
					break;
				case PNRDataItemType.LoyaltyCard:
					dataItem.LoyaltyCard = LoyaltyCard?.Copy();
					break;
				case PNRDataItemType.Meal:
					dataItem.Meal = Meal?.DeepCopy();
					break;
				case PNRDataItemType.ED:
					dataItem.ElectronicDocument = ElectronicDocument?.DeepCopy();
					break;
				case PNRDataItemType.PD:
					dataItem.PaperDocument = PaperDocument?.Copy();
					break;
				case PNRDataItemType.FE:
					dataItem.Endorsements = Endorsements?.Copy();
					break;
				case PNRDataItemType.Visa:
					dataItem.Visa = Visa?.Copy();
					break;
				case PNRDataItemType.ArrivalAddress:
					dataItem.ArrivalAddress = ArrivalAddress?.Copy();
					break;
				case PNRDataItemType.BookedSeat:
					dataItem.BookedSeat = BookedSeat?.Copy();
					break;
				case PNRDataItemType.ValidatingCompany:
					dataItem.ValidatingCompany = ValidatingCompany?.Copy();
					break;
				case PNRDataItemType.TourCode:
					dataItem.TourCode = TourCode?.Copy();
					break;
				case PNRDataItemType.Discount:
					dataItem.Discount = Discount?.Copy();
					break;
				case PNRDataItemType.FareSourceCode:
					dataItem.FareSourceCode = FareSourceCode?.Copy();
					break;
				case PNRDataItemType.AdditionalLocators:
					dataItem.AdditionalLocators = AdditionalLocators?.Copy();
					break;
				case PNRDataItemType.OSI:
					dataItem.OSI = OSI?.Copy();
					break;
				case PNRDataItemType.ReferencedBooks:
					dataItem.ReferencedBooks = ReferencedBooks?.Copy();
					break;
				case PNRDataItemType.FareInfo:
					dataItem.FareInfo = FareInfo?.Copy();
					break;
				case PNRDataItemType.DiscountDocument:
					dataItem.DiscountDocument = DiscountDocument?.Copy();
					break;
				case PNRDataItemType.VoucherFile:
					dataItem.Voucher = Voucher?.Copy();
					break;
				case PNRDataItemType.LinkedBooks:
					dataItem.LinkedBooks = LinkedBooks?.Copy();
					break;
			}
			#endregion
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


		public class DataItemReferenceEqualityComparer : IEqualityComparer<BasePNRDataItem>
		{
			/// <inheritdoc />
			public bool Equals(BasePNRDataItem x, BasePNRDataItem y)
			{
				return
					RefList<int>.Equals(x.TravellerRef, y.TravellerRef) &&
					RefList<int>.Equals(x.SegmentRef, y.SegmentRef) &&
					RefList<int>.Equals(x.ServiceRef, y.ServiceRef);
			}

			/// <inheritdoc />
			public int GetHashCode(BasePNRDataItem obj)
			{
				unchecked
				{
					var hashCode = 31;

					hashCode = (hashCode * 397) ^ (obj.TravellerRef.IsNullOrEmpty() ? 0 : obj.TravellerRef.GetHashCode());
					hashCode = (hashCode * 397) ^ (obj.SegmentRef.IsNullOrEmpty() ? 0 : obj.SegmentRef.GetHashCode());
					hashCode = (hashCode * 397) ^ (obj.ServiceRef.IsNullOrEmpty() ? 0 : obj.ServiceRef.GetHashCode());

					return hashCode;
				}
			}
		}
	}
}