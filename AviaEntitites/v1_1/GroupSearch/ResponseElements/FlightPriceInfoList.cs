using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список сгруппированных перелётов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "FlightPriceInfos_1_1", ItemName = "Flight")]
	public class FlightPriceInfoList : List<FlightPriceInfo>
	{
	}
}