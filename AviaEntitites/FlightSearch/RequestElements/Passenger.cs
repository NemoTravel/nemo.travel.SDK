using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.RequestElements
{
	/// <summary>
	/// Содержит информацию о пассажирах, для которых выполняется поиск перелётов
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Passenger
	{
		/// <summary>
		/// Тип пассажира(-ов)
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PassTypes Type { get; set; }

		/// <summary>
		/// Количество пассажиров данного типа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int Count { get; set; }

		/// <summary>
		/// Возраст пассажира, null если не указан
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? Age { get; set; }

		/// <summary>
		/// Тип пассажира, использованый для получения его цены
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string PricedAs { get; set; }

		/// <summary>
		/// Тип документа, по которому пассажир собирается лететь
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public DocTypes? DocType { get; set; }

		/// <summary>
		/// Гражданство
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string Nationality{ get; set; }
	}
}