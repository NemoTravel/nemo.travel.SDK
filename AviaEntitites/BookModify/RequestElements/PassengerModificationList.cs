using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Список модифицируемой информации о пассажирах
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "Passengers", ItemName = "Passenger")]
	public class PassengerModificationList : List<TravellerModifyInfo>
	{
	}
}