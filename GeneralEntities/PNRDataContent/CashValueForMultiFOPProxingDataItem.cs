using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class CashValueForMultiFOPProxingDataItem
	{
		[DataMember(Order = 0, IsRequired = true)]
		public Money CashValue { get; set; }
	}
}