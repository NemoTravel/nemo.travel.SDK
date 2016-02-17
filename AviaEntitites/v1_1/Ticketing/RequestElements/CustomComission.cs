using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.v1_1.Ticketing.RequestElements
{
	/// <summary>
	/// Класс для задания своей комиссии для каждого типа пассажиров
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "ComissionForType", KeyName = "PassengerType", ValueName = "Comission")]
	public class CustomComission : Dictionary<PassTypes, ComissionInfo>
	{
	}
}