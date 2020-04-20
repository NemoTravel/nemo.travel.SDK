using System.Runtime.Serialization;
using System.Text;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ObjectData
	{
		[DataMember(Order = 0)]
		public string ValidatingCompany { get; set; }

		[DataMember(Order = 1)]
		public string PaymentDate { get; set; }

		[DataMember(Order = 2)]
		public string FirstVendor { get; set; }

		[DataMember(Order = 3)]
		public string FlightType { get; set; }

		[DataMember(Order = 4)]
		public string InterlinePart { get; set; }

		[DataMember(Order = 5)]
		public string MarketingVendor { get; set; }

		[DataMember(Order = 6)]
		public string BookingClass { get; set; }

		[DataMember(Order = 7)]
		public string ServiceClass { get; set; }

		[DataMember(Order = 8)]
		public string FlightNumber { get; set; }

		[DataMember(Order = 9)]
		public string Aircraft { get; set; }

		[DataMember(Order = 10)]
		public string Passengers { get; set; }

		[DataMember(Order = 11)]
		public string OperatingVendor { get; set; }

		[DataMember(Order = 12)]
		public string GDS { get; set; }

		[DataMember(Order = 13, EmitDefaultValue = false)]
		public string UTMSource { get; set; }

		[DataMember(Order = 14)]
		public string CodeSharing { get; set; }

		[DataMember(Order = 15)]
		public string ContractType { get; set; }

		[DataMember(Order = 16)]
		public string PrivateFare { get; set; }

		[DataMember(Order = 17)]
		public string FlightDate { get; set; }

		[DataMember(Order = 18)]
		public string DepartureAndArrival { get; set; }

		[DataMember(Order = 19)]
		public string Zone { get; set; }

		[DataMember(Order = 20)]
		public string DaysOfWeek { get; set; }

		[DataMember(Order = 21)]
		public string Routes { get; set; }

		[DataMember(Order = 22)]
		public string RouteType { get; set; }

		[DataMember(Order = 23)]
		public string Price { get; set; }

		[DataMember(Order = 24)]
		public string PriceActual { get; set; }

		[DataMember(Order = 25)]
		public string Commission { get; set; }

		[DataMember(Order = 26)]
		public string AgencyCommission { get; set; }

		[DataMember(Order = 27)]
		public string Bonus { get; set; }

		[DataMember(Order = 28)]
		public string Charge { get; set; }

		[DataMember(Order = 29)]
		public string Tariffs { get; set; }

		[DataMember(Order = 30)]
		public string Taxes { get; set; }

		[DataMember(Order = 31, EmitDefaultValue = false)]
		public string Environment { get; set; }

		[DataMember(Order = 32)]
		public string AirlinesAndClasses { get; set; }

		[DataMember(Order = 33)]
		public string ID { get; set; }

		[DataMember(Order = 34, EmitDefaultValue = false)]
		public string FlightDateDeparture { get; set; }

		public string Dump()
		{
			return new StringBuilder().
				Append(ValidatingCompany).
				Append(';').
				Append(ID).
				Append(";;").
				Append(GDS).
				Append(';').
				Append(UTMSource).
				Append(';').
				Append(PriceActual).
				Append(';').
				Append(DepartureAndArrival).
				Append(';').
				Append(BookingClass).
				Append(';').
				Append(PaymentDate).
				Append(';').
				Append(FirstVendor).
				Append(';').
				Append(FlightType).
				Append(';').
				Append(InterlinePart).
				Append(';').
				Append(MarketingVendor).
				Append(';').
				Append(ServiceClass).
				Append(';').
				Append(Aircraft).
				Append(';').
				Append(Passengers).
				Append(';').
				Append(OperatingVendor).
				Append(';').
				Append(CodeSharing).
				Append(';').
				Append(ContractType).
				Append(';').
				Append(PrivateFare).
				Append(';').
				Append(FlightDate).
				Append(';').
				Append(Zone).
				Append(';').
				Append(Tariffs).
				Append(';').
				Append(Taxes).
				Append(';').
				Append(FlightNumber).
				Append(';').
				Append(Price).
				Append(';').
				Append(DaysOfWeek).
				Append(';').
				Append(RouteType).
				Append(';').
				Append(Routes).
				Append(';').
				Append(Environment).
				Append(';').
				Append(AirlinesAndClasses).
				Append(';').
				Append(FlightDateDeparture).
				Append(';', 4).
				Append(Commission).
				Append(";;").
				Append(AgencyCommission).
				Append(';').
				Append(Bonus).
				Append(';', 3).
				Append(Charge).
				Append(';').
				ToString();
		}
	}
}