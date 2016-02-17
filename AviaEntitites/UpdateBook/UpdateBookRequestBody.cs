using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.UpdateBook
{
	/// <summary>
	/// Тело запроса на обновление брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class UpdateBookRequestBody : OnlyBookIDElement
	{
		/// <summary>
		/// Признак типа обновления, лёгкое или полное
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool Light { get; set; }

		/// <summary>
		/// Отмена предыдущей оплаты заказа, специфично для Сирены
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool CancelPayment { get; set; }
	}
}