using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.RequestElements
{
	[Serializable]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "AdditionalService")]
	public class BookAddtionalServices : List<BookAdditionalService>
	{
	}
}