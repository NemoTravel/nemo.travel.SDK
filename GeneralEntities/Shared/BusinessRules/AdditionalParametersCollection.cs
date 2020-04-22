using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared.BusinessRules
{
	[CollectionDataContract(Namespace = "http://nemo.travel/STL", ItemName = "Parameter", KeyName = "Name", ValueName = "Value")]
	public class AdditionalParametersCollection : Dictionary<string, string>
	{
		public AdditionalParametersCollection() { }

		public AdditionalParametersCollection(int capacity) : base(capacity) { }
	}
}