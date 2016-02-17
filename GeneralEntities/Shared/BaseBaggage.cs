using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GeneralEntities.Shared
{
	/// <summary>
	/// Базовый класс для багажей разных версий
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class BaseBaggage
	{
		/// <summary>
		/// Значение веса
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Value { get; set; }
	}
}