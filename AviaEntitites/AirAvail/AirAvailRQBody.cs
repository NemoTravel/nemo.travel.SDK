using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.AirAvail
{
	/// <summary>
	/// Содержит описание запроса на проверку доступности перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AirAvailRQBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Признак необходимости использовать
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool UseBookingRequest { get; set; }
	}
}