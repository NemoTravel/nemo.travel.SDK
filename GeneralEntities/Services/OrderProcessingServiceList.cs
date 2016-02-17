using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Массив услуг по обработке заказа
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Service")]
	public class OrderProcessingServiceList : List<OrderProcessingService>
	{
	}
}