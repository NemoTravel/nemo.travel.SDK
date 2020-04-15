using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Карта мест для определённого сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightSegmentSeatMap
	{
		/// <summary>
		/// Номер сегмента
		/// </summary>
		[DataMember(Name = "Num", IsRequired = true, Order = 0)]
		public int Number { get; set; }

		/// <summary>
		/// Собственно карта мест для данного сегмента
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public SeatMapFloorList Floors { get; set; }


		public FlightSegmentSeatMap()
		{
			Floors = new SeatMapFloorList();
		}

		public FlightSegmentSeatMap DeepCopy()
		{
			var result = new FlightSegmentSeatMap();

			result.Number = Number;

			foreach (var floor in Floors)
			{
				result.Floors.Add(floor.DeepCopy());
			}

			return result;
		}
	}
}