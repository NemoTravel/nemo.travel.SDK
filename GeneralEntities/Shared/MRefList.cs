using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.Shared
{
	/// <summary>
	/// Список неуникальных (повторяющихся) ссылок
	/// </summary>
	/// <typeparam name="T">Тип ссылок</typeparam>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "MRef")]
	public class MRefList<T> : List<T>
	{
		public MRefList() { }

		public MRefList(IEnumerable<T> collection) : base(collection) { }


		/// <summary>
		/// Возвращает мульти-ссылки не содержащиеся в переденном списке мульти-ссылок
		/// </summary>
		/// <param name="collection"></param>
		/// <returns></returns>
		public MRefList<T> Exclude(IEnumerable<T> collection)
		{
			var result = new MRefList<T>(this);

			foreach (var item in collection)
			{
				result.Remove(item);
			}

			return result;
		}
	}
}