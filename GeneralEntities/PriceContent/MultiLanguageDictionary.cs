using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[CollectionDataContract(ItemName = "Item", KeyName = "Language", ValueName = "Value", Namespace = "http://nemo-ibe.com/Avia")]
	public class MultiLanguageDictionary : Dictionary<string, string>
	{
		public MultiLanguageDictionary() : base() { }

		public MultiLanguageDictionary(Dictionary<string, string> dictionary) : base(dictionary) { }
	}
}
