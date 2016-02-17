using System.Runtime.Serialization;

namespace AviaEntities.ServerCommand
{
	/// <summary>
	/// Тело ответа на запрос выполнения консольных команд
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ServerCommandRSBody
	{
		/// <summary>
		/// Ответ на выполненнную команду
		/// </summary>
		[DataMember(IsRequired = true, Order = 0, EmitDefaultValue = false)]
		public string Response { get; set; }
	}
}