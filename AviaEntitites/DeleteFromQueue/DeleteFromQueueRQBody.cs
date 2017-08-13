using AviaEntities.DeleteFromQueue.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.DeleteFromQueue
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class DeleteFromQueueRQBody
	{
		[DataMember(Order = 0, IsRequired = true)]
		public BookQueueList BookQueueList { get; set; }
	}
}