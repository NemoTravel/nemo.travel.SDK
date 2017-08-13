using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class NumberedFOP : BaseFOP
	{
		/// <summary>
		/// Номер ФОПа в ПНРе
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Number { get; set; }
	}
}