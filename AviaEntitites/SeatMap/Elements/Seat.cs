using System.Runtime.Serialization;

namespace AviaEntities.SeatMap.Elements
{
	/// <summary>
	/// Место в самолёте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Seat
	{
		/// <summary>
		/// Номер места
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Number { get; set; }

		/// <summary>
		/// Тип места
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public string Type { get; set; }

		/// <summary>
		/// Характеристика места
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Characteristics { get; set; }

		/// <summary>
		/// Индикатор, указывающий свободно ли место
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public bool IsFree { get; set; }

		/// <summary>
		/// Копирование объекта места
		/// </summary>
		/// <returns>Копия места</returns>
		public Seat Clone()
		{
			return (Seat)MemberwiseClone();
		}
	}
}