using System.Runtime.Serialization;

namespace AviaEntities.GetRoutingGrid
{
	/// <summary>
	/// Запрос на получение маршрутной сетки
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetRoutingGridRQBody
	{
		/// <summary>
		/// ИД пакета
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public int SourceID { get; set; }

		/// <summary>
		/// Код а/к
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string AirlineCode { get; set; }

		/// <summary>
		/// Ограничение на глубину поиска при построении маршрутной сетки
		/// <para>Значение параметра равное нулю или единце отключает построение маршрутной сетки (В ответе будет только сетка от поставщика)</para>
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public int DepthLimit { get; set; }

		/// <summary>
		/// Разрешение на смену аэропорта в точке(городе) маршрута
		/// </summary>
		[DataMember(Order = 3)]
		public bool AllowAirportChange { get; set; }
	}
}
