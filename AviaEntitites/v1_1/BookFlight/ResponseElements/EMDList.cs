using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "EMDs", ItemName = "EMD")]
	public class EMDList : List<EMDInfo>
	{
	}
}