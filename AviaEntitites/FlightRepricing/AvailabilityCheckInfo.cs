using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.FlightRepricing
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "CurrencyGroup", KeyName = "Currency", ValueName = "NotAvailableSources")]
	public class AvailabilityCheckInfo : Dictionary<string, IDList<int>>
	{
		public void Add(string currency, int sourceID)
		{
			if (!this.ContainsKey(currency))
			{
				this[currency] = new IDList<int>();
			}

			this[currency].Add(sourceID);
		}
	}
}