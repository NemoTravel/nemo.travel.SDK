using System.Runtime.Serialization;

namespace AviaEntities.v2.BookFlight
{
	/// <summary>
	/// Содержит описание дополнительных действий при создании брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalBookingActions
	{
		/// <summary>
		/// Номер очереди, в которую требуется поместить бронь
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string QueueNum { get; set; }
	}
}