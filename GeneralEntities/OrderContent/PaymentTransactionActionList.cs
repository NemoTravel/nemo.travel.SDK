using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Action")]
	public class PaymentTransactionActionList : List<PaymentTransactionAction>
	{
	}
}
