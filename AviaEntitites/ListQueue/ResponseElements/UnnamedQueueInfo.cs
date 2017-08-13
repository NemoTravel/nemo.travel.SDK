using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", KeyName = "Queue", ValueName = "BookInfoList", ItemName = "QueueInfo")]
	public class UnnamedQueueInfo : Dictionary<string, BookInfoList> { }
}
