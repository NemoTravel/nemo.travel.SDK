using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список ИД неких элементов системы
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "ID")]
	public class IDList : List<int>
	{
		public IDList(List<int> list): base(list)
		{ }

		public IDList()
		{ }
	}
}