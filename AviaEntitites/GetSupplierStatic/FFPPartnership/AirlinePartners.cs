using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic.FFPPartnership
{
	/// <summary>
	/// Содержит список партнеров по компаниям
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Partner")]
	public class AirlinePartners : List<string>
	{
	}
}