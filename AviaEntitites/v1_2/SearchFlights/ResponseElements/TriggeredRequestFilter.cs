using System.Runtime.Serialization;

namespace AviaEntities.v1_2.SearchFlights.ResponseElements
{
	[DataContract(Namespace = "http://nemo.travel/Avia")]
	public class TriggeredRequestFilter
	{
		public TriggeredRequestFilter(int filterID, bool isAllowing, int? packageID = null)
		{
			FilterID = filterID;
			IsAllowingFilter = isAllowing;
			PackageID = packageID;
		}

		[DataMember(Order = 0, IsRequired = true)]
		public int FilterID { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public bool IsAllowingFilter { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public int? PackageID { get; set; }
	}
}