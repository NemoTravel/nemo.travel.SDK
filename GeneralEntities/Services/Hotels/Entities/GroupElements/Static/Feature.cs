using System.Runtime.Serialization;

namespace GeneralEntities.Services.Hotels.Entities.GroupElements.Static
{
	[DataContract(Namespace = "http://nemo-ibe.com/Hotels")]
	public class Feature
	{
		[DataMember(Order = 0, IsRequired = false)]
		public HotelsFeatures? Id { get; set; }

		[DataMember(Order = 1, IsRequired = false)]
		public string Info { get; set; }
	}
}
