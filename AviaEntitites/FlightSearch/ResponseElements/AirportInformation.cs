using System;
using System.Runtime.Serialization;

namespace AviaEntities.FlightSearch.ResponseElements
{
	/// <summary>
	/// Информация об аэропорте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[Serializable]
	public class AirportInformation
	{
		/// <summary>
		/// Код аэропорта
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string AirportCode { get; set; }

		/// <summary>
		/// Код города, в котором находится аэропорт (дефакто агрегатор)
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string CityCode { get; set; }

		/// <summary>
		/// Часовой пояс данного аэропорта
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string UTC { get; set; }

		/// <summary>
		/// Терминал в аэропорту
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string Terminal { get; set; }
	}
}