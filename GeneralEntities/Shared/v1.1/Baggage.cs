using System;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared.v1_1
{
	/// <summary>
	/// Содержит информацию о разрешённом для данного сегмента багаже
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL", Name = "Baggage_1_1")]
	[Serializable]
	public class Baggage : BaseBaggage
	{
		/// <summary>
		/// Мера веса
		/// </summary>
		[DataMember(Order = 1)]
		public BaggageMeasure Measure { get; set; }

		/// <summary>
		/// Допустимый размер багажа
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string Size { get; set; }
	}
}
