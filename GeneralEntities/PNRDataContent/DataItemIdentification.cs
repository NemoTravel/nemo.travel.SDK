using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	[Serializable]
	public class DataItemIdentification
	{
		/// <summary>
		/// Идентификатор элемента.
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public long ID { get; set; }
	}
}
