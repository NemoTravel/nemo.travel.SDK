using AviaEntities.SharedElements.Ancillaries.RequestElements;
using GeneralEntities.ModifyContent;
using System.Runtime.Serialization;

namespace AviaEntities.ModifyContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class ModifyAncillaryService : BaseModifyItem
	{
		[DataMember(Order = 1, IsRequired = true)]
		public AncillaryServiceRQ AncillaryService { get; set; }
	}
}