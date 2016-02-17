using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Список маршрутных квитанций
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ItinReceiptList", ItemName = "Receipt")]
	public class ItinReceiptList : List<ItinReceipt>
	{
	}
}