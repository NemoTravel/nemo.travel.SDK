using AviaEntities.SharedElements;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace AviaEntities.AddInformation
{
	/// <summary>
	/// Тело запроса на добавление новой информации о пассажирах
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AddInformationRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Тип действия при конфликте добавления
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public AddInformationConflictResolving ConflictResolvingType { get; set; }

		/// <summary>
		/// Массив добавляемой информации
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public AddableInformationList InformationToAdd { get; set; }
	}
}