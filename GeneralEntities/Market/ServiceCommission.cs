using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Market
{
	/// <summary>
	/// Содержит описание комиссии за определённую услугу, которая используется при взаимодействии с поставщиком
	/// </summary>
	[Serializable]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class ServiceCommission
	{
		/// <summary>
		/// Сумма комиссии
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public float? Amount { get; set; }

		/// <summary>
		/// Комиссия в %
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public float? Percent { get; set; }

		/// <summary>
		/// Код валюты комиссии, актуально для суммы комиссии
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string CurrencyCode { get; set; }
	}
}