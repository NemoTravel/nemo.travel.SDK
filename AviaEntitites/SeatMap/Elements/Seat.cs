using GeneralEntities.Market;
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
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }

		/// <summary>
		/// Тип места
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Type { get; set; }

		/// <summary>
		/// Характеристика места
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Characteristics { get; set; }

		/// <summary>
		/// Индикатор, указывающий свободно ли место
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public bool IsFree { get; set; }

		/// <summary>
		/// Стоимость бронирования данного места
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public Money Price { get; set; }

		/// <summary>
		/// Признак того что кресла на данном месте не существует
		/// </summary>
		[DataMember(Order = 5, IsRequired = true)]
		public bool NotExists { get; set; }

		/// <summary>
		/// RFISC допулсгуи ассоциированной с местом
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string RFISC { get; set; }


		/// <summary>
		/// Копирование объекта места
		/// </summary>
		/// <returns>Копия места</returns>
		public Seat Clone()
		{
			var result = new Seat();

			result.Number = Number;
			result.Type = Type;
			result.Characteristics = Characteristics;
			result.IsFree = IsFree;
			result.NotExists = NotExists;
			result.RFISC = RFISC;

			if (result.Price != null)
			{
				result.Price = new Money(Price);
			}

			return result;
		}
	}
}