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
using System;

namespace AviaServerAPI
{
	public class Avia : IAvia
	{
		#region АПИ версии 1.0

		public Response<AviaEntities.RulesSearch.RulesSearchRSBody> GetFareRules(Request<OnlyFlightIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.SeatMap.SeatMapRSBody> GetSeatMap(Request<OnlyFlightIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<BookOperationResult> CancelBook(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetBookHistoryRSBody> GetBookHistory(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<BookOperationResult> VoidTicket(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetCurrencyConversionRSBody> GetCurrencyConversion(Request<GetCurrencyConversionRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> GetBook(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetSupplierStaticRSBody> GetSupplierStatic(Request<AviaEntities.GetSupplierStatic.GetSupplierStaticRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<ScheduleSearchRSBody> ScheduleSearch(Request<ScheduleSearchRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<ListQueueRSBody> ListQueue(Request<ListQueueRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<object> DeleteFromQueue(Request<DeleteFromQueueRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetRoutingGridRSBody> GetRoutingGrid(Request<GetRoutingGridRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<FlightRepricingRSBody> FlightRepricing(Request<FlightRepricingRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> ReleaseSeat(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> SplitBook(Request<SplitBookRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetExchangeVariantsRSBody> GetExchangeVariants(Request<GetExchangeVariantsRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<ExchangeTicketRSBody> ExchangeTicket(Request<ExchangeTicketRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> CompleteEMDProcessing(Request<OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> IssueEMD(Request<IssueEMDRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> VoidEMD(Request<CommonAncillaryServiceRQ> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<RefundEDRSBody> GetEMDRefundData(Request<CommonAncillaryServiceRQ> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<RefundEDRSBody> RefundEMD(Request<CommonAncillaryServiceRQ> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<GetAirlineScheduleRSBody> GetAirlineSchedule(Request<GetAirlineScheduleRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		#endregion

		#region АПИ версии 1.1

		public Response<AviaEntities.v1_1.GroupSearch.GroupedFlightResultBody> GroupSearch_1_1(Request<AviaEntities.FlightSearch.FlightSearchRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.v1_1.AdditionalOperations.AdditionalOperationsRSBody> AdditionalOperations_1_1(Request<AviaEntities.v1_1.AdditionalOperations.AdditionalOperationsRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<RefundEDRSBody> GetRefundData_1_1(Request<RefundTicketRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<RefundEDRSBody> RefundTicket_1_1(Request<RefundTicketRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		#endregion

		#region АПИ версии 1.2

		/// <summary>
		/// Поиск перелётов с АПИ v1.2
		/// </summary>
		/// <param name="Request">Запрос поиска перелётов</param>
		/// <returns>Результат поиска перелётов</returns>
		public Response<AviaEntities.v1_2.SearchFlights.SearchFlightsRSBody> Search_1_2(Request<AviaEntities.v1_2.SearchFlights.SearchFlightsRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		#endregion

		#region АПИ версии 2.0

		public Response<Book> BookFlight_2_0(Request<AviaEntities.v2.BookFlight.BookFlightRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> UpdateBook_2_0(Request<AviaEntities.v2.UpdateBook.UpdateBookRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> ModifyBook_2_0(Request<AviaEntities.v2.BookModify.BookModifyRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> ImportBook_2_0(Request<ImportBookRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> Ticket_2_0(Request<AviaEntities.v2.Ticketing.TicketingRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		#endregion
	}
}
