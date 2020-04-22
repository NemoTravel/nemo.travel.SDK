using GeneralEntities;
using System.Runtime.Serialization;
using AviaEntities.SharedElements.Ancillaries.RequestElements;

namespace AviaEntities.v1_2.AdditionalOperations.RequestElements
{
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public class SelectedAncillaryService : AncillaryServiceRQ
	{
		[DataMember(Order = 0, IsRequired = true)]
		public PassTypes PassengerType { get; set; }


		public new SelectedAncillaryService DeepCopy()
		{
			var result = new SelectedAncillaryService();

			base.CopyTo(result);

			result.PassengerType = PassengerType;

			return result;
		}
	}
}