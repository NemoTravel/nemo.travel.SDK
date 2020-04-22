using GeneralEntities.Shared;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class SubsidyInformation : ItemIdentification<int>
	{
		/// <summary>
		/// Данные о пассажирах
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public List<PassengerTypeDescription> PassengerTypes { get; set; }

		/// <summary>
		/// Краткое описание тарифа
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public MultiLanguageDictionary ShortDescription { get; set; }

		/// <summary>
		/// Описание тарифа
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public MultiLanguageDictionary Description { get; set; }

		/// <summary>
		/// Добавлять сборы агенту
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public bool AllowAgentCharges { get; set; }

		/// <summary>
		/// Продажа в режиме B2C
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public bool AllowB2cMod { get; set; }

		/// <summary>
		/// Комбинация с другими участками
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public bool AllowCombine { get; set; }
	}
}
