using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.RequestElements
{
	/// <summary>
	/// АПИ обёртка для списка классов бронирования для сегментов перелёта
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "BookingClassCodesForSegment", KeyName = "SegmentNumber", ValueName = "BookingClassCode")]
	public class BookingClassCodesForSegments : Dictionary<int, string>
	{
		public BookingClassCodesForSegments() : base() { }

		public BookingClassCodesForSegments(IDictionary<int, string> dictionary) : base(dictionary) { }
	}
}
