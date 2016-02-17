using AviaEntities.AdditionalOperations.RequestElements;
using AviaEntities.v1_1.AdditionalOperations.RequestElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.AdditionalOperations
{
	/// <summary>
	/// Тело запроса на выполнение допопераций v1.1
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "AdditionalOperationsRQBody_1_1")]
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
		public AdditionalOperationsParameters OperationsRestrictions { get; set; }
	}
}