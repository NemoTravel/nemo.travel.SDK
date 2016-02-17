using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	/// <summary>
	/// Информация об источнике создания заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class OrderSourceInfo
	{
		/// <summary>
		/// Версия движка бронирования
		/// </summary>
		[DataMember(Order = 0)]
		public OrderEngineVersion EngineVersion { get; set; }

		/// <summary>
		/// ID владельца брони
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public int OwnerID { get; set; }

		/// <summary>
		/// Иерархия пользователя
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public UserHierarchy UserHierarchy { get; set; }

		/// <summary>
		/// УТМ сорс
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string UTMSource { get; set; }
	}
}