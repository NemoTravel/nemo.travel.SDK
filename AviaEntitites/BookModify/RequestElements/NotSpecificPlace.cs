using System.Runtime.Serialization;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Неконкретное предпочитаемое место
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class NotSpecificPlace
	{
		/// <summary>
		/// Индикатор места для курящих
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public bool SmokingAllowed { get; set; }

		/// <summary>
		/// Положение места в ряду
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public SeatingPlaceLocation Location { get; set; }
	}
}