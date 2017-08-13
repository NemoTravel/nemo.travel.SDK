using AviaEntities.SharedElements.Ancillaries.RequestElements;
using GeneralEntities.PNRDataContent;
using System.Runtime.Serialization;

namespace AviaEntities.IssueEMD
{
	/// <summary>
	/// Тело запроса выписки допуслуги (оформление ЕМД на допуслугу)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class IssueEMDRQBody : CommonAncillaryServiceRQ
	{
		/// <summary>
		/// Опциональные данные о формы оплаты
		/// </summary>
		[DataMember(Order = 0, IsRequired = false)]
		public FOPDataItem FOPInfo { get; set; }
	}
}