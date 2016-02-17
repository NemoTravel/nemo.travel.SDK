using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	/// <summary>
	/// Содержит информацию о разрешённом для данного сегмента багаже
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class Baggage : BaseBaggage
	{
		/// <summary>
		/// Мера веса
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Measure { get; set; }
	}
}