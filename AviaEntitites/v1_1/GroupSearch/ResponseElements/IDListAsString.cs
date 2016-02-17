using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AviaEntities.v1_1.GroupSearch.ResponseElements
{
	/// <summary>
	/// Массив массивов ИД перелётов, представленных в виде строки через запятую
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/Avia", ItemName = "Legs")]
	public class IDListAsString : List<string>
	{
		/// <summary>
		/// Создание объекта класса на основании группы массивов ИД плечей
		/// </summary>
		/// <param name="lists">Массивы, на основании которых будет создан класс</param>
		public IDListAsString(List<List<string>> lists)
		{
			if (lists != null)
			{
				foreach (var list in lists)
				{
					if (list != null)
					{
						var tmp = new StringBuilder();
						foreach (var flightID in list)
						{
							tmp.Append(flightID);
							tmp.Append(",");
						}

						Add(tmp.ToString().Trim(','));
					}
				}
			}
		}

		/// <summary>
		/// Пустой конструктор, необходим для сериализации/десериализации
		/// </summary>
		public IDListAsString()
		{
		}
	}
}