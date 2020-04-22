using GeneralEntities.PNRDataContent;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "LoyaltyCard")]
	public class LoyaltyCards : List<BasePNRDataItem>
	{
		public LoyaltyCards() { }

		public LoyaltyCards(IEnumerable<BasePNRDataItem> collection) : base(collection) { }
	}
}