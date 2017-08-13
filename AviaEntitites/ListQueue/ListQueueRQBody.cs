using AviaEntities.ListQueue.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.ListQueue
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ListQueueRQBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public PackagesList Packages { get; set; }

		[DataMember(Order = 1)]
		public QueueList QueueList { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool UpdateAll { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool RemoveAfterRead { get; set; }

		/// <summary>
		/// Читать брони из очередей указаных в настройках агентства
		/// </summary>
		[DataMember(Order = 4)]
		public bool ListAgencyQueues { get; set; }
	}
}