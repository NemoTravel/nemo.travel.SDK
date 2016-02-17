using GeneralEntities.Market;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.Ticketing.RequestElements
{
	/// <summary>
	/// Контейнер для блока информации о комиссии
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "ComissionInfo_1_1")]
	public class ComissionInfo
	{
		/// <summary>
		/// Комиссия а/к
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public ServiceCommission AirlineComission { get; set; }

		/// <summary>
		/// Собственная субагентская комиссия (часть от комиссии а/к)
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public ServiceCommission SelfSubagentComission { get; set; }
	}
}