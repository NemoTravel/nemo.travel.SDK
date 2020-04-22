using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Hotels
{
	[DataContract(Namespace = "http://nemo-ibe.com/Hotels")]
	public class CheckInCheckOutOffer
	{
		/// <summary>
		/// Время в формате HH:mm
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Time { get; set; }

		/// <summary>
		/// Цена
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public Money Price { get; set; }

		/// <summary>
		/// Текст
		/// </summary>
		[DataMember(Order = 2, IsRequired = false)]
		public string Description { get; set; }

		/// <summary>
		/// Признак гарантии
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public bool Guaranteed { get; set; }

		/// <summary>
		/// Правило 
		/// </summary>
		[DataMember(Order = 4, IsRequired = true)]
		public PriceRule PriceRule { get; set; }
	}
}