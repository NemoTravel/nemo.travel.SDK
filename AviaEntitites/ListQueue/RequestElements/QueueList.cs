using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Queue")]
	public class QueueList : List<QueueName>
	{
		public QueueList() : base() { }

		public QueueList(IEnumerable<QueueName> list) : base(list) { }
	}
}