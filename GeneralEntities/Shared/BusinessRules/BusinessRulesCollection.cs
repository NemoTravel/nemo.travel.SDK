using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared.BusinessRules
{
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "Rule", KeyName = "Id", ValueName = "AdditionalParameters")]
	public class BusinessRulesCollection : Dictionary<string, AdditionalParametersCollection>
	{
		public BusinessRulesCollection() { }

		public BusinessRulesCollection(int capacity) : base(capacity) { }
	}
}