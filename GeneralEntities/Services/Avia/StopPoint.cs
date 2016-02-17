using GeneralEntities.ExtendedDateTime;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Avia
{
	/// <summary>
	/// Содержит описание точки остановки на рейсе
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class StopPoint : TripPointInformation
	{
		/// <summary>
		/// Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public DateTimeEx ArrDateTime { get; set; }

		/// <summary>
		/// Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public DateTimeEx DepDateTime { get; set; }

		/// <summary>
		/// Признак высадки пассажиров на время остановки
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool PassengerLanding { get; set; }
	}
}