using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.DeleteFromQueue.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookQueueList : List<BookQueueInfo>
	{
		public BookQueueList() : base() { }

		public BookQueueList(IEnumerable<BookQueueInfo> list) : base(list) { }
	}
}