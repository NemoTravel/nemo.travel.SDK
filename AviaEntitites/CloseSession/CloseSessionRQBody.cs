using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.CloseSession
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class CloseSessionRQBody
	{
		/// <summary>
		/// ИД источника, в котором находится данный ПНР
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int Source { get; set; }

		[DataMember(IsRequired = true, Order = 1)]
		public string SessionID { get; set; }
	}
}