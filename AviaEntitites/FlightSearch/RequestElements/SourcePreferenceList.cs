using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Список предпочитаемых источников
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "SourcePreference", ItemName = "Source")]
	public class SourcePreferenceList : List<int>
	{
	}
}