using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Универсальный параметр семейства цен
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FareFamilyParameter
	{
		/// <summary>
		/// Код параметра
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public string Code { get; set; }

		/// <summary>
		/// Краткое описание
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public List<LangItem> ShortDescription { get; set; }

		/// <summary>
		/// Полное описание
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public List<LangItem> FullDescription { get; set; }

		/// <summary>
		/// Платность услуги
		/// </summary>
		[DataMember(Order = 3, IsRequired = true)]
		public string NeedToPay { get; set; }

		/// <summary>
		/// Приоритет
		/// </summary>
		[DataMember(Order = 4, IsRequired = false)]
		public int Priority { get; set; }


		public FareFamilyParameter(string code)
		{
			Code = code;
			ShortDescription = new List<LangItem>();
			FullDescription = new List<LangItem>();
		}
	}
}