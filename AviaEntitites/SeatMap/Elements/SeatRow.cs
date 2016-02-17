using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Ряд мест
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SeatRow
	{
		/// <summary>
		/// Номер ряда
		/// </summary>
		[DataMember(IsRequired = false, Order = 0)]
		public int Num { get; set; }

		/// <summary>
		/// Места в ряду
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public SeatList Seats { get; set; }

		/// <summary>
		/// EDIFACT характеристики места
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Characteristics { get; set; }

		/// <summary>
		/// Полное копирование ряда
		/// </summary>
		/// <returns>Копия ряда</returns>
		public SeatRow Clone()
		{
			SeatRow result = new SeatRow();
			result.Num = Num;
			result.Seats = new SeatList();

			foreach (Seat seat in Seats)
			{
				result.Seats.Add(seat.Clone());
			}

			return result;
		}

		/// <summary>
		/// Получение места по его номеру
		/// </summary>
		/// <param name="seatNum">Номер места</param>
		/// <returns>Объект нужного места</returns>
		public Seat GetSeat(string seatNum)
		{
			Seat result = null;

			if (Seats != null)
			{
				result =  Seats.Find(seat => seat.Number == seatNum);
			}

			return result;
		}

		public SeatRow()
		{
			Seats = new SeatList();
		}
	}
}