using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	/// <summary>
	/// Список меток-тэгов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Tag")]
	public class TagList : List<string>
	{
		public TagList() : base() { }

		public TagList(IEnumerable<string> list) : base(list) { }
	}
}