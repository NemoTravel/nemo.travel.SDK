using System.Runtime.Serialization;

namespace AviaEntities.Ticketing.RequestElements
{
	/// <summary>
	/// Содержит описание для тестово-отладочных параметров
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TestMode
	{
		/// <summary>
		/// Проставление кредитной карты в качестве фопа в ПНР
		/// </summary>
		[DataMember(Order = 0)]
		public bool StoredCCFOP { get; set; }
	}
}