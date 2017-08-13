using AviaEntities.ListQueue.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.DeleteFromQueue.RequestElements
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookQueueInfo
	{
		[DataMember(Order = 0, IsRequired = true)]
		public long BookID { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public QueueList QueueNames { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public UnnamedQueueList UnnamedQueues { get; set; }
	}
}