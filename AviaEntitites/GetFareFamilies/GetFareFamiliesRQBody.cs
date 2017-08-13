using AviaEntities.SharedElements;
using System.Runtime.Serialization;

namespace AviaEntities.GetFareFamilies
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetFareFamiliesRQBody : OnlyFlightIDElement
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public bool ListFaresIfNoFamiliesDifined { get; set; }
	}
}