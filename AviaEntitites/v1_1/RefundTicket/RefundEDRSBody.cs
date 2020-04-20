using AviaEntities.SharedElements.RefundTicket;
using GeneralEntities.BookContent;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.RefundTicket
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RefundEDRSBody : CommonRefundEDRSBody<Book>
	{
	}
}