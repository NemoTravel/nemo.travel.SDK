using System;
using System.Runtime.Serialization;

namespace GeneralEntities
{
	/// <summary>
	/// Типы статики от поставщика, которые можно получать
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum SupplierStaticType
	{
		/// <summary>
		/// Поддержка кредитных карт
		/// </summary>
		[EnumMember]
		CreditCardSupport = 0,
		/// <summary>
		/// Партнерские группы ак по приему карт лояльности
		/// </summary>
		[EnumMember]
		FFPPartnership = 1,
		[EnumMember]
		SSRCodes = 2,
		[EnumMember]
		TravellerDocumentTypes = 3,
		/// <summary>
		/// Отношение литер и классов обслуживания
		/// </summary>
		[EnumMember]
		ClassOfService = 4,
		[EnumMember]
		/// <summary>
		/// Справочник допуслуг
		/// </summary>
		AncillaryServiceCatalogue = 5
	}

	/// <summary>
	/// Типы сред выполнения запросов у поставщиков
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum EnvironmentType
	{
		/// <summary>
		/// Тестовая среда
		/// </summary>
		[EnumMember]
		TEST = 0,
		/// <summary>
		/// Сертификационная среда
		/// </summary>
		[EnumMember]
		CERT = 1,
		/// <summary>
		/// Продакшен (рабочая) среда
		/// </summary>
		[EnumMember]
		PROD = 2
	}

	/// <summary>
	/// Список типов документов, поддерживаемых сервером
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum DocTypes
	{
		/// <summary>
		/// Passport, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		P = 0,
		/// <summary>
		/// Alien resident card, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		A = 1,
		/// <summary>
		/// Permanent resident card, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		C = 2,
		/// <summary>
		///  Facilitation document, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		F = 3,
		/// <summary>
		/// Military, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		M = 4,
		/// <summary>
		/// Naturalization certificate, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		N = 5,
		/// <summary>
		/// Refugee travel document and re-entry permit, US Travel document, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		T = 6,
		/// <summary>
		/// Border crossing card, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		V = 7,
		/// <summary>
		/// National ID, стандарт SSR DOCS
		/// </summary>
		[EnumMember]
		I = 8,

		/// <summary>
		/// Паспорт
		/// </summary>
		[EnumMember]
		Passport = 10,
		/// <summary>
		/// Вид на жительство
		/// </summary>
		[EnumMember]
		ResidencePermit = 11,
		/// <summary>
		/// Военный билет для проходящего службу или по контракту
		/// </summary>
		[EnumMember]
		MilitaryIDCard = 12,
		/// <summary>
		/// Временное удостоверение личности при утрате или замене паспорта
		/// </summary>
		[EnumMember]
		DocOfPassportLusing = 13,
		/// <summary>
		/// Дипломатический паспорт
		/// </summary>
		[EnumMember]
		DiplomaticPassport = 14,
		/// <summary>
		/// Заграничный паспорт гражданина любой страны кроме РФ
		/// </summary>
		[EnumMember]
		InternationalPassportNotRU = 15,
		/// <summary>
		/// Заграничный паспорт гражданина Таджикистана (специфика авиарейсов из Новосибирска)
		/// </summary>
		[EnumMember]
		InternationalPassportTJ = 16,
		/// <summary>
		/// Заграничный паспорт гражданина РФ
		/// </summary>
		[EnumMember]
		InternationalPassportRU = 17,
		/// <summary>
		/// Заграничный паспорт
		/// </summary>
		[EnumMember]
		InternationalPassport = 18,
		/// <summary>
		/// Национальный паспорт
		/// </summary>
		[EnumMember]
		NationalPassport = 19,
		/// <summary>
		/// Паспорт моряка, удостоверение личности моряка
		/// </summary>
		[EnumMember]
		SeamanDocument = 20,
		/// <summary>
		/// Пенсионное удостоверение
		/// </summary>
		[EnumMember]
		SeniorDocument = 21,
		/// <summary>
		/// Свидетельство на возвращение в страны СНГ
		/// </summary>
		[EnumMember]
		ReturnIntoSNGCountry = 22,
		/// <summary>
		/// Свидетельство о рождении
		/// </summary>
		[EnumMember]
		BerthRegDocument = 23,
		/// <summary>
		/// Служебный паспорт
		/// </summary>
		[EnumMember]
		ServicePassport = 24,
		/// <summary>
		/// Справка об освобождении для освободившихся лиц
		/// </summary>
		[EnumMember]
		ReleaseCertificate = 25,
		/// <summary>
		/// Удостоверение, выдаваемое осужденному на время отпуска
		/// </summary>
		[EnumMember]
		CertificateOfConvictedVacation = 26,
		/// <summary>
		/// Удостоверение депутата местных законодательных органов
		/// </summary>
		[EnumMember]
		LocalParliamentDeputy = 27,
		/// <summary>
		/// Удостоверение депутата Совета Федераций или Госдумы
		/// </summary>
		[EnumMember]
		FederalParliamentDeputy = 28,
		/// <summary>
		/// Удостоверение судьи Конституционного Суда
		/// </summary>
		[EnumMember]
		ConstitutionalCourtJudgeDocument = 29,
		/// <summary>
		/// Удостоверение личности офицера,прапорщика,мичмана
		/// </summary>
		[EnumMember]
		MilitaryOfficerDocument = 30,
		/// <summary>
		/// Автоматический тип документа
		/// </summary>
		[EnumMember]
		AutosetByNumber = 31,
		/// <summary>
		/// Справка об утере паспорта
		/// </summary>
		[EnumMember]
		CertificateOfLossPassport = 32,
		/// <summary>
		/// Паспорт СССР
		/// </summary>
		[EnumMember]
		PassportUSSR = 33,
		/// <summary>
		/// Удостоверение личности лица без гражданства
		/// </summary>
		[EnumMember]
		IdentityWithoutCitizenship = 34,
		/// <summary>
		/// Паспорт Узбекистана
		/// </summary>
		[EnumMember]
		PassportUZ = 35,
		/// <summary>
		/// Паспорт Казахстана
		/// </summary>
		[EnumMember]
		PassportKZ = 36,
		/// <summary>
		/// Удостоверение личности
		/// </summary>
		[EnumMember]
		IdentityCard = 37,
		/// <summary>
		/// Медицинское свидетельство о рождении
		/// </summary>
		[EnumMember]
		MedicalBirthCertificate = 38
	}

	/// <summary>
	/// Список типов телефонов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum TelephoneTypes
	{
		/// <summary>
		/// Агенство
		/// </summary>
		[EnumMember]
		A = 0,
		/// <summary>
		/// Рабочий
		/// </summary>
		[EnumMember]
		B = 1,
		/// <summary>
		/// Мобильный
		/// </summary>
		[EnumMember]
		M = 2,
		/// <summary>
		/// Домашний
		/// </summary>
		[EnumMember]
		H = 3
	}

	/// <summary>
	/// Список полов пассажиров
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum GenderTypes
	{
		/// <summary>
		/// Не выбрано
		/// </summary>
		[EnumMember]
		N = 0,
		/// <summary>
		/// Мужской
		/// </summary>
		[EnumMember]
		M = 1,
		/// <summary>
		/// Женский
		/// </summary>
		[EnumMember]
		F = 2
	}

	/// <summary>
	/// Типы пассажиров
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PassTypes
	{
		/// <summary>
		/// Взрослые
		/// </summary>
		[EnumMember]
		ADT = 0,
		/// <summary>
		/// Дети без сопровождения взрослых
		/// </summary>
		[EnumMember]
		UNN = 1,
		/// <summary>
		/// Дети с сопровождением взрослых
		/// </summary>
		[EnumMember]
		CNN = 2,
		/// <summary>
		/// Младенцы без места
		/// </summary>
		[EnumMember]
		INF = 3,
		/// <summary>
		/// Младенцы с местом
		/// </summary>
		[EnumMember]
		INS = 4,
		/// <summary>
		/// Военный
		/// </summary>
		[EnumMember]
		MIL = 5,
		/// <summary>
		/// Моряк
		/// </summary>
		[EnumMember]
		SEA = 6,
		/// <summary>
		/// Пожилой пассажир
		/// </summary>
		[EnumMember]
		SRC = 7,
		/// <summary>
		/// Студент
		/// </summary>
		[EnumMember]
		STU = 8,
		/// <summary>
		/// Молодёж
		/// </summary>
		[EnumMember]
		YTH = 9,
		/// <summary>
		/// Оптово-массовый тип взрослого
		/// </summary>
		[EnumMember]
		JCB = 10,
		/// <summary>
		/// Оптово-массовый тип ребёнка (включая младенца с местом)
		/// </summary>
		[EnumMember]
		JNN = 11,
		/// <summary>
		/// Оптово-массовый тип младенца без места
		/// </summary>
		[EnumMember]
		JNF = 12,
		/// <summary>
		/// Пассажир сопровождающий инвалида
		/// </summary>
		[EnumMember]
		DAT = 13,
		/// <summary>
		/// Инвалид
		/// </summary>
		[EnumMember]
		DIS = 14
	}

	/// <summary>
	/// Список возможных статусов брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BookStatus
	{
		/// <summary>
		/// забронировано
		/// </summary>
		[EnumMember]
		Booked = 1,
		/// <summary>
		/// бронь отменена
		/// </summary>
		[EnumMember]
		Canceled = 2,
		/// <summary>
		/// выписана
		/// </summary>
		[EnumMember]
		Ticketed = 3,
		/// <summary>
		/// Частично выписанный, часть пассажиров выписана, часть нет
		/// </summary>
		[EnumMember]
		PartialTicketed = 4
	}

	/// <summary>
	/// Возможные статусы ПНРа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRStatus
	{
		/// <summary>
		/// Забронировано
		/// </summary>
		[EnumMember]
		Booked = 0,
		/// <summary>
		/// Отменено
		/// </summary>
		[EnumMember]
		Canceled = 1,
		/// <summary>
		/// Выписано
		/// </summary>
		[EnumMember]
		Ticketed = 2,
		/// <summary>
		/// Ожидает выписки
		/// </summary>
		[EnumMember]
		AwaitingTicketing = 3,
		/// <summary>
		/// Частично выписанный, часть пассажиров выписана, часть нет
		/// </summary>
		[EnumMember]
		Partial = 4,
		/// <summary>
		/// Услуга запрошена
		/// </summary>
		[EnumMember]
		Requested = 5,
		/// <summary>
		/// Отклонено
		/// </summary>
		[EnumMember]
		Rejected = 6,
		/// <summary>
		/// Проблемный заказ
		/// </summary>
		[EnumMember]
		Problematic = 10,
	}

	/// <summary>
	/// Возможные подстатусы брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRAdditionalStatus
	{
		/// <summary>
		/// Невалидный статус сегмента
		/// </summary>
		[EnumMember]
		InvalidSegmentStatus = 0,
		/// <summary>
		/// Один из сегментов имеет валидный статус, который требуется сменить на HK (к примеру ТК статус)
		/// </summary>
		[EnumMember]
		SegmentStatusForManualConfirmation = 1,
		/// <summary>
		/// Есть выписанные билеты, однако в ПНРе их нет
		/// </summary>
		[EnumMember]
		HaveNotStoredTickets = 2,
		/// <summary>
		/// Статус билет в ПНРе и аудит репорте не совпадают
		/// </summary>
		[EnumMember]
		NotActualTicketStatus = 3,
		/// <summary>
		/// Слетел тариф, специфика Галилео
		/// </summary>
		[EnumMember]
		NoValidFare = 4,
		/// <summary>
		/// Данные о провойдированных билетах не были удалены из ПНРа. Специфика Амадеуса
		/// </summary>
		[EnumMember]
		UnremovedVoidedTicketElements = 5,
		/// <summary>
		/// Специфичная ситуация в Сирене при оплате через их ПШ, может быть ситуация что бронь уже оплатилась, но ещё билеты не выписались, в этом случае ничего с бронью делать нельзя
		/// </summary>
		[EnumMember]
		PaidBook = 6,
		/// <summary>
		/// Ошибка при актуализации цены
		/// </summary>
		[EnumMember]
		FailedToActualizePrice = 7,
		/// <summary>
		/// Ошибка "выписки" в ТФ
		/// </summary>
		[EnumMember]
		TicketingFailed = 8,
		/// <summary>
		/// Специфичная ситуация с младенцами без места, требуется ручная обработка
		/// </summary>
		[EnumMember]
		UnconfirmedInfant = 9,
		/// <summary>
		/// Данная бронь дублирует другую (специфика ТФ)
		/// </summary>
		[EnumMember]
		DuplicateBooking = 10,
		/// <summary>
		/// Статус брони не подтверждён (специфика ТФ)
		/// </summary>
		[EnumMember]
		UnconfirmedBooking = 11,
		/// <summary>
		/// Бронь содержит непотвержденную карточку лояльности
		/// </summary>
		[EnumMember]
		UnconfirmedLoyaltyCard = 12,
		/// <summary>
		/// Необходимо вернуть RSVR EMD
		/// </summary>
		[EnumMember]
		NeedRefundRSVR = 13,
		/// <summary>
		/// Ошибка при возврате RSVR EMD
		/// </summary>
		[EnumMember]
		FailedRefundRSVR = 14,
		/// <summary>
		/// Ошибка при обмене
		/// </summary>
		[EnumMember]
		FailedExchange = 15,
		/// <summary>
		/// Бронь содержит допуслуги для которых не существует цен
		/// </summary>
		[EnumMember]
		AncillariesWithoutPrice = 16,
		/// <summary>
		/// У сегментов отсутствует локатор от поставщика
		/// </summary>
		[EnumMember]
		NoAirlineLocator = 17,
		/// <summary>
		/// Расхождение между данными из ПНР и масок билетов
		/// </summary>
		[EnumMember]
		TicketMaskDataMismatch = 18,
		/// <summary>
		/// Есть обменянный билет, но нового взамен него нету.
		/// Тут либо обмен не завершён, либо обмены был на стороне а/к и в ГДС просто нет данных по новому билету.
		/// В любом случае это проблема и делать что-то с такой бронью крайне опасно.
		/// </summary>
		[EnumMember]
		ExchangedTicketWithoutNew = 19,
		/// <summary>
		/// На такущий момент специфика Галилео и uAPI в частности, когда от них приходит Z статус
		/// </summary>
		[EnumMember]
		SupplierDoNotKnowEdState = 20,
		/// <summary>
		/// SubStatus на случай, если от поставщика пришло "Order not found"
		/// </summary>
		[EnumMember]
		SupplierDidNotFoundOrder = 21,
	}

	/// <summary>
	/// Платёжный шлюз
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PaymentGateway
	{
		[EnumMember(Value = "chronopay")]
		Chronopay = 1,
		[EnumMember(Value = "comepay")]
		Comepay = 2,
		[EnumMember(Value = "copayco")]
		Copayco = 3,
		[EnumMember(Value = "deposit")]
		Deposit = 4,
		[EnumMember(Value = "ecpayment")]
		ECPayment = 5,
		[EnumMember(Value = "gateline")]
		Gateline = 6,
		[EnumMember(Value = "itransfer")]
		Itransfer = 7,
		[EnumMember(Value = "moneta")]
		Moneta = 8,
		[EnumMember(Value = "payture")]
		Payture = 9,
		[EnumMember(Value = "platron")]
		Platron = 10,
		[EnumMember(Value = "privatebank")]
		Privatebank = 11,
		[EnumMember(Value = "qiwi")]
		Qiwi = 12,
		[EnumMember(Value = "sirena")]
		Sirena = 13,
		[EnumMember(Value = "uniteller")]
		Uniteller = 14,
		[EnumMember(Value = "webmoney")]
		Webmoney = 15,
		[EnumMember(Value = "acquire")]
		Acquire = 16,
		[EnumMember(Value = "courier")]
		Courier = 17,
		[EnumMember(Value = "invoice")]
		Invoice = 18,
		[EnumMember(Value = "office")]
		Office = 19,
		[EnumMember(Value = "rapida")]
		Rapida = 20,
		[EnumMember(Value = "receipt")]
		Receipt = 21,
		[EnumMember(Value = "wayforpay")]
		Wayforpay = 22,
		[EnumMember(Value = "tespaygateway")]
		Testpaygateway = 23
	}

	/// <summary>
	/// Статус транзакции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PaymentTransactionStatus
	{
		/// <summary>
		/// Платёж проинициализирован
		/// </summary>
		[EnumMember]
		Initialized = 0,
		/// <summary>
		/// Транзакция авторизована, средства заблокированы
		/// </summary>
		[EnumMember]
		Authorized = 1,
		/// <summary>
		/// Оплачено - средства списаны
		/// </summary>
		[EnumMember]
		Confirmed = 2,
		/// <summary>
		/// Платёж отменён по нашему запросу
		/// </summary>
		[EnumMember]
		Canceled = 3,
		/// <summary>
		/// Платёж отклонён шлюзом
		/// </summary>
		[EnumMember]
		Rejected = 4
	}

	/// <summary>
	/// Тип маршрута перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum FlightDirectionType : byte
	{
		/// <summary>
		/// В одну сторону
		/// </summary>
		[EnumMember]
		OW = 0,
		/// <summary>
		/// Туда - обратно
		/// </summary>
		[EnumMember]
		RT = 1,
		/// <summary>
		/// Сложный маршрут
		/// </summary>
		[EnumMember]
		CT = 2,
		/// <summary>
		/// Вылет из точки А в точку Б и возврат в точку В.  Т.е. есть разрыв между ап прилета и вылета
		/// </summary>
		[EnumMember]
		SingleOJ = 3,
		/// <summary>
		/// Как single OJ, но есть 2 разрыва между ап прилета и вылета.
		/// </summary>
		[EnumMember]
		DoubleOJ = 4,
		/// <summary>
		/// HalfRT, он же RT/2
		/// </summary>
		[EnumMember]
		hRT = 5,
		/// <summary>
		/// MultiOW, он же OW+OW+
		/// </summary>
		[EnumMember]
		mOW = 6
	}

	/// <summary>
	/// Признак возвратности билета по данной цене
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum RefundableEnum
	{
		/// <summary>
		/// Неизвестно
		/// </summary>
		[EnumMember]
		Unknown = 0,
		/// <summary>
		/// Возвратный
		/// </summary>
		[EnumMember]
		Refundable = 1,
		/// <summary>
		/// Невозвратный
		/// </summary>
		[EnumMember]
		NonRefundable = 2,
		/// <summary>
		/// Возможнен возврат с штрафами
		/// </summary>
		[EnumMember]
		PenaltiesApplies = 3
	}

	/// <summary>
	/// Предпочитаемый класс перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ClassType
	{
		/// <summary>
		/// Эконом
		/// </summary>
		[EnumMember]
		Economy = 0,
		/// <summary>
		/// Бизнес класс
		/// </summary>
		[EnumMember]
		Business = 1,
		/// <summary>
		/// Первый класс
		/// </summary>
		[EnumMember]
		First = 2,
		/// <summary>
		/// Премиум эконом
		/// </summary>
		[EnumMember]
		PremiumEconomy = 3,
		/// <summary>
		/// Все
		/// </summary>
		[EnumMember]
		All = 6,
	}

	/// <summary>
	/// Базовый классы перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BaseClass : byte
	{
		[EnumMember]
		Economy = 0,
		[EnumMember]
		Business = 1,
		[EnumMember]
		First = 2,
		[EnumMember]
		PremiumEconomy = 3,
		[EnumMember]
		Other = 5
	}

	/// <summary>
	/// Статус брони отеля
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum HotelsBookStatus
	{
		/// <summary>
		/// Новый
		/// </summary>
		[EnumMember]
		New = 1,
		/// <summary>
		/// Забронирован
		/// </summary>
		[EnumMember]
		Booked = 2,
		/// <summary>
		/// Подтвержден, оплачен
		/// </summary>
		[EnumMember]
		Confirmed = 3,
		/// <summary>
		/// Отменен
		/// </summary>
		[EnumMember]
		Cancelled = 4,
		/// <summary>
		/// Ожидает подтверждения
		/// </summary>
		[EnumMember]
		PendingConfirmation = 5,
		/// <summary>
		/// Проблемная бронь
		/// </summary>
		[EnumMember]
		Problematic = 6,
		/// <summary>
		/// Ожидает отмены
		/// </summary>
		[EnumMember]
		PendingCancellation = 7,
	}

	/// <summary>
	/// Поставщики отелей
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum HotelsSuppliers
	{
		/// <summary>
		/// BookedNet
		/// </summary>
		[EnumMember]
		BookedNet = 1,
		/// <summary>
		/// Hotelston
		/// </summary>
		[EnumMember]
		Hotelston = 2,
		/// <summary>
		/// Natecnia
		/// </summary>
		[EnumMember]
		Natecnia = 4,
		/// <summary>
		/// Oktogo
		/// </summary>
		[EnumMember]
		Oktogo = 8,
		/// <summary>
		/// Travelport
		/// </summary>
		[EnumMember]
		Travelport = 16,
		/// <summary>
		/// Academ
		/// </summary>
		[EnumMember]
		Academ = 32,
		/// <summary>
		/// Content Inn
		/// </summary>
		[EnumMember]
		ContentInn = 64,
		/// <summary>
		/// Ostrovok
		/// </summary>
		[EnumMember]
		Ostrovok = 128,
		/// <summary>
		/// Bronevik
		/// </summary>
		[EnumMember]
		Bronevik = 129,
		/// <summary>
		/// Amadeus
		/// </summary>
		[EnumMember]
		AmadeusHotels = 130,
		/// <summary>
		/// BookingCom
		/// </summary>
		[EnumMember]
		BookingCom = 131,
	}

	/// <summary>
	/// тип питания
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum HotelsMealTypes
	{
		[EnumMember]
		Unknown = 0,
		/// <summary>
		/// Room only
		/// </summary>
		[EnumMember]
		RO = 1,
		/// <summary>
		/// Breakfast
		/// </summary>
		[EnumMember]
		BB = 2,
		/// <summary>
		/// Half board
		/// </summary>
		[EnumMember]
		HB = 4,
		/// <summary>
		/// Full board
		/// </summary>
		[EnumMember]
		FB = 8,
		/// <summary>
		/// All inclusive
		/// </summary>
		[EnumMember]
		AI = 16,
		/// <summary>
		/// Dinner
		/// </summary>
		[EnumMember]
		DN = 32,
		/// <summary>
		/// Lunch
		/// </summary>
		[EnumMember]
		LU = 33,
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PriceRule
	{
		/// <summary>
		/// Неизвестно
		/// </summary>
		[EnumMember]
		Unknown = 0,
		/// <summary>
		/// Бесплатно
		/// </summary>
		[EnumMember]
		Free = 1,
		/// <summary>
		/// Доплата
		/// </summary>
		[EnumMember]
		AdditionalPrice = 2,
	}
	/// <summary>
	/// Тип постояльца
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum HotelsGuestTypes
	{
		/// <summary>
		/// Взрослый
		/// </summary>
		[EnumMember]
		ADT = 1,
		/// <summary>
		/// Ребенок
		/// </summary>
		[EnumMember]
		CLD = 2,
	}

	/// <summary>
	/// Поставщики авиа услуг.
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum AviaSuppliers
	{
		/// <summary>
		/// GDS Sabre
		/// </summary>
		[EnumMember]
		Sabre = 0,
		/// <summary>
		/// ГРС Сирена
		/// </summary>
		[EnumMember]
		Sirena = 1,
		/// <summary>
		/// GDS Galileo
		/// </summary>
		[EnumMember]
		Galileo = 2,
		/// <summary>
		/// GDS Amadeus
		/// </summary>
		[EnumMember]
		Amadeus = 3,
		/// <summary>
		/// GDS SITA Gabriel
		/// </summary>
		[EnumMember]
		SITAGabriel = 4,
		/// <summary>
		/// GDS SpecialFares
		/// </summary>
		[EnumMember]
		SpecialFares = 5,
		/// <summary>
		/// Вип сервис
		/// </summary>
		[EnumMember]
		SIG = 6,
		/// <summary>
		/// Немо инвентори
		/// </summary>
		[EnumMember]
		NemoInventory = 7,
		/// <summary>
		/// PEGAS Touristik
		/// </summary>
		[EnumMember]
		Pegasys = 8,
		[EnumMember]
		Travelfusion = 9,
		/// <summary>
		/// Mystifly
		/// </summary>
		[EnumMember]
		Mystifly = 10,
		/// <summary>
		/// GalileoUAPI
		/// </summary>
		[EnumMember]
		GalileoUAPI = 11,
		/// <summary>
		/// Немо-немо
		/// </summary>
		[EnumMember]
		Nemo = 12,

		// AmadeusS7SearchAPI = 13, Данный поставщик удален

		/// <summary>
		/// Farelogix
		/// </summary>
		[EnumMember]
		Farelogix = 14,

		// Atlasglobal = 16 - Удален

		/// <summary>
		/// S7 NDC API
		/// </summary>
		[EnumMember]
		S7NDC = 15,
		/// <summary>
		/// Навитэир
		/// </summary>
		[EnumMember]
		Navitaire = 17,
		/// <summary>
		/// Radixx
		/// </summary>
		[EnumMember]
		Radixx = 18,
		/// <summary>
		/// AirArabia
		/// </summary>
		[EnumMember]
		AccelAero = 19,
		/// <summary>
		/// Kiwi.com
		/// </summary>
		[EnumMember]
		Kiwi = 22,
		/// <summary>
		/// Aeroflot
		/// </summary>
		[EnumMember]
		AeroflotNDC = 24,
		/// <summary>
		/// FlyArystan
		/// </summary>
		[EnumMember]
		Hitit = 25,
		/// <summary>
		/// Solring NDC API
		/// </summary>
		[EnumMember]
		SolringNDC = 26

		// При добавлении нового поставщика необходимо также добавлять его в AviaEntities.AgencyAPISearch.Shared.Supplier
		//
		// А так же в файл `AviaServer/NDC/Constants/Supplier.cs`, если известен двух-символьный IATA код поставщика
		// или задаем значение `Suppliers.UNKNOWN_CODE`, если код неизвестен
	}

	/// <summary>
	/// Уровни ошибок в серверах
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ErrorLevels
	{
		/// <summary>
		/// Уровень формата запроса к серверу
		/// </summary>
		[EnumMember]
		APIFormat = 0,
		/// <summary>
		/// Уровень общения с поставщиком
		/// </summary>
		[EnumMember]
		Supplier = 1,
		/// <summary>
		/// Уровень выполнения определённой операции на сервере
		/// </summary>
		[EnumMember]
		Runtime = 2,
		/// <summary>
		/// Сетевые проблемы
		/// </summary>
		[EnumMember]
		Network = 3
	}

	/// <summary>
	/// Типы возможной доп информации об ошибке
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum AdditionalErrorInfoType
	{
		/// <summary>
		/// Информация о статус сегментов, когда не удалось забронирования один из сегментов
		/// </summary>
		[EnumMember]
		SegmentsStatus,
		/// <summary>
		/// Штаит?
		/// </summary>
		[EnumMember]
		InvalidParam,
		/// <summary>
		/// Хост команда, сгенерированная запросом
		/// </summary>
		[EnumMember]
		HostCommand,
		/// <summary>
		/// Стадия в рамках которой возникла ошибка
		/// </summary>
		[EnumMember]
		Stage
	}

	/// <summary>
	/// Содержит описание ИД серверов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum Servers : byte
	{
		/// <summary>
		/// Любой другой сторонний сервер
		/// </summary>
		[EnumMember]
		Unknown = 0,

		/// <summary>
		/// Сервер авиабронирования
		/// </summary>
		[EnumMember]
		AviaServer = 1,

		/// <summary>
		/// Сервер ж/д бронирования
		/// </summary>
		[EnumMember]
		RailServer = 2,

		/// <summary>
		/// Сервер заказов
		/// </summary>
		[EnumMember]
		ReservationServer = 3,

		/// <summary>
		/// Сервер логирования
		/// </summary>
		[EnumMember]
		LogServer = 4,

		/// <summary>
		/// Сервер настроек
		/// </summary>
		[EnumMember]
		SettingsServer = 5,

		/// <summary>
		/// Сервер оплаты
		/// </summary>
		[EnumMember]
		PaymentServer = 6,

		/// <summary>
		/// Админка
		/// </summary>
		[EnumMember]
		AdminServer = 7,

		/// <summary>
		/// Ротуинг сервера
		/// </summary>
		[EnumMember]
		RoutingServer = 8,

		/// <summary>
		/// Сервер ценообразования
		/// </summary>
		[EnumMember]
		PricingServer = 9,

		/// <summary>
		/// Авиа инвентори
		/// </summary>
		[EnumMember]
		AviaInventory = 10,

		/// <summary>
		/// Платёжный шлюз Депозит
		/// </summary>
		[EnumMember]
		Deposit = 11,

		/// <summary>
		/// Сервер статики
		/// </summary>
		[EnumMember]
		StaticServer = 12,

		/// <summary>
		/// Сервер тестирования
		/// </summary>
		[EnumMember]
		TestServer = 13,

		/// <summary>
		/// Сервер статистики
		/// </summary>
		[EnumMember]
		StatisticsServer = 14,

		/// <summary>
		/// Сервер отелей
		/// </summary>
		[EnumMember]
		HotelsServer = 15,

		/// <summary>
		/// Сервер авиабронирования #2
		/// </summary>
		[EnumMember]
		AviaServer2 = 21,

		/// <summary>
		/// Сервер фронтэнда
		/// </summary>
		[EnumMember]
		FrontendServer = 30,

		/// <summary>
		/// Сервер авиабронирования #3
		/// </summary>
		[EnumMember]
		AviaServer3 = 31,

		/// <summary>
		/// Поставщик услуги (ГДС)
		/// </summary>
		[EnumMember]
		Supplier = 33,

		/// <summary>
		///  Сервер Немо1 (php)
		/// </summary>
		[EnumMember]
		NemoOne = 34,

		/// <summary>
		/// Сервер авиабронирования #4
		/// </summary>
		[EnumMember]
		AviaServer4 = 41,

		/// <summary>
		/// Сервер онлайн регистрации
		/// </summary>
		[EnumMember]
		CheckInServer = 42,
	}

	/// <summary>
	/// Содержит описание типов запросов к серверу
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum RequestTypes
	{
		/// <summary>
		/// Пользовательский запрос
		/// </summary>
		[EnumMember]
		U = 0,
		/// <summary>
		/// Фоновый запрос
		/// </summary>
		[EnumMember]
		F = 1,
		/// <summary>
		/// Запрос по расписанию
		/// </summary>
		[EnumMember]
		S = 2,
		/// <summary>
		/// Немо-немо запрос, используется для защиты от рекурсивных вызовов
		/// </summary>
		[EnumMember]
		N = 3,
		/// <summary>
		/// PHP
		/// </summary>
		[EnumMember]
		P = 4,
		/// <summary>
		/// Callback
		/// </summary>
		[EnumMember]
		C = 5
	}

	/// <summary>
	/// Типы услуг на сервере заказов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ServiceType : byte
	{
		/// <summary>
		/// Авиа услуга (перелёт)
		/// </summary>
		[EnumMember]
		Avia = 0,
		/// <summary>
		/// Отель
		/// </summary>
		[EnumMember]
		Hotel = 1,
		/// <summary>
		/// ж/д услуга
		/// </summary>
		[EnumMember]
		Rail = 2,
		/// <summary>
		/// Прочая фигня неизвестного типа
		/// </summary>
		[EnumMember]
		Other = 33
	}

	/// <summary>
	/// Меры багаж в .нет Немо
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BaggageMeasure
	{
		[EnumMember]
		Kilograms = 0,
		[EnumMember]
		Pounds = 1,
		[EnumMember]
		Pieces = 2,
		[EnumMember]
		SpecialCharge = 3,
		[EnumMember]
		Size = 4,
		[EnumMember]
		ValueOfMeasure = 5,
		[EnumMember]
		Weight = 6
	}

	/// <summary>
	/// Единицы измерения времени
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum TimeUnit
	{
		[EnumMember]
		Millisecond = 0,
		[EnumMember]
		Second = 1,
		[EnumMember]
		Minute = 2,
		[EnumMember]
		Hour = 3,
		[EnumMember]
		Day = 4,
		[EnumMember]
		Week = 5,
		[EnumMember]
		Month = 6,
		[EnumMember]
		Year = 7
	}

	/// <summary>
	/// Типы питания по тарифу
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum MealType
	{
		/// <summary>
		/// Алкогольные напитки
		/// </summary>
		[EnumMember]
		AlcoholBeverages = 0,
		/// <summary>
		/// Неалкогольные напитки
		/// </summary>
		[EnumMember]
		Beverages = 1,
		/// <summary>
		/// Завтрак
		/// </summary>
		[EnumMember]
		Breakfast = 2,
		/// <summary>
		/// Холодная еда
		/// </summary>
		[EnumMember]
		ColdMeal = 3,
		/// <summary>
		/// Некий континентальный завтрак
		/// </summary>
		[EnumMember]
		ContinentalBreakfast = 4,
		/// <summary>
		/// Ужин
		/// </summary>
		[EnumMember]
		Dinner = 5,
		/// <summary>
		/// Горячая еда
		/// </summary>
		[EnumMember]
		HotMeal = 6,
		/// <summary>
		/// Обед
		/// </summary>
		[EnumMember]
		Lunch = 7,
		/// <summary>
		/// Еда (гениальный тип питания...)
		/// </summary>
		[EnumMember]
		Meal = 8,
		/// <summary>
		/// Полдник
		/// </summary>
		[EnumMember]
		Refreshment = 9,
		/// <summary>
		/// Перекус
		/// </summary>
		[EnumMember]
		Snack = 10
	}

	/// <summary>
	/// Возможные действия с ПНРом
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRPossibleAction
	{
		[EnumMember]
		Get = 0,
		/// <summary>
		/// Обновление информации о заказе
		/// </summary>
		[EnumMember]
		Update = 1,
		/// <summary>
		/// Оплатить заказ
		/// </summary>
		[EnumMember]
		PayFor = 2,
		/// <summary>
		/// Отменить заказ
		/// </summary>
		[EnumMember]
		Cancel = 3,
		/// <summary>
		/// Выписать заказ
		/// </summary>
		[EnumMember]
		Ticket = 4,
		/// <summary>
		/// Войдировать заказ
		/// </summary>
		[EnumMember]
		Void = 5,
		/// <summary>
		/// Возврат по заказу
		/// </summary>
		[EnumMember]
		Refund = 6,
		/// <summary>
		/// Разделение заказа
		/// </summary>
		[EnumMember]
		Split = 7,
		/// <summary>
		/// Модификация заказа
		/// </summary>
		[EnumMember]
		Modify = 8,
		/// <summary>
		/// Обработка платёжной транзакции
		/// </summary>
		[EnumMember]
		ProcessPayment = 9,
		/// <summary>
		/// Получение истории брони
		/// </summary>
		[EnumMember]
		GetHistory = 10,
		/// <summary>
		/// Обмен билетов
		/// </summary>
		[EnumMember]
		Exchange = 11,
		/// <summary>
		/// Завершение обменов
		/// </summary>
		[EnumMember]
		CompleteExchange = 12,
		/// <summary>
		/// Снятие мест
		/// </summary>
		[EnumMember]
		ReleaseSeat = 13,
		[EnumMember]
		IssueEMD = 14,
		[EnumMember]
		VoidEMD = 15,
		[EnumMember]
		RefundEMD = 16,
		/// <summary>
		/// Получение терминального вида ПНРа для брони
		/// </summary>
		[EnumMember]
		GetPNRTerminalView = 17,
		/// <summary>
		/// Получение маски электронного билета
		/// </summary>
		[EnumMember]
		GetEDData = 18,
		/// <summary>
		/// Доп операции с бронью
		/// </summary>
		[EnumMember]
		AdditionalOperations = 19,
	}

	/// <summary>
	/// Тип перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum FlightType
	{
		/// <summary>
		/// Регулярные рейсы
		/// </summary>
		[EnumMember]
		Regular = 0,
		/// <summary>
		/// Чартерные рейсы
		/// </summary>
		[EnumMember]
		Charter = 1,
		/// <summary>
		/// Бюджетный (Лоукост)
		/// </summary>
		[EnumMember]
		LowCost = 3
	}

	/// <summary>
	/// Место создания брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BookingPlace : byte
	{
		[EnumMember]
		UNKNOWN = 0
	}

	/// <summary>
	/// Типы данных в ПНРе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRDataItemType
	{
		/// <summary>
		/// SSR элемент
		/// </summary>
		[EnumMember]
		SSR = 0,
		/// <summary>
		/// Контактные данные
		/// </summary>
		[EnumMember]
		ContactInfo = 1,
		/// <summary>
		/// Форма оплаты
		/// </summary>
		[EnumMember]
		FOP = 2,
		/// <summary>
		/// Карточка участника программы лояльности
		/// </summary>
		[EnumMember]
		LoyaltyCard = 3,
		/// <summary>
		/// Time Limit информация
		/// </summary>
		[EnumMember]
		TL = 4,
		/// <summary>
		/// Electronic Document информация
		/// </summary>
		[EnumMember]
		ED = 5,
		/// <summary>
		/// Paper Document
		/// </summary>
		[EnumMember]
		PD = 6,
		/// <summary>
		/// Fare Endorsement
		/// </summary>
		[EnumMember]
		FE = 7,
		/// <summary>
		/// Ремарка
		/// </summary>
		[EnumMember]
		Remark = 8,
		/// <summary>
		/// Сумма кэша для проксируемого мультиФОПа
		/// </summary>
		[EnumMember]
		CashValueForMultiFOPProxing = 9,
		/// <summary>
		/// Комиссия (а/к)
		/// </summary>
		[EnumMember]
		Commission = 10,
		/// <summary>
		/// Информация об источнике брони
		/// </summary>
		[EnumMember]
		SourceInfo = 11,
		/// <summary>
		/// Идентификационный документ пассажира
		/// </summary>
		[EnumMember]
		IDDocument = 12,
		/// <summary>
		/// Спецпитание
		/// </summary>
		[EnumMember]
		Meal = 13,
		/// <summary>
		/// Виза
		/// </summary>
		[EnumMember]
		Visa = 14,
		/// <summary>
		/// Адрес пребывания
		/// </summary>
		[EnumMember]
		ArrivalAddress = 15,
		/// <summary>
		/// Тарифные правила брони
		/// </summary>
		[EnumMember]
		FareRules = 16,
		/// <summary>
		/// Забронированное место
		/// </summary>
		[EnumMember]
		BookedSeat = 17,
		/// <summary>
		/// ВП
		/// </summary>
		[EnumMember]
		ValidatingCompany = 18,
		/// <summary>
		/// Комиссия субагента
		/// </summary>
		[EnumMember]
		SubagentCommission = 19,
		[EnumMember]
		TicketDesignator = 20,
		[EnumMember]
		TourCode = 21,
		[EnumMember]
		Markup = 22,
		[EnumMember]
		TicketingProxy = 23,
		[EnumMember]
		CRMIntegration = 24,
		[EnumMember]
		Discount = 25,
		/// <summary>
		/// Уникальный код тарифа
		/// </summary>
		[EnumMember]
		FareSourceCode = 26,
		[EnumMember]
		EndUserData = 27,
		[EnumMember]
		TFBookData = 28,
		[EnumMember]
		SellingPointDescription = 29,
		[EnumMember]
		AdditionalLocators = 30,
		/// <summary>
		/// OSI - Other service information (Прочая служебная информация)
		/// </summary>
		[EnumMember]
		OSI = 31,
		/// <summary>
		/// Данные о связных бронях (родительской и дочерней)
		/// </summary>
		[EnumMember]
		ReferencedBooks = 32,
		/// <summary>
		/// Доп. инофрмация, распасенная из тарифных правил
		/// </summary>
		[EnumMember]
		FareInfo = 33,
		/// <summary>
		/// Документ-основание для скидки
		/// </summary>
		[EnumMember]
		DiscountDocument = 34,
		/// <summary>
		/// Voucher
		/// </summary>
		[EnumMember]
		VoucherFile = 35,
		/// <summary>
		/// Информация о связанных заказах
		/// </summary>
		[EnumMember]
		LinkedBooks = 36,
		/// <summary>
		/// Информация от поставщика
		/// </summary>
		[EnumMember]
		CustomSupplierData = 37,
		/// <summary>
		/// Содержит некие идентификаторы данного перелёта в системах поставщиков, необходимые для дальнейших операций с ним (бронирование или ещё что-то)
		/// </summary>
		SupplierLinkageInfo = 38
	}

	/// <summary>
	/// Типы ремарок
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRRemarkType
	{
		[EnumMember]
		General = 0,
		[EnumMember]
		Itinerary = 1,
		[EnumMember]
		Invoice = 2,
		[EnumMember]
		Historical = 3,
		[EnumMember]
		QueueControl = 4,
		[EnumMember]
		Vendor = 5,
		[EnumMember]
		NemoInternal = 6,
		[EnumMember]
		Confidential = 7,
		[EnumMember]
		MiniItinerary = 8,
		[EnumMember]
		YCategory = 9
	}

	/// <summary>
	/// Типы ФОПа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum FOPType
	{
		/// <summary>
		/// Кэш
		/// </summary>
		[EnumMember]
		CA = 0,
		/// <summary>
		/// Кредитка
		/// </summary>
		[EnumMember]
		CC = 1,
		/// <summary>
		/// Чек (банковский)
		/// </summary>
		[EnumMember]
		CK = 2,
		/// <summary>
		/// Инвойс
		/// </summary>
		[EnumMember]
		IN = 3,
		/// <summary>
		/// Взаимозачёт, добавлено по тикету #43253
		/// </summary>
		[EnumMember]
		VZ = 4,
		/// <summary>
		/// Токен
		/// </summary>
		[EnumMember]
		TC = 5,
		/// <summary>
		/// Аванс
		/// </summary>
		[EnumMember]
		AV = 6
	}

	/// <summary>
	/// Возможные типы эмитентов программ лояльности
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum LoyaltyCardOwnerType
	{
		[EnumMember]
		Airline = 0,
		[EnumMember]
		Agent = 1
	}

	/// <summary>
	/// Обобщённый статус забронированного сегмента
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRContentStatus
	{
		/// <summary>
		/// Подтверждён
		/// </summary>
		[EnumMember]
		Confirmed = 0,
		/// <summary>
		/// Необходимо подтверждение
		/// </summary>
		[EnumMember]
		NeedConfirmation = 1,
		/// <summary>
		/// Не подтверждён
		/// </summary>
		[EnumMember]
		NotConfirmed = 2,
		/// <summary>
		/// Отменён
		/// </summary>
		[EnumMember]
		Canceled = 3,
		/// <summary>
		/// Рейс на который была бронь в рамках данного сегмента вылетел
		/// </summary>
		[EnumMember]
		Flew = 4,
		/// <summary>
		/// Запрошен
		/// </summary>
		[EnumMember]
		OnRequest = 5,
		/// <summary>
		/// Отклонено
		/// </summary>
		[EnumMember]
		Rejected = 6
	}

	/// <summary>
	/// Тип электронного документа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum EDType
	{
		[EnumMember]
		Ticket = 0,
		[EnumMember]
		EMD = 1
	}

	/// <summary>
	/// Возможные статусы электронных документов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum EDStatus
	{
		[EnumMember]
		Active = 0,
		[EnumMember]
		Used = 1,
		[EnumMember]
		Voided = 2,
		[EnumMember]
		Refunded = 3,
		[EnumMember]
		Exchanged = 4,
		[EnumMember]
		SupplierDoNotKnowEdState = 5
	}

	/// <summary>
	/// Типы услуг, на которые применяется электронный документ
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum EDServiceType
	{
		/// <summary>
		/// Перелёт
		/// </summary>
		[EnumMember]
		Flight = 0,
		/// <summary>
		/// Допуслуги
		/// </summary>
		[EnumMember]
		Ancillary = 1,
		/// <summary>
		/// Оформление билета
		/// </summary>
		[EnumMember]
		TicketIssuance = 2,
		/// <summary>
		/// PENF EMD
		/// </summary>
		[EnumMember]
		Penalty = 3,
		/// <summary>
		/// RSVR EMD
		/// </summary>
		[EnumMember]
		ResidualValue = 4,
		/// <summary>
		/// Сборы
		/// </summary>
		[EnumMember]
		FinancialImpact = 5,
		/// <summary>
		/// Справка о возврате
		/// </summary>
		[EnumMember]
		RefundDocument = 6,
		/// <summary>
		/// Страховка/страховой полис
		/// </summary>
		[EnumMember]
		Insurance = 7,

	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum CouponStatus
	{
		[EnumMember]
		Open,
		[EnumMember]
		Used,
		[EnumMember]
		Void,
		[EnumMember]
		CheckIn,
		[EnumMember]
		Printed,
		[EnumMember]
		Refunded,
		[EnumMember]
		Exchanged,
		[EnumMember]
		Registered,
		[EnumMember]
		Landed,
		[EnumMember]
		Stoped,
		[EnumMember]
		PaperDocument,
		[EnumMember]
		Unavailable,
		[EnumMember]
		ExchangedToPaper,
		[EnumMember]
		Closed,
		[EnumMember]
		AirportControl
	}

	/// <summary>
	/// Типы бумажных документов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PDType
	{
		/// <summary>
		/// МК
		/// </summary>
		[EnumMember]
		ItinReceipt = 0,
		/// <summary>
		/// Текстовое представление ЕМД
		/// </summary>
		[EnumMember]
		EMD = 1,
		/// <summary>
		/// Сертификат на выписку билета для чартеров
		/// </summary>
		[EnumMember]
		TicketIssueCertificate = 2,
		/// <summary>
		/// Что-то другое
		/// </summary>
		[EnumMember]
		Other = 10
	}

	/// <summary>
	/// Тип тарифа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum TariffType
	{
		/// <summary>
		/// Публичный
		/// </summary>
		[EnumMember]
		Public = 0,
		/// <summary>
		/// Приватный по кат35
		/// </summary>
		[EnumMember]
		Cat35 = 1,
		/// <summary>
		/// Приватный по кат25 (аккаунт код или корпорейт ИД)
		/// </summary>
		[EnumMember]
		Cat25 = 2,
		/// <summary>
		/// Тариф, применяющийся в рамках турпакета.
		/// </summary>
		[EnumMember]
		InclusiveTour = 3,
		/// <summary>
		/// Тариф для продаж только с личного сайта а/к
		/// </summary>
		[EnumMember]
		PersonalCompanySite = 4,
		/// <summary>
		/// Все прочие приватные тарифы
		/// </summary>
		[EnumMember]
		Private = 5,
		[EnumMember]
		WebFare = 6
	}

	/// <summary>
	/// Содержит поддерживаемые типы группировки поисковой выдачи
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum SearchResultsGroupType
	{
		/// <summary>
		/// Простая группировка
		/// </summary>
		[EnumMember]
		Simple = 0,
		/// <summary>
		/// Продвинутая
		/// </summary>
		[EnumMember]
		Advanced = 1,
		/// <summary>
		/// Без группировки
		/// </summary>
		[EnumMember]
		None = 2
	}

	/// <summary>
	/// Возможные действия с контентом при его модификации
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PNRContentModifyAction
	{
		/// <summary>
		/// Добавление нового контента
		/// </summary>
		[EnumMember]
		Add = 0,
		/// <summary>
		/// Изменение имеющегося контента
		/// </summary>
		[EnumMember]
		Modify = 1,
		/// <summary>
		/// Удаление имеющегося контента
		/// </summary>
		[EnumMember]
		Remove = 2,
	}

	/// <summary>
	/// Типы возможных услуг обработки заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ProcessingServiceType
	{
		/// <summary>
		/// Создание
		/// </summary>
		[EnumMember]
		Creation = 0,
		/// <summary>
		/// Выписка и аналогичные действия у не_авиа услуг
		/// </summary>
		[EnumMember]
		Ticketing = 1,
		/// <summary>
		/// Оплата
		/// </summary>
		[EnumMember]
		Payment = 2,
		/// <summary>
		/// Обмен (билетов)
		/// </summary>
		[EnumMember]
		Exchange = 3,
		/// <summary>
		/// Возврат
		/// </summary>
		[EnumMember]
		Refund = 4,
		/// <summary>
		/// Модификация заказа
		/// </summary>
		[EnumMember]
		Modification = 5,
		/// <summary>
		/// Ануляция заказа
		/// </summary>
		[EnumMember]
		Cancellation = 6,
		/// <summary>
		/// Прочее
		/// </summary>
		[EnumMember]
		Other = 30
	}

	/// <summary>
	/// Статус услуг по обработке заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ProcessingServiceStatus
	{
		/// <summary>
		/// Запрошено
		/// </summary>
		[EnumMember]
		Requested = 0,
		/// <summary>
		/// Выполнено
		/// </summary>
		[EnumMember]
		Executed = 1,
		/// <summary>
		/// Отклонено
		/// </summary>
		[EnumMember]
		Rejected = 2
	}

	/// <summary>
	/// Поставщики услуги страхования
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum InsuranceVendor
	{
		/// <summary>
		/// Альфастрахование
		/// </summary>
		[EnumMember]
		AlphaInsurance = 0
	}

	/// <summary>
	/// Возможные дейсвия с транзакцией
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PaymentTransactionAction
	{
		/// <summary>
		/// Отмена транзакции (пользователем)
		/// </summary>
		[EnumMember]
		Cancel = 0,
		/// <summary>
		/// Списание средств по транзакции
		/// </summary>
		[EnumMember]
		Confirm = 1,
		/// <summary>
		/// Транзакция отклонена ПШ
		/// </summary>
		[EnumMember]
		Reject = 2,
		/// <summary>
		/// Возврат уже списанных денег
		/// </summary>
		[EnumMember]
		Refund = 3,
	}

	/// <summary>
	/// Статус оплаты заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum OrderPaymentStatus
	{
		/// <summary>
		/// Не оплачен
		/// </summary>
		[EnumMember]
		NotPaid = 0,
		/// <summary>
		/// Оплачен (полностью)
		/// </summary>
		[EnumMember]
		Paid = 1,
		/// <summary>
		/// Частично оплачен
		/// </summary>
		[EnumMember]
		PartPaid = 2
	}

	/// <summary>
	/// Тип заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum OrderType
	{
		/// <summary>
		/// Онлайн заказ, содержит только онлайн услуги
		/// </summary>
		[EnumMember]
		Online = 0,
		/// <summary>
		/// Оффлайн заказ, содержит только оффлайн услуги
		/// </summary>
		[EnumMember]
		Offline = 1,
		/// <summary>
		/// Смешанный, содержит как оффлайн, так и онлайн услуги
		/// </summary>
		[EnumMember]
		Mixed = 2
	}

	/// <summary>
	/// Типы групп услуг
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ServiceGroupType
	{
		/// <summary>
		/// Услуги представляются собой единую бронь у поставщика
		/// </summary>
		[EnumMember]
		SingleBook = 0,
		/// <summary>
		/// МультиOW перелёт
		/// </summary>
		[EnumMember]
		MultiOW = 1
	}

	/// <summary>
	/// Конкретизирующий подстатус заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum OrderSubStatus
	{
		/// <summary>
		/// Есть услуга с проблемным статусом
		/// </summary>
		[EnumMember]
		ProblematicService = 0,
		/// <summary>
		/// Неотменённый заказ содержит отменённую услугу
		/// </summary>
		[EnumMember]
		ContainsCanceledService = 1,
		/// <summary>
		/// Используется частичная выписка, часть услуг выписана
		/// </summary>
		[EnumMember]
		PartialTicketing = 2,
		/// <summary>
		/// Заказ полностью оплачен, но при этом есть проинициализированные транзакции
		/// </summary>
		[EnumMember]
		HasUnfinishedPaymentTransaction = 3,
		/// <summary>
		/// Не удалось подтверждение одной из транзакций
		/// </summary>
		[EnumMember]
		PaymentConfirmationFailed = 4,
		/// <summary>
		/// Не удалось выписать одну из услуг
		/// </summary>
		[EnumMember]
		TicketingFailed = 5
	}

	/// <summary>
	/// Версия движка бронирования
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum OrderEngineVersion
	{
		[EnumMember]
		NEMO_NET = 0,
		[EnumMember]
		NEMO_PHP = 1
	}

	/// <summary>
	/// Каналы продажи
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum SalesChannel
	{
		[EnumMember]
		Meta = 0,
		[EnumMember]
		API = 1,
		[EnumMember]
		AgentSite = 2
	}

	/// <summary>
	/// Тип источника курса валюты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum CurrencyRateSource
	{
		[EnumMember]
		IATA = 0,
		[EnumMember]
		Agency = 0,
		[EnumMember]
		Manual = 0,
		[EnumMember]
		NBU = 0,
		[EnumMember]
		SBER = 0,
	}

	/// <summary>
	/// Тип тур кода
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum TourCodeType
	{
		/// <summary>
		/// Дефолтное внесение в ПНР
		/// </summary>
		[EnumMember]
		Default = 0,
		/// <summary>
		/// Исключение из печати на билете
		/// </summary>
		[EnumMember]
		Unprintable = 1,
		[EnumMember]
		InclusiveTour = 2,
		[EnumMember]
		BulkTour = 3,
		[EnumMember]
		BSPInclusiveTour = 4
	}

	/// <summary>
	/// <summary>
	/// Тип искомой цены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PriceRefundType
	{
		[EnumMember]
		AnyLowest = 0,
		[EnumMember]
		Refundable = 1,
		[EnumMember]
		Both = 2
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum Language
	{
		[EnumMember]
		en = 0,
		[EnumMember]
		ru = 1,
	}

	/// <summary>
	/// Название очереди
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum QueueName
	{
		/// <summary>
		/// Общая очередь
		/// </summary>
		[EnumMember]
		GeneralQueue = 0,
		/// <summary>
		/// Очередь с изменениями в расписании
		/// </summary>
		[EnumMember]
		ScheduleChanged = 1,
		/// <summary>
		/// Очередь с добавленными билетами
		/// </summary>
		[EnumMember]
		TicketsAdded = 2,
		/// <summary>
		/// Очередь с отменённыи сегментами
		/// </summary>
		[EnumMember]
		SegmentsCancelled = 3,
		/// <summary>
		/// Очередь с неподтверждёнными сегментами
		/// </summary>
		[EnumMember]
		UnconfirmedSegments = 4,
		/// <summary>
		/// Очередь ожидания подтверждения
		/// </summary>
		[EnumMember]
		WaitingConfirmation = 5,
		/// <summary>
		/// Очередь с изменениями в SSR
		/// </summary>
		[EnumMember]
		ServiceInfoChanged = 6,
		/// <summary>
		/// Очередь с истекающими ТЛ
		/// </summary>
		[EnumMember]
		TimeLimit = 7,
		/// <summary>
		/// Бронирования с ремарками от авиакомпаний
		/// </summary>
		[EnumMember]
		VendorRemarks = 8,


		//Далее имена внутренних очередей (аналогичны подстатусам брони, когда основной статус проблематичный)
		/// <summary>
		/// Невалидный статус сегмента
		/// </summary>
		[EnumMember]
		InvalidSegmentStatus = 30,
		/// <summary>
		/// Один из сегментов имеет валидный статус, который требуется сменить на HK (к примеру ТК статус)
		/// </summary>
		[EnumMember]
		SegmentStatusForManualConfirmation = 31,
		/// <summary>
		/// Есть выписанные билеты, однако в ПНРе их нет
		/// </summary>
		[EnumMember]
		HaveNotStoredTickets = 32,
		/// <summary>
		/// Статус билет в ПНРе и аудит репорте не совпадают
		/// </summary>
		[EnumMember]
		NotActualTicketStatus = 33,
		/// <summary>
		/// Слетел тариф, специфика Галилео
		/// </summary>
		[EnumMember]
		NoValidFare = 34,
		/// <summary>
		/// Данные о провойдированных билетах не были удалены из ПНРа. Специфика Амадеуса
		/// </summary>
		[EnumMember]
		UnremovedVoidedTicketElements = 35,
		/// <summary>
		/// Специфичная ситуация в Сирене при оплате через их ПШ, может быть ситуация что бронь уже оплатилась, но ещё билеты не выписались, в этом случае ничего с бронь делать нельзя
		/// </summary>
		[EnumMember]
		PaidBook = 36,
		/// <summary>
		/// Ошибка при актуализации цены
		/// </summary>
		[EnumMember]
		FailedToActualizePrice = 37,
		/// <summary>
		/// Ошибка "выписки" в ТФ
		/// </summary>
		[EnumMember]
		TicketingFailed = 38,
		/// <summary>
		/// Специфичная ситуация с младенцами без места, требуется ручная обработка
		/// </summary>
		[EnumMember]
		UnconfirmedInfant = 39,
		/// <summary>
		/// Данная бронь дублирует другую (специфика ТФ)
		/// </summary>
		[EnumMember]
		DuplicateBooking = 40,
		/// <summary>
		/// Статус брони не подтверждён (специфика ТФ)
		/// </summary>
		[EnumMember]
		UnconfirmedBooking = 41,
		/// <summary>
		/// Необходимо вернуть RSVR EMD
		/// </summary>
		[EnumMember]
		NeedRefundRSVR = 42,
		/// <summary>
		/// Ошибка при возврате RSVR EMD
		/// </summary>
		[EnumMember]
		FailedRefundRSVR = 43,
		/// <summary>
		/// Ошибка при обмене
		/// </summary>
		[EnumMember]
		FailedExchange = 44,
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BanType
	{
		/// <summary>
		/// Превышено ограничение на количество поисков
		/// </summary>
		[EnumMember]
		SearchesLimit,
		/// <summary>
		/// Превышено ограничение на количества поисков к одной выписке
		/// </summary>
		[EnumMember]
		SearchesPerTicketLimit
	}

	///
	/// Тип коммиссии для ценовых правил Nemo
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum CommissionType
	{
		/// <summary>
		/// Деньги
		/// </summary>
		[EnumMember]
		Money,
		/// <summary>
		/// Процент от тарифа
		/// </summary>
		[EnumMember]
		Percent
	}

	/// <summary>
	/// платежные системы
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PaymentSystem
	{
		[EnumMember]
		JapanCreditBureau,
		[EnumMember]
		ElectronicCash,
		[EnumMember]
		MasterCardDebit,
		[EnumMember]
		VisaDelta,
		[EnumMember]
		Visa,
		[EnumMember]
		UniversalAirTravelPlan,
		[EnumMember]
		DiscoverCard,
		[EnumMember]
		DinersClub,
		[EnumMember]
		AmericanExpress,
		[EnumMember]
		MasterCard,
		[EnumMember]
		VisaElectron,
		[EnumMember]
		Maestro,
		[EnumMember]
		EasyJetElectron,
		[EnumMember]
		CarteBlanche,
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum GuaranteeType
	{
		[EnumMember]
		Prepayment,
		[EnumMember]
		Deposit,
		[EnumMember]
		Credit,
		[EnumMember]
		Cash,
		[EnumMember]
		Guarantee,
		[EnumMember]
		IataGuarantee,
		[EnumMember]
		Other,
	}

	/// Тип кэша для перезагрузки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum CacheType
	{
		/// <summary>
		/// Авиакомпании (iata/tf)
		/// </summary>
		[EnumMember]
		Airlines,
		/// <summary>
		/// Аэропорты/города
		/// </summary>
		[EnumMember]
		Airports,
		/// <summary>
		/// Страны
		/// </summary>
		[EnumMember]
		Countries,
		/// <summary>
		/// Семейства тарифов
		/// </summary>
		[EnumMember]
		FFamilies,
		/// <summary>
		/// Партнерство а/к по карточкам лояльности
		/// </summary>
		[EnumMember]
		FFPPartnership,
		/// <summary>
		/// Города
		/// </summary>
		[EnumMember]
		Cities,
		/// <summary>
		/// Классы бронирования
		/// </summary>
		[EnumMember]
		Classes,
		/// <summary>
		/// Временные зоны
		/// </summary>
		[EnumMember]
		Timezones,
		[EnumMember]
		SubsidizedTariffs,
		/// <summary>
		/// Дополнительные услуги
		/// </summary>
		[EnumMember]
		AncillaryServices
	}

	/// <summary>
	/// Действие с перелетом
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum FlightOperation
	{
		/// <summary>
		/// Проверка доступности перелёта
		/// </summary>
		[EnumMember]
		CheckFlightAvailability = 0,
		/// <summary>
		/// Получение актуальной цены перелета
		/// </summary>
		[EnumMember]
		GetFlightPrice = 1,
		/// <summary>
		/// Актуализация перелёта
		/// </summary>
		[EnumMember]
		ActualizeFlight = 2,
		/// <summary>
		/// Бронирование перелета
		/// </summary>
		[EnumMember]
		BookFlight = 3,
		/// <summary>
		/// Репрайсинг перелета
		/// </summary>
		[EnumMember]
		FlightRepricing = 4,
	}

	/// <summary>
	/// Информация о наличии мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum HotelProductAvailability
	{
		[EnumMember]
		FreeSale,
		[EnumMember]
		OnRequest
	}

	/// <summary>
	/// Коды типов документов, которые могут быть основанием для скидки. Взято из справочника Сирены
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum DiscountDocumentType
	{
		/// <summary>
		/// СПРАВКА ИЗ РОДДОМА
		/// </summary>
		[EnumMember]
		SPR = 0,
		/// <summary>
		/// УДОСТ ДЕПУТАТА ГОС ДУМЫ ФЕДЕРАЛЬНОГО СОБРАНИЯ РФ
		/// </summary>
		[EnumMember]
		GD = 1,
		/// <summary>
		/// КОМАНДИРОВОЧНОЕ УДОСТОВЕРЕНИЕ
		/// </summary>
		[EnumMember]
		KU = 2,
		/// <summary>
		/// СЛ ТРЕБ ДЛЯ РАБОТН ГА А ТАКЖЕ ДРУГОГО ПРЕДПРИЯТ
		/// </summary>
		[EnumMember]
		ST = 3,
		/// <summary>
		/// ГОДОВОЙ СЛУЖ БИЛЕТ ДЛЯ РАБОТН ГА И ДР ПРЕДПРИЯТ
		/// </summary>
		[EnumMember]
		GB = 4,
		/// <summary>
		/// СВИДЕТЕЛЬСТВО О СМЕРТИ
		/// </summary>
		[EnumMember]
		SS = 5,
		/// <summary>
		/// НАПРАВЛЕНИЕ НА ЛЕЧЕНИЕ
		/// </summary>
		[EnumMember]
		NL = 6,
		/// <summary>
		/// СПРАВКА МЕДИКО СОЦИАЛЬНОЙ ЭКСПЕРТИЗЫ
		/// </summary>
		[EnumMember]
		MV = 7,
		/// <summary>
		/// МЕДИЦИНСКАЯ СПРАВКА
		/// </summary>
		[EnumMember]
		MD = 8,
		/// <summary>
		/// УДОСТОВЕРЕНИЕ ИНВАЛИДА
		/// </summary>
		[EnumMember]
		UI = 9,
		/// <summary>
		/// СПР О ПРАВЕ РЕБ ИНВ НА ЛГ ВЫДАН ОРГАНОМ СОЦ ЗАЩИТЫ
		/// </summary>
		[EnumMember]
		SI = 10,
		/// <summary>
		/// СЛУЖЕБНОЕ УДОСТ ИЛИ ДР ДОКУМ УДОСТ ПРОФ ПРИНАДЛЕЖН
		/// </summary>
		[EnumMember]
		SU = 11,
		/// <summary>
		/// РАЗРЕШ РУКОВОД АП НА ПЕРЕВОЗ БЕСПЛАТ ИЛИ СО СКИДК
		/// </summary>
		[EnumMember]
		RZ = 12,
		/// <summary>
		/// ДОК ПОДТВЕРЖД ЧЛЕНСТВО В КЛУБЕ АССОЦИАЦ ОРГАНИЗАЦ
		/// </summary>
		[EnumMember]
		CL = 13,
		/// <summary>
		/// ДОК ПОДТВЕРЖДАЮЩИЙ ЗВАНИЕ И НАГРАДЫ ПАССАЖИРА
		/// </summary>
		[EnumMember]
		PZ = 14,
		/// <summary>
		/// СВИДЕТЕЛЬСТВО О БРАКЕ
		/// </summary>
		[EnumMember]
		BR = 15,
		/// <summary>
		/// СПРАВКА ИЗ ШКОЛЫ
		/// </summary>
		[EnumMember]
		SK = 16,
		/// <summary>
		/// УЧЕНИЧЕСКИЙ БИЛЕТ
		/// </summary>
		[EnumMember]
		UB = 17,
		/// <summary>
		/// СТУДЕНЧЕСКИЙ БИЛЕТ
		/// </summary>
		[EnumMember]
		SB = 17,
		/// <summary>
		/// ПЕНСИОННОЕ УДОСТОВЕРЕНИЕ
		/// </summary>
		[EnumMember]
		PU = 17,
		/// <summary>
		/// УДОСТ ЛИЧНОСТИ ДЛЯ ВОЕННОСЛ ОФИЦЕР ПРАПОРЩ МИЧМААН
		/// </summary>
		[EnumMember]
		UL = 18,
		/// <summary>
		/// УДОСТ СУДЬИ КОНСТИТУЦИОННОГО СУДА
		/// </summary>
		[EnumMember]
		KS = 19,
		/// <summary>
		/// УДОСТ ДЕПУТАТА МЕСТНЫХ ЗАКОНОДАТЕЛЬНЫХ ОРГАНОВ
		/// </summary>
		[EnumMember]
		DM = 20,
		/// <summary>
		/// УДОСТ ЧЛЕНА СОВЕТА ФЕДЕРАЦИИ ФЕДЕРАЛЬН СОБРАН РФ
		/// </summary>
		[EnumMember]
		SF = 21,
		/// <summary>
		/// СВОБОДНЫЙ ТЕКСТ
		/// </summary>
		[EnumMember]
		NS = 22,
		/// <summary>
		/// КОД НАГРАДЫ
		/// </summary>
		[EnumMember]
		CN = 23
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum PaymentProxySystem
	{
		[EnumMember]
		FCm
	}

	/// <summary>
	/// Условия применения какого-либо правила из тарифных правил
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum FareRuleApplicationCondition
	{
		/// <summary>
		/// Разрешено всегда
		/// </summary>
		[EnumMember]
		Ever = 0,
		/// <summary>
		/// Запрещено всегда
		/// </summary>
		[EnumMember]
		Never = 1,
		/// <summary>
		/// Разрешено, кроме некоторых случаев
		/// </summary>
		[EnumMember]
		EverWithRestrictions = 2
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum ChargeType
	{
		/// <summary>
		/// Сбор по правилу
		/// </summary>
		[EnumMember]
		PriceRule,
		/// <summary>
		/// Округление цены в валюте агентсва
		/// </summary>
		[EnumMember]
		FareRound,
		/// <summary>
		/// Округление такс в валюте агентства
		/// </summary>
		[EnumMember]
		TaxRound,
		/// <summary>
		/// Округление итогового сбора
		/// </summary>
		[EnumMember]
		MarkupRound
	}

	[DataContract]
	public enum SupplierData
	{
		/// <summary>
		/// Id транзакции
		/// </summary>
		[EnumMember]
		KiwiTransactionId = 0,
	}

	/// <summary>
	/// Поддерживаемые сервером Ж/Д поставщики
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Rail", Name = "Service")]
	public enum RailSuppliers
	{
		/// <summary>
		/// УФС
		/// </summary>
		[EnumMember]
		UFS = 0,
		/// <summary>
		/// ж/д Украины (Универсальные Информационные Технологии)
		/// </summary>
		[EnumMember]
		UIT = 1,
		/// <summary>
		/// Сирена
		/// </summary>
		[EnumMember]
		Sirena = 2,
		/// <summary>
		/// КТЖ
		/// </summary>
		[EnumMember]
		KTZ = 3,
		/// <summary>
		/// УЖД
		/// </summary>
		[EnumMember]
		UZHD = 4,
	}

	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum AviaMixerPriceCondition
	{
		[EnumMember]
		MinimalNet,
		[EnumMember]
		MinimalPrice,
		[EnumMember]
		MaximalPrice,
		[EnumMember]
		MaximalAgencyMarkup,
		[EnumMember]
		MaximalAirlineCommission,
		[EnumMember]
		MaximalProfit,
		[EnumMember]
		Ignore
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum SsrStatus
	{
		Confirmed = 0,

		NeedConfirmation = 1,

		NotConfirmed = 2,

		Canceled = 3,

		Flew = 4,

		OnRequest = 5,

		Rejected = 6
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum CheckInStatus
	{
		/// <summary>
		/// Неопределенный
		/// </summary>
		[EnumMember]
		Undefined = 0,

		/// <summary>
		/// Зарегестрирован
		/// </summary>
		[EnumMember]
		CheckedIn = 1,

		/// <summary>
		/// Не зарегестрирован
		/// </summary>
		[EnumMember]
		NotCheckedIn = 2,

		/// <summary>
		/// Ожидает посадки на рейс
		/// </summary>
		[EnumMember]
		StandBy = 3,

		/// <summary>
		/// Посадка на рейс
		/// </summary>
		[EnumMember]
		Boarded = 4
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum GlobalSuppliers
	{
		[EnumMember]
		DcsAstra = 1,

		[EnumMember]
		DcsSita = 2,

		[EnumMember]
		NemoConnectAvia = 3,

		[EnumMember]
		Sirena = 4,

		[EnumMember]
		SITAGabriel = 5,
	}

	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum BoardingPassFormatType
	{
		/// <summary>
		/// поток байт в формате base64 с указанием типа документа, например pdf
		/// </summary>
		[EnumMember]
		Base64 = 0,

		/// <summary>
		/// структурированный набор данных-параметров
		/// </summary>
		[EnumMember]
		Params = 1,

	}
	
	/// <summary>
	/// Типы допустимых багажей
	/// </summary>
	public enum BaggageTypes
	{
		FreeBaggage, // бесплатный багаж
		CarryOnBaggage, // ручная кладь
	}

	/// <summary>
	/// Типы допустимых категорий багажей
	/// </summary>
	public enum BaggageCategories
	{
		CheckedBaggage,
		CarryOnBaggage,
	}

	[DataContract(Namespace = "http://nemo.travel/STL")]
	public enum BackgroundBookOperationSearchType
	{
		[EnumMember]
		AfterTicketingRebookAndPriceChange
	}

	[DataContract(Namespace = "http://nemo.travel/STL")]
	public enum BackgroundBookOperationSearchStatus
	{
		[EnumMember]
		InProcess,
		[EnumMember]
		Finished,
	}


	public class EnumUtils
	{
		public static T ParseEnumFromString<T>(string value) where T : struct
		{
			T result;
			if (!Enum.TryParse<T>(value, out result))
			{
				throw new ArgumentException("Unknown enum value");
			}
			return result;
		}
	}


	[DataContract(Namespace = "http://nemo.travel/STL")]
	public enum CheckInSubStatus : byte
	{
		/// <summary>
		/// Неопределенный
		/// </summary>
		[EnumMember]
		Undefined = 0,

		/// <summary>
		/// Регистрация на рейс доступна только в аэропорту
		/// </summary>
		[EnumMember]
		OnlyAirportCheckIn = 1,

		/// <summary>
		/// Отсутствуют обязательные данные документов пассажира
		/// </summary>
		[EnumMember]
		NeedDocument = 2,

		/// <summary>
		/// Отсутствуют данные о визе
		/// </summary>
		[EnumMember]
		NeedVisaDocument = 3,

		/// <summary>
		/// Билет на пассажира ещё не оформлен
		/// </summary>
		[EnumMember]
		NeedTicketing = 4
	}
}