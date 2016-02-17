using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetAllowedCC
{
	/// <summary>
	/// Содержит описание ответа на запрос получения списка допустимых кредитных карт для ГДС процессинга оплаты указанной брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetAllowedCCRSBody : OnlyBookIDElement
	{
		/// <summary>
		/// Список допустимых карт
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public CCCodeList AllowedCCs { get; set; }
	}
}