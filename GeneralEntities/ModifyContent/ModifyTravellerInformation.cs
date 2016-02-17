using GeneralEntities.Traveller;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	/// <summary>
	/// Содержит описание данных для модификации пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ModifyTravellerInformation : BaseModifyItem
	{
		/// <summary>
		/// Изменяемый элемент
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public TravellerInformation Traveller { get; set; }
	}
}