using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.FareRulesInfo
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Condition")]
	public class ConditionsList : List<string>
	{
		public ConditionsList() : base() { }

		public ConditionsList(IEnumerable<string> collection) : base(collection) { }

		public override bool Equals(object obj)
		{
			var other = obj as ConditionsList;
			if (other == null)
			{
				return false;
			}

			return Count == other.Count && TrueForAll(condition => other.Contains(condition));
		}
	}
}