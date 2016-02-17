using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetCurrencyConversion
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Conversion")]
	public class CurrencyConversionList : List<CurrencyConversion>
	{
	}
}