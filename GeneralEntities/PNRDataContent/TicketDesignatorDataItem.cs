using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TicketDesignatorDataItem
	{
		[DataMember(Order = 0, IsRequired = true)]
		public string Value { get; set; }

		public TicketDesignatorDataItem Copy()
		{
			var result = new TicketDesignatorDataItem();

			result.Value = Value;

			return result;
		}
	}
}