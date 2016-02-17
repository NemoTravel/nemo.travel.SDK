using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetAllowedCC
{
	/// <summary>
	/// Содержит описание списка допустимых типов кредитных карт
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Code")]
	public class CCCodeList : List<string>
	{
	}
}