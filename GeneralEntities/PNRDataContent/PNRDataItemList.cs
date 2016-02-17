using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Массив элементов с данными
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "DataItem")]
	public class PNRDataItemList : List<PNRDataItem>
	{
		public PNRDataItemList()
		{ }

		public PNRDataItemList(List<PNRDataItem> list)
			: base(list)
		{ }
	}
}