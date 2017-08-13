using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.SharedElements.Ancillaries.RequestElements
{
	/// <summary>
	/// Элемент ссылок допуслуг
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AncillaryService
	{
		/// <summary>
		/// ИД допуслуги
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int ServiceRef { get; set; }

		/// <summary>
		/// Мульти-ссылки на сегменты
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public MRefList<int> SegmentRef { get; set; }
	}
}