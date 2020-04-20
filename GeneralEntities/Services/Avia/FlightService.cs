using GeneralEntities.Shared.BusinessRules;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Avia
{
	/// <summary>
	/// Содержит описание услуги перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightService : BaseService
	{
		/// <summary>
		/// Тип перелёта
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public FlightType Type { get; set; }

		/// <summary>
		/// Тип маршрута перелёта
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public FlightDirectionType DirectionType { get; set; }

		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public FlightSegmentList Segments { get; set; }

		/// <summary>
		/// Индикатор группового заказа
		/// </summary>
		[DataMember(Order = 3, IsRequired = false)]
		public bool GroupOrder { get; set; }

		/// <summary>
		/// Набор применимых бизнес правил
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public BusinessRulesCollection BusinessRules { get; set; }
	}
}