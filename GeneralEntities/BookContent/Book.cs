using GeneralEntities.PNRDataContent;
using GeneralEntities.PriceContent;
using GeneralEntities.Services;
using GeneralEntities.Shared;
using GeneralEntities.Traveller;
using System.Runtime.Serialization;

namespace GeneralEntities.BookContent
{
	/// <summary>
	/// Содержит описание брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Book : ItemIdentification<long>
	{
		/// <summary>
		/// ID владельца брони
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int OwnerID { get; set; }

		/// <summary>
		/// Информация о времени возникновения различных события с бронью
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public BookDateInfo DateInfo { get; set; }

		/// <summary>
		/// Список допустимых действий с бронь
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public PNRPossibleActionList PossibleActions { get; set; }

		/// <summary>
		/// Информация о клиентах
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public TravellerList Travellers { get; set; }

		/// <summary>
		/// Забронированные услуги
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public ServiceList Services { get; set; }

		/// <summary>
		/// Забронированные допуслуги
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public ServiceList AncillaryServices { get; set; }

		/// <summary>
		/// Цена брони
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public Price Price { get; set; }

		/// <summary>
		/// Унифицированные данные брони
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }
	}
}
