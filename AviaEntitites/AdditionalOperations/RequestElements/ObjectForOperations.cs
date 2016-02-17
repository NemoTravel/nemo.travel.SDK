using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.RequestElements
{
	/// <summary>
	/// Содержит ИД объекта, для которого будут выполняться операции
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ObjectForOperations
	{
		/// <summary>
		/// ИД перелёта
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string FlightID { get; set; }

		/// <summary>
		/// ИД брони
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public long? BookID { get; set; }
	}
}