using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат проверки доступности
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CheckAvailabilityResult
	{
		/// <summary>
		/// Результат проверки
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public bool IsAvail { get; set; }

		/// <summary>
		/// Дополнительная информация о статусах сегментов
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string SegmentsStatusInfo { get; set; }
	}
}