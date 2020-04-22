using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AltPoints", ItemName = "AltPoint")]
	public class RequestedTripPointList : List<RequestedTripPoint>
	{
		public RequestedTripPointList FullCopy()
		{
			var result = new RequestedTripPointList();

			foreach (var tripPoint in this)
			{
				result.Add(tripPoint.FullCopy());
			}

			return result;
		}
	}
}