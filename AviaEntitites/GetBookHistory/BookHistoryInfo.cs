using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetBookHistory
{
	/// <summary>
	/// Массив изменения в рамках ревизии ПНРа
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "HistoryRemarks", ItemName = "HistoryRemark")]
	public class BookHistoryInfo : List<string>
	{
	}
}