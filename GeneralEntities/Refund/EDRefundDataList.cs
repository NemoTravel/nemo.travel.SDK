using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Refund
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "RefundData")]
	public class EDRefundDataList : List<EDRefundData>
	{
	}
}