using System.Runtime.Serialization;

namespace GeneralEntities.Services.Avia
{
	/// <summary>
	/// Содержит описание услуги перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightService : BaseService
	{
		/// <summary>
		/// Тип перелёта
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public FlightType Type { get; set; }

		/// <summary>
		/// Тип маршрута перелёта
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public FlightDirectionType DirectionType { get; set; }

		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public FlightSegmentList Segments { get; set; }

		/// <summary>
		/// Выполняет перенумерацию сегментов в соответствии с их текущим положением
		/// </summary>
		public void RenumSegments()
		{
			if (Segments != null && Segments.Count > 0)
			{
				for (int i = 0; i < Segments.Count; i++)
				{
					Segments[i].ID = i;
				}
			}
		}
	}
}