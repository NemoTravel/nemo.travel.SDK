using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Информация об уникальном коде тарифа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FareSourceCodeDataItem
	{
		/// <summary>
		/// Уникальный код тарифа, определяющий перелёт в системе Mystifly
		/// </summary>
		[DataMember(Order = 0)]
		public string Code { get; set; }
	}
}
