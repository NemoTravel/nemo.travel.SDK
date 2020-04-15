using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Карта мест этажа в самолёте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SeatMapFloor
	{
		/// <summary>
		/// Индикатор верхнего этажа
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public bool IsUpper { get; set; }

		/// <summary>
		/// Ряды мест
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public SeatRowList SeatRows { get; set; }


		public SeatMapFloor()
		{
			SeatRows = new SeatRowList();
		}

		public SeatMapFloor DeepCopy()
		{
			var result = new SeatMapFloor();

			result.IsUpper = IsUpper;

			foreach (var seatRow in SeatRows)
			{
				result.SeatRows.Add(seatRow.DeepCopy());
			}

			return result;
		}
	}
}