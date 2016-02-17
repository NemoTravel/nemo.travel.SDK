using AviaEntities.FlightSearch.ResponseElements;
using GeneralEntities.Market;
using System;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Содержит информацию об определённой купленной допуслуге
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookedAdditionalService : AdditionalService
	{
		/// <summary>
		/// Статус забронированной допуслуги
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string Status { get; set; }

		/// <summary>
		/// Номер пассажира, для которого она забронирована
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public int PassNumber { get; set; }

		/// <summary>
		/// Номер сегмента, для которого она забронирована
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public int SegNumber { get; set; }
	}
}