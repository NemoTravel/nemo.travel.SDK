using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список ИД неких элементов системы
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "ID")]
	public class IDList : List<long>
	{
	}
}