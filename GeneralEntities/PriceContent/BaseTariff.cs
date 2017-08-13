using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Содержит описание базового тарифа
	/// </summary>
	[KnownType(typeof(AirTariff))]
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public abstract class BaseTariff
	{
		/// <summary>
		/// Код тарифа
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		[IgnoreDataMember]
		public virtual string FareBasisCode
		{
			get
			{
				return Code.Split('/')[0];
			}
		}

		public abstract string GetFareBasisCode(bool forceSplit = false);
	}
}