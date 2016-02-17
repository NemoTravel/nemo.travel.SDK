using AviaEntities.GetAllowedCC;
using System.Runtime.Serialization;

namespace AviaEntities.AdditionalOperations.ResponseElements
{
	/// <summary>
	/// Содержит результат получения допустимых кредитных карт
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetAllowedCCsResult
	{
		/// <summary>
		/// Список допустимых карт
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public CCCodeList AllowedCCs { get; set; }
	}
}