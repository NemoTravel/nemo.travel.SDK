using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "BookInfo")]
	public class BookInfoList : List<BookInfo>
	{
		public BookInfoList()
		{ }

		public BookInfoList(List<BookInfo> list)
			: base(list)
		{ }
	}
}