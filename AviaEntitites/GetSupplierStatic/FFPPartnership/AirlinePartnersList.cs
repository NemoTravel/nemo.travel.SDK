using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic.FFPPartnership
{
	/// <summary>
	/// Содержит список партнеров компании
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "AirlinePartner")]
	public class AirlinePartnersList : List<AirlinePartnerBlock>
	{
	}
}