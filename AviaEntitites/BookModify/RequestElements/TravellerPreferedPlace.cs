using System.Runtime.Serialization;
using AviaEntities.BookFlight.RequestElements;

namespace AviaEntities.BookModify.RequestElements
{
	/// <summary>
	/// Новая информация о предпочитаемом месте пассажира
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class TravellerPreferedPlace
	{
		/// <summary>
		/// Номер сегмента, к которому относится изменяемое место
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public int SegNum { get; set; }

		/// <summary>
		/// Новая информация о конкретном месте, выбранном через карту мест
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public SpecificPlace NewSpecificPlace { get; set; }

		/// <summary>
		/// Новая информация о неконкретном предпочитаемом месте
		/// </summary>
		[DataMember(IsRequired = true, Order = 2)]
		public NotSpecificPlace NewNotSpecificPlace { get; set; }

		/// <summary>
		/// Создание места для модификации заполняя недостающие данные из старого объекта,
		/// Если не один из типов мест не указан для модификации, то возвращается null
		/// </summary>
		/// <returns>Созданный объект</returns>
		public PreferedPlace CreatePlaceForModify()
		{
			PreferedPlace res = null;

			if (NewNotSpecificPlace != null)
			{
				res = new PreferedPlace();
				res.SmokingAllowed = NewNotSpecificPlace.SmokingAllowed;
				res.Location = NewNotSpecificPlace.Location;
			}

			if (NewSpecificPlace != null)
			{
				if (res == null)
				{
					res = new PreferedPlace();
				}
				res.PlaceNumber = NewSpecificPlace.PlaceNumber;
				res.RowNumber = NewSpecificPlace.RowNumber;
			}

			if (res != null)
			{
				res.SegNumber = SegNum;
			}

			return res;
		}
	}
}