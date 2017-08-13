using AviaEntities.DeleteFromQueue;
using AviaEntities.Exchange;
using AviaEntities.FlightRepricing;
using AviaEntities.GetAirlineSchedule;
using AviaEntities.GetBookHistory;
using AviaEntities.GetCurrencyConversion;
using AviaEntities.GetExchangeVariants;
using AviaEntities.GetRoutingGrid;
using AviaEntities.GetSupplierStatic;
using AviaEntities.ImportBook;
using AviaEntities.IssueEMD;
using AviaEntities.ListQueue;
using AviaEntities.RefundTicket;
using AviaEntities.ScheduleSearch;
using AviaEntities.SharedElements;
using AviaEntities.SharedElements.Ancillaries.RequestElements;
using AviaEntities.SplitBook;
using AviaEntities.v1_1.RefundTicket;
using GeneralEntities;
using GeneralEntities.BookContent;
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
		Response<AviaEntities.RulesSearch.RulesSearchRSBody> GetFareRules(Request<OnlyFlightIDElement> Request);

		/// <summary>
		/// Поиск карты мест перелёта
		/// </summary>
		/// <param name="Request">Запрос на поиск карты перелёта</param>
		/// <returns>Результат поиска карты мест</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.SeatMap.SeatMapRSBody> GetSeatMap(Request<OnlyFlightIDElement> Request);

		/// <summary>
		/// Отмена брони перелёта
		/// </summary>
		/// <param name="Request">Запрос на отмену брони перелёта</param>
		/// <returns>Результат отмены брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<AviaEntities.SharedElements.BookOperationResult> CancelBook(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Получение истории брони из ГДС
		/// </summary>
		/// <param name="Request">Запрос на получение истории</param>
		/// <returns>История брони из ГДС</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetBookHistoryRSBody> GetBookHistory(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Войдирование брони (отмена выписки)
		/// </summary>
		/// <param name="Request">Запрос войдирования брони</param>
		/// <returns>Результат войдирования брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<BookOperationResult> VoidTicket(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Получение курсов обмена валюты из ГДС
		/// </summary>
		/// <param name="Request">Запрос на получение курсов</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetCurrencyConversionRSBody> GetCurrencyConversion(Request<AviaEntities.GetCurrencyConversion.GetCurrencyConversionRQBody> Request);

		/// <summary>
		/// Получение текущего состояния брони
		/// </summary>
		/// <param name="Request">Запрос на получение брони</param>
		/// <returns>Текущее состояние брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> GetBook(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Получение статики из системы поставщика
		/// </summary>
		/// <param name="Request">Запрос на получение статики</param>
		/// <returns>Результат обработки запроса</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetSupplierStaticRSBody> GetSupplierStatic(Request<GetSupplierStaticRQBody> Request);

		/// <summary>
		/// Поиск перелётов по расписанию
		/// </summary>
		/// <param name="Request">Запрос поиска перелётов по расписанию</param>
		/// <returns>Результат поиска перелётов по расписанию</returns>
		[OperationContract]
		[DataContractFormat]
		Response<ScheduleSearchRSBody> ScheduleSearch(Request<ScheduleSearchRQBody> Request);

		/// <summary>
		/// Чтение очередей ГДС
		/// </summary>
		/// <param name="Request">Запрос на чтение очереди</param>
		/// <returns>Результат чтения очереди</returns>
		[OperationContract]
		[DataContractFormat]
		Response<ListQueueRSBody> ListQueue(Request<ListQueueRQBody> Request);

		/// <summary>
		/// Удаление ПНР из очередей
		/// </summary>
		/// <param name="Request">Запрос на удаление ПНР из очереди</param>
		/// <returns>Результат удаления ПНР из очереди</returns>
		[OperationContract]
		[DataContractFormat]
		Response<object> DeleteFromQueue(Request<DeleteFromQueueRQBody> Request);

		/// <summary>
		/// Получение маршрутной сетки
		/// </summary>
		/// <param name="Request">Запрос на получение маршрутной сетки</param>
		/// <returns>Маршрутная сетка</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetRoutingGridRSBody> GetRoutingGrid(Request<GetRoutingGridRQBody> Request);

		/// <summary>
		/// Репрайсинг перелётов - получение вариантов оценки определённого перелёта в разных источниках
		/// </summary>
		[OperationContract]
		[DataContractFormat]
		Response<FlightRepricingRSBody> FlightRepricing(Request<FlightRepricingRQBody> Request);

		/// <summary>
		/// Снятие мест
		/// </summary>
		/// <param name="Request">Запрос на снятие мест</param>
		/// <returns>Результат снятия мест</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> ReleaseSeat(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Разделение брони
		/// </summary>
		/// <param name="Request">Запрос на разделение брони</param>
		/// <returns></returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> SplitBook(Request<SplitBookRQBody> Request);

		/// <summary>
		/// Получение вариантов обмена билетов
		/// </summary>
		/// <param name="Request">Запрос получения вариантов обмена билетов</param>
		/// <returns>Варианты обмена билетов</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetExchangeVariantsRSBody> GetExchangeVariants(Request<GetExchangeVariantsRQBody> Request);

		/// <summary>
		/// Обмен билетов
		/// </summary>
		/// <param name="Request">Запрос на обмен билетов</param>
		/// <returns>Результат обмена билетов</returns>
		[OperationContract]
		[DataContractFormat]
		Response<ExchangeTicketRSBody> ExchangeTicket(Request<ExchangeTicketRQBody> Request);

		/// <summary>
		/// Завершение обмена
		/// </summary>
		/// <param name="Request">Запрос на завершение обмена</param>
		/// <returns>Результат завершения обмена</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> CompleteEMDProcessing(Request<OnlyBookIDElement> Request);

		/// <summary>
		/// Выписка допуслуг
		/// </summary>
		/// <param name="request">Запрос на выписку емд для допуслуги</param>
		/// <returns>Результат выписки допуслуг</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> IssueEMD(Request<IssueEMDRQBody> Request);

		/// <summary>
		/// Войдирование допуслуг
		/// </summary>
		/// <param name="request">Запрос на войдирование допуслуги</param>
		/// <returns>Результат войдирования допуслуг</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> VoidEMD(Request<CommonAncillaryServiceRQ> Request);

		/// <summary>
		/// Рассчёт возврата ЕМД
		/// </summary>
		/// <param name="request">Запрос на рассчёт возврата ЕМД</param>
		/// <returns>Результат рассчёта возврата ЕМД</returns>
		[OperationContract]
		[DataContractFormat]
		Response<RefundEDRSBody> GetEMDRefundData(Request<CommonAncillaryServiceRQ> Request);

		/// <summary>
		/// Возврат допуслуг
		/// </summary>
		/// <param name="request">Запрос на возврат допуслуги</param>
		/// <returns>Результат возврата допуслуг</returns>
		[OperationContract]
		[DataContractFormat]
		Response<RefundEDRSBody> RefundEMD(Request<CommonAncillaryServiceRQ> Request);

		/// <summary>
		/// Получение рассписания А/К
		/// </summary>
		/// <param name="Request">Запрос на получение расписания А/К</param>
		/// <returns>Расписание А/К</returns>
		[OperationContract]
		[DataContractFormat]
		Response<GetAirlineScheduleRSBody> GetAirlineSchedule(Request<GetAirlineScheduleRQBody> Request);
		
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

		/// <summary>
		/// Получение информации о сдаче билетов с АПИ v1.1
		/// </summary>
		/// <param name="Request">Запрос на получение информации по сдаче билетов</param>
		/// <returns>Полученная информация</returns>
		[OperationContract]
		[DataContractFormat]
		Response<RefundEDRSBody> GetRefundData_1_1(Request<RefundTicketRQBody> Request);

		/// <summary>
		/// Сдача билетов  с АПИ v1.1
		/// </summary>
		/// <param name="Request">Запрос на сдачу билетов</param>
		/// <returns>Результат сдачи билетов</returns>
		[OperationContract]
		[DataContractFormat]
		Response<RefundEDRSBody> RefundTicket_1_1(Request<RefundTicketRQBody> Request);

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
		Response<Book> BookFlight_2_0(Request<AviaEntities.v2.BookFlight.BookFlightRQBody> Request);

		/// <summary>
		/// Обновление информации о брони с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на обновление информации о брони</param>
		/// <returns>Результат обновления брони</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> UpdateBook_2_0(Request<AviaEntities.v2.UpdateBook.UpdateBookRQBody> Request);

		/// <summary>
		/// Модификация брони с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на модификацию брони</param>
		/// <returns>Результат модификации</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> ModifyBook_2_0(Request<AviaEntities.v2.BookModify.BookModifyRQBody> Request);

		/// <summary>
		/// Создание брони на основании ПНРа из ГДС с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на создание брони</param>
		/// <returns>Созданная бронь</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> ImportBook_2_0(Request<ImportBookRQBody> Request);


		/// <summary>
		/// Выписка брони (получение номеров билетов) с АПИ v2.0
		/// </summary>
		/// <param name="Request">Запрос на выписку брони</param>
		/// <returns>Результат выписки брони (бронь с номерами билетов)</returns>
		[OperationContract]
		[DataContractFormat]
		Response<Book> Ticket_2_0(Request<AviaEntities.v2.Ticketing.TicketingRQBody> Request);

		#endregion
	}
}
