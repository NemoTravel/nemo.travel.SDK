using System.Runtime.Serialization;

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

		public override bool Equals(object obj)
		{
			var other = obj as FareSourceCodeDataItem;
			if (other == null)
			{
				return false;
			}

			return Code == other.Code;
		}

		public FareSourceCodeDataItem Copy()
		{
			var result = new FareSourceCodeDataItem();

			result.Code = Code;

			return result;
		}
	}
}