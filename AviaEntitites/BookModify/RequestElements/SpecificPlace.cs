using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Конкретное место, выбранное через карту мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SpecificPlace
	{
		/// <summary>
		/// Номер места
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string PlaceNumber { get; set; }

		/// <summary>
		/// Номер ряда
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string RowNumber { get; set; }
	}
}