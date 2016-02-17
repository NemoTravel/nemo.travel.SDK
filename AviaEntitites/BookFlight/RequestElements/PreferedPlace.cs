using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System;

namespace AviaEntities.BookFlight.RequestElements
{
	/// <summary>
	/// Предпочитаемое место в самолёте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class PreferedPlace
	{
		/// <summary>
		/// Для место для курящих или нет
		/// </summary>
		[DataMember(IsRequired = false, Order = 0, EmitDefaultValue = false)]
		public bool SmokingAllowed { get; set; }

		/// <summary>
		/// Предпочитаемая позиция места в ряду (в середине, у прохода, у окна)
		/// </summary>
		[DataMember(IsRequired = false, Order = 1, EmitDefaultValue = false)]
		public SeatingPlaceLocation Location { get; set; }

		/// <summary>
		/// Номер ряда
		/// </summary>
		[DataMember(IsRequired = false, Order = 2, EmitDefaultValue = false)]
		public string RowNumber { get; set; }

		/// <summary>
		/// Номер места
		/// </summary>
		[DataMember(IsRequired = false, Order = 3, EmitDefaultValue = false)]
		public string PlaceNumber { get; set; }

		/// <summary>
		/// Номер сегмента, к которому относится данное предпочитаемое место
		/// </summary>
		[DataMember(IsRequired = true, Order = 4, EmitDefaultValue = false)]
		public int SegNumber { get; set; }

		/// <summary>
		/// Проверяет указано ли специфичное место, выбранное через карту мест
		/// </summary>
		[JsonIgnore]
		[XmlIgnore]
		[IgnoreDataMember]
		public bool IsSpecific
		{
			get
			{
				return (RowNumber != null && RowNumber != "" && PlaceNumber != null && PlaceNumber != "");
			}
		}
	}
}