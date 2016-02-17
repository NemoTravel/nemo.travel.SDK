using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Информация о классе перелёта для определённого сегмента перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookingClassInformation : BookingClass 
	{
		/// <summary>
		/// Номер сегмента в перелёте
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public long SegmentNumber { get; set; }
	}
}