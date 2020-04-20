using AviaEntities.SharedElements;
using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace AviaEntities.SplitBook
{
	/// <summary>
	/// Запрос на разделение брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SplitBookRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Пассажиры, которых необходимо отделить в другую бронь
		/// </summary>
		[DataMember(Name = "Passengers", IsRequired = true)]
		public RefList<int> Travellers { get; set; }
	}
}