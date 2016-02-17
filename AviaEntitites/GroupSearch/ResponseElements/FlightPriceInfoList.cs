using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список сгруппированных перелётов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPriceInfos", ItemName = "Flight")]
	public class FlightPriceInfoList : List<FlightPriceInfo>
	{
	}
}