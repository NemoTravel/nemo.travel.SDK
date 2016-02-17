using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Связка сегментов из ответа с сегментами из запроса
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightSegmentBinding
	{
		/// <summary>
		/// Номер сегмента из запроса
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public int? RequestedSegment { get; set; }

		/// <summary>
		/// Номер сегмента в ответе
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public long SegmentNumber { get; set; }
	}
}