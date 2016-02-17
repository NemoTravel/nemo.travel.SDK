using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о маршрут квитанции от ГДС
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ItinReceipt
	{
		/// <summary>
		/// Кодировка маршрут квитанции
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Encoding { get; set; }

		/// <summary>
		/// Формат маршрут квитанции
		/// </summary>
		[DataMember(IsRequired = true, Order = 1, EmitDefaultValue = false)]
		public string Format { get; set; }

		/// <summary>
		/// Собственно текст маршрут квитанции
		/// </summary>
		[DataMember(IsRequired = true, Order = 2, EmitDefaultValue = false)]
		public string Text { get; set; }
	}
}