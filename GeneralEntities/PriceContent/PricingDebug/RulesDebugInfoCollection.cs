using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent.PricingDebug
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "RuleData")]
	public class RulesDebugInfoCollection : List<RuleData>
	{
		public RulesDebugInfoCollection() : base() { }

		public RulesDebugInfoCollection(int capacity) : base(capacity) { }

		public RulesDebugInfoCollection(IEnumerable<RuleData> ruleDatas) : base(ruleDatas) { }
	}
}