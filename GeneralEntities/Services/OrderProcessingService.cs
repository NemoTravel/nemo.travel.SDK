using GeneralEntities.Shared;
using System.Runtime.Serialization;

namespace GeneralEntities.Services
{
	/// <summary>
	/// Содержит описание услуги по обработке заказа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class OrderProcessingService : ItemIdentification<int>
	{
		/// <summary>
		/// Тип обработки заказа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public OrderProcessingType Type { get; set; }

		/// <summary>
		/// Статус данной услуги
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public OrderProcessingStatus Status { get; set; }

		/// <summary>
		/// ИД правила, по которому была сформирована цена данной услуги
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string RuleID { get; set; }
	}
}