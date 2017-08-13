using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Check", KeyName = "Name", ValueName = "Info")]
	public class CheckResultsCollection : Dictionary<string, CheckInfo>
	{
		public CheckResultsCollection() : base() { }

		public CheckResultsCollection(IDictionary<string, CheckInfo> dictionary) : base(dictionary) { }
	}
}