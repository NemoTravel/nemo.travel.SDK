using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.AddInformation
{
	/// <summary>
	/// Массив добавляемой информации
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", Name = "InformationToAdd", ItemName = "Information")]
	public class AddableInformationList : List<AddableInformation>
	{
	}
}