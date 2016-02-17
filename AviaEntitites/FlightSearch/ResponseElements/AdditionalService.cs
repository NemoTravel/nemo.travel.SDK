using GeneralEntities;
using GeneralEntities.Market;
using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Содержит информацию об определённой допуслуге
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalService
	{
		/// <summary>
		/// Номер допуслуги, по которому её можно будет купить
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public int Number { get; set; }

		/// <summary>
		/// Код типа допуслуги
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Code { get; set; }

		/// <summary>
		/// Описание допуслуги
		/// </summary>
		[DataMember(Order = 2)]
		public string Name { get; set; }

		/// <summary>
		/// ИАТА код а/к, предоставляющей данную допуслугу
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string AircompanyCode { get; set; }

		/// <summary>
		/// Стоимость данной услуги
		/// </summary>
		[DataMember(Order = 4)]
		public Money Price { get; set; }

		/// <summary>
		/// Тип возвратности для данной допуслуги
		/// </summary>
		[DataMember(Order = 5)]
		public RefundableEnum Refund { get; set; }

		/// <summary>
		/// Признак необходимости оплаты ГДС процессингом данной услуги
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public bool CCFOPRequired { get; set; }

		/// <summary>
		/// Код SSRки, для которое требуется описание от юзера
		/// </summary>
		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string RequierDescriptionForSSR { get; set; }

		/// <summary>
		/// Код SSRки, которую необходимо добавить в ПНР в случае покупки данной допуслуги
		/// </summary>
		[XmlIgnore]
		[IgnoreDataMember]
		[JsonProperty]
		public string RequieredSSR { get; set; }
	}
}