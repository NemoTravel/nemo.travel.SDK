using GeneralEntities;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace AviaEntities.OpenSession
{
	/// <summary>
	/// Тело запроса на открытие сессии
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class OpenSessionRQBody
	{
		/// <summary>
		/// ИД источника, в котором находится данный ПНР
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int Source { get; set; }

		/// <summary>
		/// Признак открытия полностью новой сессии с ГДС
		/// </summary>
		[DataMember(IsRequired = false, Order = 1, EmitDefaultValue = true)]
		[DefaultValue(false)]
		public bool FullyNew { get; set; }
	}
}