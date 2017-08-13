using GeneralEntities.PNRDataContent.Ancillary;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ReferencedBooksDataItem
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public BookIDs ParentBook { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public List<BookIDs> ChildBooks { get; set; }
	}
}