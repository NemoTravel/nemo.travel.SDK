using GeneralEntities.Traveller;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.BookFlight.RequestElements
{
	/// <summary>
	/// Информация о пассажире, для которого будет создаваться бронь
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class Traveller : TravellerInfo
	{
		/// <summary>
		/// Предпочитаемые места в самолёте
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public List<PreferedPlace> PreferedPlaces { get; set; }

		/// <summary>
		/// Предпочитаемое питание пассажира в самолёте
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public string Meal { get; set; }

		/// <summary>
		/// Бронируемые допуслуги
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public BookAddtionalServices AddtionalServices { get; set; }

		/// <summary>
		/// Получение предпочитаемого места для определённого сегмента
		/// </summary>
		/// <param name="segNum">Номер сегмента(нумерация с 1)</param>
		/// <returns>Предпочитаемое место для указанного сегмента</returns>
		public PreferedPlace GetPlaceForSegNum(int segNum)
		{
			if (PreferedPlaces != null)
			{
				return PreferedPlaces.Find(pp => pp.SegNumber == segNum);
			}
			else
			{
				return null;
			}
		}
	}
}