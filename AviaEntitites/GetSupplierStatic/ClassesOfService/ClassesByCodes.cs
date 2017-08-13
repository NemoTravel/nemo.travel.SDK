using GeneralEntities;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AviaEntities.GetSupplierStatic.ClassesOfService
{
	/// <summary>
	/// Отношение [литера класса : базовый класс]
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", KeyName = "Code", ValueName = "BaseClass", ItemName = "ClassByCode")]
	public class ClassesByCodes : Dictionary<string, BaseClass>
	{
	}
}
