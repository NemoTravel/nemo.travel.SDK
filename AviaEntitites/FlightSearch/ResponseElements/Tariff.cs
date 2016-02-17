using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию об определённом тарифе из цены перелёта
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class Tariff
	{
		/// <summary>
		/// Код тарифа
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Code { get; set; }

		/// <summary>
		/// Индикатор приватности цен
		/// </summary>
		[DataMember(IsRequired = true, Order = 1)]
		public FareTypes Type { get; set; }

		/// <summary>
		/// Признак что данный тариф является системным трансфером (сквозным тарифом)
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public bool? IsSystemTransfer { get; set; }

		/// <summary>
		/// Номер сегмента
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public int? SegNum { get; set; }



		/// <summary>
		/// Код тарифа без кода скидки
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public string FareBasisCode
		{
			get
			{
				return Code.Split('/')[0];
			}
		}

		/// <summary>
		/// Установка начального/конечного города для тарифа
		/// Не сериализуется в ХМЛ
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string Market
		{
			set
			{
				DepCity = value.Substring(0, 3);
				ArrCity = value.Substring(3, 3);
				IsMarketSet = true;
			}
		}

		/// <summary>
		/// Город отправления для тарифа
		/// Не сериализуется в ХМЛ
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string DepCity { get; set; }

		/// <summary>
		/// Город прибытия для тарифа
		/// Не сериализуется в ХМЛ
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string ArrCity { get; set; }

		/// <summary>
		/// Индикатор того что это последний тариф в перелёте из БФМ результата
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public bool IsLastBFMTariff { get; set; }

		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public bool IsMarketSet { get; set; }

		/// <summary>
		/// Используется для поиска тарифных правил в ВИПСервисе
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string FBRuleKey { get; set; }

		/// <summary>
		/// Полное копирование объекта
		/// </summary>
		/// <returns>Копия данного объекта</returns>
		public Tariff FullCopy()
		{
			var result = new Tariff();

			result.ArrCity = ArrCity;
			result.Code = Code;
			result.DepCity = DepCity;
			result.FBRuleKey = FBRuleKey;
			result.IsLastBFMTariff = IsLastBFMTariff;
			result.IsMarketSet = IsMarketSet;
			result.IsSystemTransfer = IsSystemTransfer;
			result.SegNum = SegNum;
			result.Type = Type;
	
			return result;
		}
	}
}