using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// АПИ обёртка для списка кодов а/к
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "AirlineCode")]
	public class AirlineList : List<string>
	{
	}
}