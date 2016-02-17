using System;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.RequestElements
{
	/// <summary>
	/// Бронируемая допуслуга
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookAdditionalService
	{
		/// <summary>
		/// Номер допуслуги, по которому её требуется забронировать
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int Number { get; set; }

		/// <summary>
		/// Количество единиц данной допуслуги
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int Count { get; set; }

		/// <summary>
		/// Описание для SSRки для данной допуслуги
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Description { get; set; }
	}
}