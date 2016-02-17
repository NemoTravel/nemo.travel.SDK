using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class StopPoint : AirportInformation
	{
		/// <summary>
		/// Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public DateTimeEx ArrDateTime { get; set; }

		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public DateTimeEx DepDateTime { get; set; }
	}
}