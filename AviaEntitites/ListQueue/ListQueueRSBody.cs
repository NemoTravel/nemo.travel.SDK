using AviaEntities.ListQueue.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ListQueueRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public QueueInfo QueueInfoList { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public UnnamedQueueInfo UnnamedQueueInfoList { get; set; }


		public ListQueueRSBody()
		{
			QueueInfoList = new QueueInfo();
			UnnamedQueueInfoList = new UnnamedQueueInfo();
		}
	}
}