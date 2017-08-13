using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.RequestElements
{
	/// <summary>
	/// Общий запрос для работы с допуслугами в брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CommonAncillaryServiceRQ : OnlyBookIDElement
	{
		/// <summary>
		/// Список элементов ссылок допуслуг
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public List<AncillaryService> AncillaryServices { get; set; }
	}
}