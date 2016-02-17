using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Text")]
	public class TextList : List<string>
	{
		public TextList()
		{ }

		public TextList(List<string> list)
			: base(list)
		{ }
	}
}