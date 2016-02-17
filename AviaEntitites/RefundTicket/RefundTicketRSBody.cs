using AviaEntities.SharedElements;
using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.RefundTicket
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RefundTicketRSBody : BookOperationResult
	{
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public Money RefundSummary { get; set; }
	}
}
