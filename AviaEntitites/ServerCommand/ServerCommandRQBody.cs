using GeneralEntities;
using System.Runtime.Serialization;

namespace AviaEntities.ServerCommand
{
	/// <summary>
	/// Тело запроса на выполнение консольных команд
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ServerCommandRQBody
	{
		/// <summary>
		/// ИД источника, в котором находится данный ПНР
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int Source { get; set; }

		[DataMember(IsRequired = false, Order = 1)]
		public string SessionID { get; set; }

		/// <summary>
		/// Команда для выполнения
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public string Command { get; set; }
	}
}