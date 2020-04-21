using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.Ancillary.FareRulesInfo
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class TimeBasedFareRule<T> where T : ICloneable
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public T AnyTime { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public T BeforeDeparture { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public T AfterDeparture { get; set; }

		public override bool Equals(object obj)
		{
			var other = obj as TimeBasedFareRule<T>;
			if (other == null)
			{
				return false;
			}

			return Equals(AnyTime, other.AnyTime) && Equals(BeforeDeparture, other.BeforeDeparture) && Equals(AfterDeparture, other.AfterDeparture);
		}

		public TimeBasedFareRule<T> Copy()
		{
			var result = new TimeBasedFareRule<T>();

			if (AnyTime != null)
			{
				result.AnyTime = (T)AnyTime.Clone();
			}

			if (BeforeDeparture != null)
			{
				result.BeforeDeparture = (T)BeforeDeparture.Clone();
			}

			if (AfterDeparture != null)
			{
				result.AfterDeparture = (T)AfterDeparture.Clone();
			}

			return result;
		}
	}
}