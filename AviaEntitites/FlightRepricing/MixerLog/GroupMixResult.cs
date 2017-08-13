using System;
using System.Runtime.Serialization;
using System.Text;

namespace AviaEntities.FlightRepricing.MixerLog
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GroupMixResult
	{
		[DataMember(Order = 0)]
		public int GroupID { get; set; }

		[DataMember(Order = 1)]
		public int MixingRuleID { get; set; }

		[DataMember(Order = 2)]
		public string Airline { get; set; }

		[DataMember(Order = 3)]
		public string MixingCode { get; set; }

		[DataMember(Order = 4)]
		public FlightsMixResults Flights { get; set; }

		public GroupMixResult()
		{
			Flights = new FlightsMixResults();
		}

		internal string Dump()
		{
			var logBuilder = new StringBuilder();

			logBuilder.
				Append(GroupID).
				Append(';').
				Append(MixingRuleID).
				Append(';').
				Append(Airline).
				Append(';').
				Append(MixingCode).
				Append(';').
				AppendLine();
			foreach(var flight in Flights)
			{
				logBuilder.Append(';', 4).AppendLine(flight.Dump());
			}

			return logBuilder.ToString();
		}
	}
}