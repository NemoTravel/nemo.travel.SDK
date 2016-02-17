using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.v2.UpdateBook
{
	/// <summary>
	/// Тело запроса на обновление брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "UpdateBookRQBody_2_0")]
	public class UpdateBookRQBody : OnlyBookIDElement
	{
		/// <summary>
		/// Отмена предыдущей оплаты заказа, специфично для Сирены
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool CancelPayment { get; set; }
	}
}