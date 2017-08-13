using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.DeleteFromQueue.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Queue")]
	public class UnnamedQueueList : List<string>
	{
	}
}