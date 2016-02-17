using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Представляет собой комбинируемые друг с другом
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class FlightLegCrossCombination
	{
		/// <summary>
		/// Порядковый номер корневых плеч, в рамках текущей кросс-комбинации
		/// </summary>
		[DataMember(Order = 0)]
		public int RootLegOrderNum { get; set; }

		/// <summary>
		/// Возможные комбинации плечей перелёта вариант для сериализации
		/// </summary>
		[DataMember(Order = 1, Name = "CombinableLegs", EmitDefaultValue = false)]
		public IDListAsString SerializableCombinableLegs
		{
			get
			{
				return new IDListAsString(CombinableLegs);
			}
			set
			{
				if (value != null)
				{
					CombinableLegs = new List<List<string>>();
					foreach (var item in value)
					{
						if (item != null)
						{
							var stringIDs = item.Split(',').ToList();
							stringIDs.RemoveAll(id => string.IsNullOrWhiteSpace(id));
							var ids = new List<string>();

							foreach (var id in stringIDs)
							{
								ids.Add(id);
							}

							CombinableLegs.Add(ids);
						}
					}
				}
			}
		}

		/// <summary>
		/// Возможные комбинации плечей перелёта
		/// </summary>
		[XmlIgnore]
		[JsonIgnore]
		[IgnoreDataMember]
		public List<List<string>> CombinableLegs { get; set; }

		public FlightLegCrossCombination()
		{
			CombinableLegs = new List<List<string>>();
		}
	}
}