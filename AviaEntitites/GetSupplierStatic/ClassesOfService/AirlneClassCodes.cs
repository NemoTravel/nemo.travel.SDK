using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic.ClassesOfService
{
	/// <summary>
	/// Отношение код [код а/к : [литера класса : базовый класс]]
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", KeyName = "AirlineCode", ValueName = "ClassesByCodes", ItemName = "AirlineClasses")]
	public class AirlneClassCodes : Dictionary<string, ClassesByCodes>
	{
	}
}
