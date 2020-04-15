using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	/// <summary>
	/// Описание семейства цен
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class FareFamilyDescription
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int ID { get; set; }

		/// <summary>
		/// Название семейства
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public string Name { get; set; }

		/// <summary>
		/// Типы бесплатного питания по тарифу
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public MealTypeList FreeMeal { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public string AmadeusFFParams { get; set; }

		/// <summary>
		/// Универсальные парметры
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public List<FareFamilyParameter> UniversalParameters { get; set; }


		public FareFamilyDescription()
		{
			UniversalParameters = new List<FareFamilyParameter>();
		}
	}
}