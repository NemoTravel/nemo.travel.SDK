using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.LinkedBookInfo
{
	[DataContract(Namespace = "http://nemo.travel/STL")]
	public class IDLink<T> where T : IComparable
	{
		[DataMember(Order = 0)]
		public T GlobalID { get; set; }

		[DataMember(Order = 1)]
		public T OriginalID { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as IDLink<T>;
			if (other == null)
			{
				return false;
			}

			return other.GlobalID.CompareTo(GlobalID) == 0 && other.OriginalID.CompareTo(OriginalID) == 0;
		}

		public IDLink<T> Copy()
		{
			var result = new IDLink<T>();

			result.GlobalID = GlobalID;
			result.OriginalID = OriginalID;

			return result;
		}
	}
}