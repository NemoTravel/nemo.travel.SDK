using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.RequestElements
{
	/// <summary>
	/// Запрос на бронирование допуслуги
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryServiceRQ : BaseAncillaryService
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int TravellerRef { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public MRefList<int> SegmentRef { get; set; }

		/// <summary>
		/// Проверяет данный элемент на привязку к определённому пассажиру в брони
		/// </summary>
		/// <param name="travellerID">Номер пассажира в брони, на привязку к которому требуется проверить данный элемент</param>
		/// <returns>Признак привязки данного элемент к указанному пассажиру</returns>
		public bool IsLinkedToTraveller(int travellerID)
		{
			return TravellerRef == travellerID;
		}

		/// <summary>
		/// Проверяет данный элемент на привязку к определённому сегменту в брони
		/// </summary>
		/// <param name="segmentID">Номер сегмента в брони, на привязку к которому требуется проверить данный элемент</param>
		/// <param name="includeNotLinked">Включает определение элемента без привязки к сегментам, как привязанных ко всем</param>
		/// <returns>Признак привязки данного элемент к указанному сегменту</returns>
		public bool IsLinkeToSegment(int segmentID, bool includeNotLinked = false)
		{
			return (SegmentRef != null && SegmentRef.Contains(segmentID)) || (SegmentRef == null && includeNotLinked);
		}
	}
}