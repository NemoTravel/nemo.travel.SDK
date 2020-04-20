using AviaEntities.SharedElements;
using AviaEntities.v2.BookFlight;
using GeneralEntities.Shared;
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
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public bool CancelPayment { get; set; }

		/// <summary>
		/// Опции тарификации брони
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PricingOptions PricingOptions { get; set; }

		/// <summary>
		/// Теги для ЦО
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public TagList RequestorTags { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public int? RefererID { get; set; }

		[IgnoreDataMember]
		public bool NoReprice
		{
			get
			{
				return PricingOptions != null && PricingOptions.NoReprice;
			}
		}
	}
}