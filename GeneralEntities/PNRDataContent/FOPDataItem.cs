using GeneralEntities.PNRDataContent.FOP;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание формы оплаты
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FOPDataItem
	{
		/// <summary>
		/// ФОПы
		/// </summary>
		[DataMember(Order = 0,IsRequired = true)]
		public FOPList FOPs { get; set; }

		/// <summary>
		/// Признак смешанной формы оплаты
		/// </summary>
		[IgnoreDataMember]
		public bool IsMixedFOP
		{
			get
			{
				return FOPs.Select(fop => fop.Type).Distinct().Count() > 1;
			}
		}
	}
}