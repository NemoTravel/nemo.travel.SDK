using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.AirAvail
{
	/// <summary>
	/// Результат проверки доступности перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AirAvailRSBody : OnlyFlightIDElement
	{
		/// <summary>
		/// Результат проверки
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public bool IsAvail { get; set; }

		/// <summary>
		/// Дополнительная информация о статусах сегментов
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string SegmentsStatusInfo { get; set; }
	}
}