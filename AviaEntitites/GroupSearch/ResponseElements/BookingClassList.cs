using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GroupSearch.ResponseElements
{
	/// <summary>
	/// Список классов бронирования для определённой цены
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "BookingClassInfo", ItemName = "BookingClass")]
	public class BookingClassList : List<BookingClassInformation>
	{
	}
}