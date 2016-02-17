using AviaEntities.BookModify.RequestElements;
using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.BookModify
{
	/// <summary>
	/// Тело запроса модификации
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookModifyRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Новая информация о пассажирах
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public PassengerModificationList Passengers { get; set; }
	}
}