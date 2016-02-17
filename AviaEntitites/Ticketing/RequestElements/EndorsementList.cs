using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.Ticketing.RequestElements
{
	/// <summary>
	/// Список эндорсментов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Endorsements", ItemName = "Endorsement")]
	public class EndorsementList : List<Endorsement>
	{
	}
}