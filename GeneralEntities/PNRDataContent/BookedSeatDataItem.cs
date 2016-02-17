using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание забронированного места из карты мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BookedSeatDataItem
	{
		/// <summary>
		/// Номер места
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Характеристика места
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Characteristic { get; set; }

		/// <summary>
		/// Индикатор места для курящих
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool SmokingPreference { get; set; }

		/// <summary>
		/// Статус питания
		/// </summary>
		[DataMember(Order = 3)]
		public PNRContentStatus Status { get; set; }

		/// <summary>
		/// Код статуса
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string StatusCode { get; set; }
	}
}