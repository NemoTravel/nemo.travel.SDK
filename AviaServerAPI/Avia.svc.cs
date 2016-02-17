using AviaEntities.ImportBook;
using AviaEntities.ScheduleSearch;
using GeneralEntities;
using GeneralEntities.BookContent;
using System;

namespace AviaServerAPI
{
	public class Avia : IAvia
	{
		#region АПИ версии 1.0

		public Response<AviaEntities.RulesSearch.RulesSearchRSBody> GetFareRules(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.AirAvail.AirAvailRSBody> CheckFlightAvailability(Request<AviaEntities.AirAvail.AirAvailRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.SeatMap.SeatMapRSBody> GetSeatMap(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.AdditionalServicesSearch.AdditionalServicesSearchRSBody> GetAdditionalServices(Request<AviaEntities.SharedElements.OnlyFlightIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.SharedElements.BookOperationResult> CancelBook(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.GetBookHistory.GetBookHistoryRSBody> GetBookHistory(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.SharedElements.BookOperationResult> VoidTicket(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.RefundTicket.RefundTicketRSBody> RefundTicket(Request<AviaEntities.RefundTicket.RefundTicketRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.ServerCommand.ServerCommandRSBody> HostCommand(Request<AviaEntities.ServerCommand.ServerCommandRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.OpenSession.OpenSessionRSBody> OpenSession(Request<AviaEntities.OpenSession.OpenSessionRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.CloseSession.CloseSessionRSBody> CloseSession(Request<AviaEntities.CloseSession.CloseSessionRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.GetAllowedCC.GetAllowedCCRSBody> GetAllowedCC(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.GetCurrencyConversion.GetCurrencyConversionRSBody> GetCurrencyConversion(Request<AviaEntities.GetCurrencyConversion.GetCurrencyConversionRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<Book> GetBook(Request<AviaEntities.SharedElements.OnlyBookIDElement> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.v1_2.SearchFlights.SearchFlightsRSBody> GetSearchResults(Request<AviaEntities.GetSearchResults.GetSearchResultsRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<AviaEntities.GetSupplierStatic.GetSupplierStaticRSBody> GetSupplierStatic(Request<AviaEntities.GetSupplierStatic.GetSupplierStaticRQBody> Request)
		{
			//Place your code here
			throw new NotImplementedException();
		}

		public Response<ScheduleSearchRSBody> ScheduleSearch(Request<ScheduleSearchRQBody> Request)
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
