using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.RequestElements
{
	/// <summary>
	/// Содержит описание для запрошенной точки путешествия
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class RequestedTripPoint
	{
		/// <summary>
		/// Код точки путешествия
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Признак что указан код конкретного аэропорта
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool IsCity { get; set; }

		public RequestedTripPoint FullCopy()
		{
			var result = new RequestedTripPoint();
			result.Code = Code;
			result.IsCity = IsCity;
			return result;
		}
	}
}