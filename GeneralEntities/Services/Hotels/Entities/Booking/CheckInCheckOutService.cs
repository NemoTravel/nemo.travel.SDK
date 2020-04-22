using System.Runtime.Serialization;

namespace GeneralEntities.Services.Hotels.Entities.Booking
{
	[DataContract(Namespace = "http://nemo-ibe.com/Hotels")]
	public class CheckInCheckOutService : CheckInCheckOutOffer
	{
		[DataMember(Order = 0, IsRequired = false)]
		public bool? IsConfirmed { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public bool IsCritical { get; set; }
	}
}