
using System.Runtime.Serialization;


namespace GeneralEntities.PriceContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class LangItem
	{
		/// <summary>
		/// Код языка
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Строка на выбранном языке
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Value { get; set; }

		public LangItem(string code, string value)
		{
			this.Code = code;
			this.Value = value;
		}
	}
}
