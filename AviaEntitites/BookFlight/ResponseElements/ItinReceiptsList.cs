using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.ResponseElements
{
	/// <summary>
	/// Список маршрутных квитанций
	/// </summary>
	[Serializable]
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ItinReceiptsList", ItemName = "Receipt")]
	public class ItinReceiptsList : List<ItinReceipts>
	{
	}
}
