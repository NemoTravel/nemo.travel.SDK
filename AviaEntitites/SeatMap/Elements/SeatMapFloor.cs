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
		/// Схема ряда с параметрами по умолчанию
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public SeatRow DefaultRow { get; set; }

		/// <summary>
		/// Ряды мест
		/// </summary>
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public SeatRowList SeatRows { get; set; }


		public SeatMapFloor()
		{
			SeatRows = new SeatRowList();
		}
	}
}