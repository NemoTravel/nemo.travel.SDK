using System.Collections.Generic;

namespace GeneralEntities.Constants
{
	public static class FlightPricingCheckName
	{
		private static List<string> ConstList;

		public const string GDS = "GDS";
		public const string UTMSource = "UTMSource";
		public const string PriceActual = "PriceActual";
		public const string DepAndArr = "DepAndArr";
		public const string BookingClass = "BookingClass";
		public const string PaymentDate = "PaymentDate";
		public const string FirstVendor = "FirstVendor";
		public const string FlightType = "FlightType";
		public const string OwnPart = "OwnPart";
		public const string MarketingVendor = "MarketingVendor";
		public const string ServiceClass = "ServiceClass";
		public const string Aircraft = "Aircraft";
		public const string Passengers = "Passengers";
		public const string OperatingVendor = "OperatingVendor";
		public const string CodeSharing = "CodeSharing";
		public const string ContractType = "ContractType";
		public const string PrivateFare = "PrivateFare";
		public const string FlightDate = "FlightDate";
		public const string Zone = "Zone";
		public const string Tariffs = "Tariffs";
		public const string Taxes = "Taxes";
		public const string FlightNumber = "FlightNumber";
		public const string Price = "Price";
		public const string DaysOfWeek = "DaysOfWeek";
		public const string RouteType = "RouteType";
		public const string Routes = "Routes";
		public const string Environment = "Environment";
		public const string AirlinesAndClasses = "AirlinesAndClasses";

		public static IEnumerable<string> GetConstList
		{
			get
			{
				return ConstList;
			}
		}

		static FlightPricingCheckName()
		{
			ConstList = new List<string>();

			ConstList.Add(GDS);
			ConstList.Add(UTMSource);
			ConstList.Add(PriceActual);
			ConstList.Add(DepAndArr);
			ConstList.Add(BookingClass);
			ConstList.Add(PaymentDate);
			ConstList.Add(FirstVendor);
			ConstList.Add(FlightType);
			ConstList.Add(OwnPart);
			ConstList.Add(MarketingVendor);
			ConstList.Add(ServiceClass);
			ConstList.Add(Aircraft);
			ConstList.Add(Passengers);
			ConstList.Add(OperatingVendor);
			ConstList.Add(CodeSharing);
			ConstList.Add(ContractType);
			ConstList.Add(PrivateFare);
			ConstList.Add(FlightDate);
			ConstList.Add(Zone);
			ConstList.Add(Tariffs);
			ConstList.Add(Taxes);
			ConstList.Add(FlightNumber);
			ConstList.Add(Price);
			ConstList.Add(DaysOfWeek);
			ConstList.Add(RouteType);
			ConstList.Add(Routes);
			ConstList.Add(Environment);
			ConstList.Add(AirlinesAndClasses);
		}
	}
}