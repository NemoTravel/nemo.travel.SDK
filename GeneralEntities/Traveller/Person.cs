using GeneralEntities.Client;
using System.Runtime.Serialization;

namespace GeneralEntities.Traveller {
	[DataContract]
	public class Person {
		[DataMember]
		public PersonalInformation PersonalInfo { get; set; }

		[DataMember]
		public ContactInfo ContactInfo { get; set; }

		[DataMember]
		public DocumentInformation DocInfo { get; set; }
	}
}
