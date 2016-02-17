using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetBookHistory
{
	/// <summary>
	/// Массив ревизий ПНРа
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "HistoryElements", ItemName = "HistoryElement")]
	public class BookHistoryElementList : List<BookHistoryElement>
	{
	}
}