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
	}
}