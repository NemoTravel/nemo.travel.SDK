using AviaEntities.v1_1.FlightSearch.ResponseElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetFareFamilies
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetFareFamiliesRSBody
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public FlightList FlightsByFareFamily { get; set; }
	}
}