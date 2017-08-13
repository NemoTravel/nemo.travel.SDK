using GeneralEntities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.Services.Ancillary
{
	/// <summary>
	/// Описание авиа допуслуги.
	/// Сгрупированный относительно пассажира и данных допуслуги контейнер для нескольких допуслуг из ПНР
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FlightAncillaryService : BaseService
	{
		/// <summary>
		/// Отношение [ИД допуслуги в ПНР][ИД сегмента]
		/// Может содержать повторяющиеся допуслуги на одном сегменте
		/// </summary>
		[IgnoreDataMember]
		private Dictionary<string, int> linkage;


		/// <summary>
		/// Признак бесплатности услуг (оформление EMD не требуется)
		/// </summary>
		[IgnoreDataMember]
		public bool IsFree { get; set; }

		/// <summary>
		/// ИД всех допуслуг в ПНР, которые содержатся в данной допуслуге
		/// </summary>
		[IgnoreDataMember]
		public List<string> IDInPNR
		{
			get { return new List<string>(linkage.Keys); }
		}


		/// <summary>
		/// Мульти-ссылки на сегменты перелёта, для которых приобрели услуги
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public MRefList<int> SegmentRef { get; set; }

		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public string CompanyCode { get; set; }

		/// <summary>
		/// Описание допуслуг
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Код типа допуслуг
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TypeCode { get; set; }

		/// <summary>
		/// Код типа допуслуг
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string RFIC { get; set; }

		/// <summary>
		/// Подкод типа допуслуг
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string RFISC { get; set; }

		/// <summary>
		/// Код SSRки данных допуслуг
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string SSRCode { get; set; }

		/// <summary>
		/// Текст SSRки данных допуслуг
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public string SSRText { get; set; }


		public FlightAncillaryService()
		{
			linkage = new Dictionary<string, int>();
		}


		/// <summary>
		/// Получение хэша для группировки допуслуг.
		/// Группировка производится относительноп пассажира и данных допуслуги
		/// </summary>
		/// <returns>Хэш группировки</returns>
		public int ComputeGroupingHashCode()
		{
			// Если в клиентском коде не была указана ссылка на пассажира, заваливаем вычесление
			// т.к. без указания ссылки на пассажира хэш не будет валидным
			if (TravellerRef.Count == 0)
				throw new ArgumentException("TravellerRef");

			if (Name == null)
				throw new ArgumentException("Name");

			if (RFIC == null)
				throw new ArgumentException("RFIC");

			if (RFISC == null)
				throw new ArgumentException("RFISC");

			if (CompanyCode == null)
				throw new ArgumentException("CompanyCode");

			unchecked
			{
				var hash =
					TravellerRef[0] +
					Name.GetHashCode() +
					RFIC.GetHashCode() +
					RFISC.GetHashCode() +
					IsFree.GetHashCode() +
					Status.GetHashCode() +
					CompanyCode.GetHashCode();

				if (SSRCode != null)
				{
					hash += SSRCode.GetHashCode();
				}

				if (SSRText != null)
				{
					hash += SSRText.GetHashCode();
				}

				if (TypeCode != null)
				{
					hash += TypeCode.GetHashCode();
				}

				return hash;
			}
		}

		/// <summary>
		/// Определят содержится ли в данной услуге переданная услуга из ПНР
		/// </summary>
		/// <param name="idInPNR">ИД допуслуги из ПНР</param>
		/// <returns></returns>
		public bool IsContainerFor(string idInPNR)
		{
			return linkage.ContainsKey(idInPNR);
		}

		/// <summary>
		/// Получение номера сегмента по ИД услуги из ПНР
		/// </summary>
		/// <param name="idInPNR">ИД услуги в ПНР</param>
		/// <returns>Номер сегмента</returns>
		public int GetSegmentFor(string idInPNR)
		{
			return linkage[idInPNR];
		}

		/// <summary>
		/// Получение всех ИД в ПНР для допуслуг на определенных мульти-сегментах
		/// </summary>
		/// <param name="segmentRefs">Мульти-ссылки на сегменты</param>
		/// <returns></returns>
		public List<string> GetIDInPNRFor(MRefList<int> segmentRefs)
		{
			var result = new List<string>();

			foreach (var segmentRef in segmentRefs)
			{
				result.AddRange(GetIDInPNRFor(segmentRef));
			}

			return result;
		}

		/// <summary>
		/// Получение всех ИД в ПНР для допуслуг на определенном мульти-сегменте
		/// </summary>
		/// <param name="segmentRef">Мульти-ссылка на сегмент</param>
		/// <returns></returns>
		public HashSet<string> GetIDInPNRFor(int segmentRef)
		{
			var result = new HashSet<string>();

			foreach (var kvp in linkage)
			{
				if (kvp.Value == segmentRef)
				{
					result.Add(kvp.Key);
				}
			}

			return result;
		}

		/// <summary>
		/// Добавляет новую связь [ИД услуги в ПНР][ИД сегмента]
		/// </summary>
		/// <param name="idInPNR"></param>
		/// <param name="segmentRef"></param>
		public void AddLink(string idInPNR, int segmentRef)
		{
			linkage.Add(idInPNR, segmentRef);
		}

		/// <summary>
		/// Добавляет новый ИД допуслуги в ПНР без привязки к сегменту
		/// (Случай допуслуги без привязки к сегменту)
		/// </summary>
		/// <param name="idInPNR"></param>
		public void AddIDInPNR(string idInPNR)
		{
			linkage.Add(idInPNR, -1);
		}
	}
}