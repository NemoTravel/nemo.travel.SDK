using AviaEntities.AdditionalOperations.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations
{
	/// <summary>
	/// Тело запроса на выполнение дополнительных операций над перелётов или бронью
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalOperationsRQBody
	{
		/// <summary>
		/// Объект, для которого требуется выполнить операции
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public ObjectForOperations ObjectForOperations { get; set; }

		/// <summary>
		/// Список операций, которые требуется выполнить
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public OperationList Operations { get; set; }

		/// <summary>
		/// Дополнительная информация по выполняемым операциям
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public AdditionalOperationsRestrictions OperationsRestrictions { get; set; }
	}
}