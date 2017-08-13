using System.Runtime.Serialization;

namespace AviaEntities
{
	/// <summary>
	/// Тип приватности тарифа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum FareTypes
	{
		/// <summary>
		/// Публичный (не приватный тариф)
		/// </summary>
		[EnumMember]
		Public = 0,
		/// <summary>
		/// Тариф, полученный через corporate ID / account code / тур кода и т.д.
		/// </summary>
		[EnumMember]
		Coded = 1,
		/// <summary>
		/// Категория 35, они же договорные тарифы.
		/// ВАЖНО! Если тариф имеет данный тип, то модификация комиссии недопустима
		/// </summary>
		[EnumMember]
		Cat35 = 2,
		/// <summary>
		/// Тарифы "неподходящие для выписки в кат35". Не особо понятно что это, но такой тип есть в Сэйбре (дословно из документации "Ticketing ineligible Category 35 fares")
		/// </summary>
		[EnumMember]
		NonCat35 = 3,
		/// <summary>
		/// Все прочие приватные тарифы
		/// </summary>
		[EnumMember]
		Private = 4,
		/// <summary>
		/// IT (Inclusive Tour) тариф
		/// </summary>
		[EnumMember]
		InclusiveTour = 5,
		[EnumMember]
		WebFare = 6
	}

	/// <summary>
	/// Поддерживаемые типы поиска
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum SearchType
	{
		/// <summary>
		/// Амадеус
		/// </summary>
		[EnumMember]
		Amadeus = 0,
		/// <summary>
		/// Галилео
		/// </summary>
		[EnumMember]
		Galileo = 1,
		/// <summary>
		/// Sabre BFM
		/// </summary>
		[EnumMember]
		BFM = 2,
		/// <summary>
		/// Sabre LFS
		/// </summary>
		[EnumMember]
		LFS = 3,
		/// <summary>
		/// Сирена2000
		/// </summary>
		[EnumMember]
		Sirena = 4,
		/// <summary>
		/// SITA Gabriel
		/// </summary>
		[EnumMember]
		SITAGabriel = 5,
		/// <summary>
		/// SpecialFares
		/// </summary>
		[EnumMember]
		SpecialFares = 6,
		/// <summary>
		/// ВИПСервис
		/// </summary>
		[EnumMember]
		VIPService = 7
	}

	/// <summary>
	/// Список возможных положений места в самолетё в ряду
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum SeatingPlaceLocation
	{
		/// <summary>
		/// у окна (Window)
		/// </summary>
		[EnumMember]
		W = 0,
		/// <summary>
		/// где-то в середине ряда (Middle)
		/// </summary>
		[EnumMember]
		M = 1,
		/// <summary>
		/// возле прохода (NearPassengerWay)
		/// </summary>
		[EnumMember]
		NPW = 2,
		/// <summary>
		/// нет предпочтения (NotSpecified)
		/// </summary>
		[EnumMember]
		NS = 3
	}

	/// <summary>
	/// Список возможного спец питания
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum MealTypes
	{
		/// <summary>
		/// Отсутствует
		/// </summary>
		//[EnumMember]
		//NONE = 0,
		/// <summary>
		/// Азиатская вегетарианская кухня
		/// </summary>
		[EnumMember]
		AVML = 1,
		/// <summary>
		/// Блюда щадящей диеты
		/// </summary>
		[EnumMember]
		BLML = 3,
		/// <summary>
		/// Детское питание
		/// </summary>
		[EnumMember]
		CHML = 4,
		/// <summary>
		/// Детский холодный завтрак
		/// </summary>
		[EnumMember]
		CHPC = 5,
		/// <summary>
		/// Детский горячий завтрак
		/// </summary>
		[EnumMember]
		CHCC = 6,
		/// <summary>
		/// Детский ланч, ветчина и сыр
		/// </summary>
		[EnumMember]
		CHHC = 7,
		/// <summary>
		/// Детский ланч, ореховое масло
		/// </summary>
		[EnumMember]
		PBJS = 8,
		/// <summary>
		/// Детский обед макароны с сыром
		/// </summary>
		[EnumMember]
		CHMC = 9,
		/// <summary>
		/// Диабетическое питание
		/// </summary>
		[EnumMember]
		DBML = 10,
		/// <summary>
		/// Фрукты
		/// </summary>
		[EnumMember]
		FPML = 11,
		/// <summary>
		/// Питание без клейковины
		/// </summary>
		[EnumMember]
		GFML = 12,
		/// <summary>
		/// Питание богатое клетчаткой
		/// </summary>
		[EnumMember]
		HFML = 13,
		/// <summary>
		/// Индусская кухня
		/// </summary>
		[EnumMember]
		HNML = 14,
		/// <summary>
		/// Питание для младенцев
		/// </summary>
		[EnumMember]
		BBML = 15,
		/// <summary>
		/// Кошерная кухня
		/// </summary>
		[EnumMember]
		KSML = 16,
		/// <summary>
		/// Кошерный завтрак
		/// </summary>
		[EnumMember]
		SMKB = 17,
		/// <summary>
		/// Кошерный ланч
		/// </summary>
		[EnumMember]
		SMKL = 18,
		/// <summary>
		/// Кошерный обед
		/// </summary>
		[EnumMember]
		SMKD = 19,
		/// <summary>
		/// Малобелковое питание
		/// </summary>
		[EnumMember]
		LPML = 20,
		/// <summary>
		/// Низкокалорийное питание
		/// </summary>
		[EnumMember]
		LCML = 21,
		/// <summary>
		/// Низкохолестериновое питание
		/// </summary>
		[EnumMember]
		LFML = 22,
		/// <summary>
		/// Низкопуриновое питание
		/// </summary>
		[EnumMember]
		PRML = 23,
		/// <summary>
		/// Малосоленое питание
		/// </summary>
		[EnumMember]
		LSML = 24,
		/// <summary>
		/// Мюсли
		/// </summary>
		[EnumMember]
		MOML = 25,
		/// <summary>
		/// Безмолочные продукты
		/// </summary>
		[EnumMember]
		NLML = 26,
		/// <summary>
		/// Восточная кухня
		/// </summary>
		[EnumMember]
		ORML = 27,
		/// <summary>
		/// Сырые овощи
		/// </summary>
		[EnumMember]
		RVML = 28,
		/// <summary>
		/// Морепродукты
		/// </summary>
		[EnumMember]
		SFML = 29,
		/// <summary>
		/// Особое питание
		/// </summary>
		[EnumMember]
		SPML = 30,
		/// <summary>
		/// Вегетарианское, молоко и яйца
		/// </summary>
		[EnumMember]
		VLML = 31,
		/// <summary>
		/// Строго вегетарианское питание
		/// </summary>
		[EnumMember]
		VGML = 32,
		/// <summary>
		/// Джайнизское вегетарианское
		/// </summary>
		[EnumMember]
		VJML = 33,
		/// <summary>
		/// Восточное вегетарианское питание
		/// </summary>
		[EnumMember]
		VOML = 34
	}

	/// <summary>
	/// Дейтсвие при добавлении уже существующих данных в ПНР
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum AddInformationConflictResolving
	{
		/// <summary>
		/// Не добавлять существующие данный, вернуть ворнинг об этом
		/// </summary>
		[EnumMember]
		ReturnWarning = 0,
		/// <summary>
		/// Остановить операцию добавления, вернуть ошибку
		/// </summary>
		[EnumMember]
		ReturnError = 1
	}

	/// <summary>
	/// Тип оплаты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum PaymentType
	{
		/// <summary>
		/// Наличные деньги
		/// </summary>
		[EnumMember]
		Cash = 0,
		/// <summary>
		/// Кредитная карточка
		/// </summary>
		[EnumMember]
		CreditCard = 1,
		/// <summary>
		/// Счёт-фактура (предположительно).
		/// Согласно найденному описанию в англ Википедии это что-то типа долгового обязательства.
		/// </summary>
		[EnumMember]
		Invoice = 2,
		/// <summary>
		/// Чек (банковский)
		/// </summary>
		[EnumMember]
		Check = 3,
		/// <summary>
		/// МультиФОП, кредитка+наличка
		/// </summary>
		[EnumMember]
		Mixed_CreditCard_Cash = 4
	}

	/// <summary>
	/// Методы сжатия результатов поиска при сохранении в БД
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum CompressionMethod
	{
		/// <summary>
		/// Без сжатия
		/// </summary>
		[EnumMember]
		NoCompression = 0,
		/// <summary>
		/// 7z сжатие
		/// </summary>
		[EnumMember]
		_7z = 1,
		/// <summary>
		/// GZip сжатие
		/// </summary>
		[EnumMember]
		GZip = 2
	}

	/// <summary>
	/// Возможные дополнительные операции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public enum AdditionalOperation
	{
		/// <summary>
		/// Проверка доступности перелёта
		/// </summary>
		[EnumMember]
		CheckAvailability = 0,
		/// <summary>
		/// Получение тарифных правил
		/// </summary>
		[EnumMember]
		GetFareRules = 1,
		/// <summary>
		/// Получение карты мест
		/// </summary>
		[EnumMember]
		GetSeatMap = 2,
		/// <summary>
		/// Получение актуальной цены
		/// </summary>
		[EnumMember]
		GetPrice = 3,
		/// <summary>
		/// Получение списка доступных допуслуг
		/// </summary>
		[EnumMember]
		SearchAncillaryServices = 4,
		/// <summary>
		/// Получение списка кредитных карт, которыми можно оплатить бронь перелёта
		/// </summary>
		[EnumMember]
		GetAllowedCCs = 5,
		/// <summary>
		/// Получение информации о допустимых карточках лояльности
		/// </summary>
		[EnumMember]
		GetAllowedLoyaltyCards = 6,
		/// <summary>
		/// Актуализация перелёта
		/// </summary>
		[EnumMember]
		ActualizeFlight = 7,
		/// <summary>
		/// Получение списка тарифов по семействам
		/// </summary>
		[EnumMember]
		GetFareFamilies = 8,
		/// <summary>
		/// Репрайсинг перелёта
		/// </summary>
		[EnumMember]
		FlightRepricing = 9,
		/// <summary>
		/// Получение субсидированных тарифов
		/// </summary>
		[EnumMember]
		GetSubsidizedTariffs = 10
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
}