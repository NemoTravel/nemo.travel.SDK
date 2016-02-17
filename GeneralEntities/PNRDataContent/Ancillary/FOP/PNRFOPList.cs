using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	/// <summary>
	/// Представляет набор ФОПов
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "FOP")]
	public class PNRFOPList : List<PNRFOP>
	{
	}
}