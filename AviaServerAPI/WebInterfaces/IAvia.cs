using AviaEntities.ImportBook;
using AviaEntities.ScheduleSearch;
using GeneralEntities;
using System.ServiceModel;

namespace AviaServerAPI
{
	[ServiceContract(Namespace = "http://nemo-ibe.com/Avia")]
	public interface IAvia
	{
		#region АПИ версии 1.0

		/// <summary>
		/// Получение тарифных правил для перелёта
		/// </summary>
		/// <param name="Request">Запрос на поиск тарифных правил</param>
		/// <returns>Результат поиска тарифных правил</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.RulesSearch.RulesSearchRSBody> GetFareRules(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request);

		/// <summary>
		/// Проверка доступности перелёта для бронирования
		/// </summary>
		/// <param name="Request">Запрос на проверку доступности перелёта</param>
		/// <returns>Результат проверки доступности перелёта</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.AirAvail.AirAvailRSBody> CheckFlightAvailability(Request<AviaEntities.AirAvail.AirAvailRQBody> Request);

		/// <summary>
		/// Поиск карты мест перелёта
		/// </summary>
		/// <param name="Request">Запрос на поиск карты перелёта</param>
		/// <returns>Результат поиска карты мест</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.SeatMap.SeatMapRSBody> GetSeatMap(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request);

		/// <summary>
		/// Поиск допуслуг для определённого перелёта
		/// </summary>
		/// <param name="Request">Запрос на поиск допуслуг</param>
		/// <returns>Результат поиска допуслуг</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.AdditionalServicesSearch.AdditionalServicesSearchRSBody> GetAdditionalServices(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request);

		/// <summary>
		/// Отмена брони перелёта
		/// </summary>
		/// <param name="Request">Запрос на отмену брони перелёта</param>
		/// <returns>Результат отмены брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.SharedElements.BookOperationResult> CancelBook(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request);

		/// <summary>
		/// Получение истории брони из ГДС
		/// </summary>
		/// <param name="Request">Запрос на получение истории</param>
		/// <returns>История брони из ГДС</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.GetBookHistory.GetBookHistoryRSBody> GetBookHistory(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request);

		/// <summary>
		/// Войдирование брони (отмена выписки)
		/// </summary>
		/// <param name="Request">Запрос войдирования брони</param>
		/// <returns>Результат войдирования брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.SharedElements.BookOperationResult> VoidTicket(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request);

		/// <summary>
		/// Сдача билетов
		/// </summary>
		/// <param name="Request">Запрос на сдачу билетов</param>
		/// <returns>Результат сдачи билетов</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.RefundTicket.RefundTicketRSBody> RefundTicket(Request<AviaEntities.RefundTicket.RefundTicketRQBody> Request);

		/// <summary>
		/// Выполнение терминальной команды
		/// </summary>
		/// <param name="Request">Запрос на выполнение терминальной команды</param>
		/// <returns>Результат выполнения терминальной команды</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.ServerCommand.ServerCommandRSBody> HostCommand(Request<AviaEntities.ServerCommand.ServerCommandRQBody> Request);

		/// <summary>
		/// Открытие сессии с ГДС
		/// </summary>
		/// <param name="Request">Запрос на открытие сессии</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.OpenSession.OpenSessionRSBody> OpenSession(Request<AviaEntities.OpenSession.OpenSessionRQBody> Request);

		/// <summary>
		/// Закрытие сессии с ГДС
		/// </summary>
		/// <param name="Request">Запрос на закрытие сессии</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.CloseSession.CloseSessionRSBody> CloseSession(Request<AviaEntities.CloseSession.CloseSessionRQBody> Request);

		/// <summary>
		/// Получение списка кредитных карт, которыми можно будет оплатить бронь через ГДС процессинг
		/// </summary>
		/// <param name="Request">Запрос на получение списка карт</param>
		/// <returns>Реузльтат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.GetAllowedCC.GetAllowedCCRSBody> GetAllowedCC(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request);

		/// <summary>
		/// Получение курсов обмена валюты из ГДС
		/// </summary>
		/// <param name="Request">Запрос на получение курсов</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.GetCurrencyConversion.GetCurrencyConversionRSBody> GetCurrencyConversion(Request<AviaEntities.GetCurrencyConversion.GetCurrencyConversionRQBody> Request);

		/// <summary>
		/// Получение текущего состояния брони
		/// </summary>
		/// <param name="Request">Запрос на получение брони</param>
		/// <returns>Текущее состояние брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> GetBook(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request);

		/// <summary>
		/// Получение результатов определённого поиска
		/// </summary>
		/// <param name="Request">Запрос на получение результатов поиска</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.v1_2.SearchFlights.SearchFlightsRSBody> GetSearchResults(Request<AviaEntities.GetSearchResults.GetSearchResultsRQBody> Request);

		/// <summary>
		/// Получение статики из системы поставщика
		/// </summary>
		/// <param name="Request">Запрос на получение статики</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.GetSupplierStatic.GetSupplierStaticRSBody> GetSupplierStatic(Request<AviaEntities.GetSupplierStatic.GetSupplierStaticRQBody> Request);

		/// <summary>
		/// Поиск перелётов по расписанию
		/// </summary>
		/// <param name="Request">Запрос поиска перелётов по расписанию</param>
		/// <returns>Результат поиска перелётов по расписанию</returns>
		[OperationContract]
		[DataContractFormat]
		Response<ScheduleSearchRSBody> ScheduleSearch(Request<ScheduleSearchRQBody> Request);

		#endregion

		#region АПИ версии 1.1

		/// <summary>
		/// Поиск с сгруппированной выдачей с АПИ v1.1
		/// </summary>
		/// <param name="Request">Запрос на поиск перелётов</param>
		/// <returns>Результаты поиска</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.v1_1.GroupSearch.GroupedFlightResultBody> GroupSearch_1_1(Request<AviaEntities.FlightSearch.FlightSearchRQBody> Request);

		/// <summary>
		/// Выполнение дополнительных операций с АПИ v1.1
		/// </summary>
		/// <param name="Request">Запрос на выполнение допопераций</param>
		/// <returns>Результат выполнения допопераций</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.v1_1.AdditionalOperations.AdditionalOperationsRSBody> AdditionalOperations_1_1(Request<AviaEntities.v1_1.AdditionalOperations.AdditionalOperationsRQBody> Request);

		#endregion

		#region АПИ версии 1.2

		/// <summary>
		/// Поиск перелётов с АПИ v1.2
		/// </summary>
		/// <param name="Request">Запрос поиска перелётов</param>
		/// <returns>Результат поиска перелётов</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.v1_2.SearchFlights.SearchFlightsRSBody> Search_1_2(Request<AviaEntities.v1_2.SearchFlights.SearchFlightsRQBody> Request);

		#endregion

		#region АПИ версии 2.0

		/// <summary>
		/// Бронирование перелёта с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на создание брони</param>
		/// <returns>Результат бронирования</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> BookFlight_2_0(Request<AviaEntities.v2.BookFlight.BookFlightRQBody> Request);

		/// <summary>
		/// Обновление информации о брони с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на обновление информации о брони</param>
		/// <returns>Результат обновления брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> UpdateBook_2_0(Request<AviaEntities.v2.UpdateBook.UpdateBookRQBody> Request);

		/// <summary>
		/// Модификация брони с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на модификацию брони</param>
		/// <returns>Результат модификации</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> ModifyBook_2_0(Request<AviaEntities.v2.BookModify.BookModifyRQBody> Request);

		/// <summary>
		/// Создание брони на основании ПНРа из ГДС с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на создание брони</param>
		/// <returns>Созданная бронь</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> ImportBook_2_0(Request<ImportBookRQBody> Request);


		/// <summary>
		/// Выписка брони (получение номеров билетов) с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на выписку брони</param>
		/// <returns>Результат выписки брони (бронь с номерами билетов)</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GeneralEntities.BookContent.Book> Ticket_2_0(Request<AviaEntities.v2.Ticketing.TicketingRQBody> Request);

		#endregion
	}
}
