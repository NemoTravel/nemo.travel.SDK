using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.FlightSearch.ResponseElements
{
	[CollectionDataContract(ItemName = "Item", KeyName = "Language", ValueName = "Value", Namespace = "http://nemo-ibe.com/Avia")]
	public class MultiLanguageDictionary : Dictionary<string, string>
	{
		public MultiLanguageDictionary() : base() { }

		public MultiLanguageDictionary(Dictionary<string, string> dictionary) : base(dictionary) { }
	}
}
