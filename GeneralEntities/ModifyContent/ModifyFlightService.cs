using GeneralEntities.ModifyContent.Avia;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	/// <summary>
	/// Содержит описание данных для модификации перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ModifyFlightService
	{
		/// <summary>
		/// Модифицируемые сегменты
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public ModifyFlightSegmentList Segments { get; set; }
	}
}