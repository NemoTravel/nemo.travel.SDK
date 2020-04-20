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
		/// Номер места.
		/// Ряд+место, например 11B
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

		/// <summary>
		/// RFISC допулсгуи ассоциированной с местом
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string RFISC { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as BookedSeatDataItem;
			if (other == null)
			{
				return false;
			}

			return Number == other.Number && Characteristic == other.Characteristic && SmokingPreference == other.SmokingPreference &&
					Status == other.Status && StatusCode == other.StatusCode && RFISC == other.RFISC;
		}

		public BookedSeatDataItem Copy()
		{
			var result = new BookedSeatDataItem();

			result.Number = Number;
			result.Characteristic = Characteristic;
			result.SmokingPreference = SmokingPreference;
			result.Status = Status;
			result.StatusCode = StatusCode;
			result.RFISC = RFISC;

			return result;
		}
	}
}