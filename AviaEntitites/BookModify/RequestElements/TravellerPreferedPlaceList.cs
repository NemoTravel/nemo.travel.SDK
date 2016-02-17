using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "PreferedPlaces", ItemName = "PreferedPlace")]
	public class TravellerPreferedPlaceList : List<TravellerPreferedPlace>
	{
	}
}