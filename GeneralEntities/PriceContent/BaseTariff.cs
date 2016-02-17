using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит описание базового тарифа
	/// </summary>
	[KnownType(typeof(AirTariff))]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BaseTariff
	{
		/// <summary>
		/// Код тарифа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		[IgnoreDataMember]
		public string FareBasisCode
		{
			get
			{
				return Code.Split('/')[0];
			}
		}
	}
}