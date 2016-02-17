using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Массив номер сегментов перелёта (или иной услуги)
	/// </summary>
	[Serializable]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SegmentNumbers", ItemName = "Number")]
	public class SegmentNumberList : List<int>
	{
		public SegmentNumberList()
		{ }

		public SegmentNumberList(List<int> list)
			: base(list)
		{ }
	}
}
