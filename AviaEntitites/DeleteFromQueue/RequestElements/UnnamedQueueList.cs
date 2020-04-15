using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.DeleteFromQueue.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Queue")]
	public class UnnamedQueueList : HashSet<string>
	{
		public UnnamedQueueList() : base() { }

		public UnnamedQueueList(IEnumerable<string> collection) : base(collection) { }
	}
}