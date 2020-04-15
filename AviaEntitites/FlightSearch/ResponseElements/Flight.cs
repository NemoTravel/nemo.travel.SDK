using GeneralEntities.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит перелёт - один из результатов поиск
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class Flight : ItemIdentification<string>
	{
		/// <summary>
		/// ИД пакета реквизитов, из которого был получен данный перелёт
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public int SourceID { get; set; }

		/// <summary>
		/// Информация о типизации данного перелёта по различным критериям
		/// </summary>
		[DataMember(Order = 2)]
		public FlightTypeInfo TypeInfo { get; set; }

		/// <summary>
		/// Валидирующий перевозчик данного перелёта
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string ValCompany { get; set; }

		/// <summary>
		/// Сегменты перелёта
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public CompleteSegmentList Segments { get; set; }

		/// <summary>
		/// Цены перелёта
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public Price Price { get; set; }

		/// <summary>
		/// Содержит некие идентификаторы данного перелёта в системах поставщиков, необходимые для дальнейших операций с ним (бронирование или ещё что-то)
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public FlightSupplierLinkageInfo SupplierLinkageInfo { get; set; }

		/// <summary>
		/// Создаёт экземпляр класса с инициализацией полей
		/// </summary>
		public Flight()
		{
			Segments = new CompleteSegmentList();
			TypeInfo = new FlightTypeInfo();
		}

		/// <summary>
		/// Выполняет полное копирование объекта
		/// </summary>
		/// <returns>Результат копирования</returns>
		public Flight Copy()
		{
			var result = new Flight();

			result.SourceID = SourceID;
			result.ValCompany = ValCompany;
			result.ID = ID;

			if (SupplierLinkageInfo != null)
			{
				result.SupplierLinkageInfo = new FlightSupplierLinkageInfo();
				result.SupplierLinkageInfo.SIGSessionID = SupplierLinkageInfo.SIGSessionID;
				result.SupplierLinkageInfo.SIGShopOptionRef = SupplierLinkageInfo.SIGShopOptionRef;
				result.SupplierLinkageInfo.VariantID = SupplierLinkageInfo.VariantID;

				if (SupplierLinkageInfo.SIGItineraryRefs != null)
				{
					result.SupplierLinkageInfo.SIGItineraryRefs = new List<string>();
					result.SupplierLinkageInfo.SIGItineraryRefs.AddRange(SupplierLinkageInfo.SIGItineraryRefs);
				}
			}

			if (TypeInfo != null)
			{
				result.TypeInfo = new FlightTypeInfo();
				result.TypeInfo.Type = TypeInfo.Type;
				result.TypeInfo.DirectionType = TypeInfo.DirectionType;
				result.TypeInfo.MultyOWLeg = TypeInfo.MultyOWLeg;
			}

			result.Price = Price.Copy();
			foreach (var seg in Segments)
			{
				result.Segments.Add(seg.FullCopy());
			}

			return result;
		}

		/// <summary>
		/// Проводит нумерацию сегментов
		/// </summary>
		public void ReNumSegments()
		{
			for (int i = 1; i <= Segments.Count; i++)
			{
				Segments[i - 1].ID = i;
			}
		}

		/// <summary>
		/// Ид записи на кэш сервере, в которой хранится данный перелёт
		/// </summary>
		public long CacheID { get; set; }
	}
}