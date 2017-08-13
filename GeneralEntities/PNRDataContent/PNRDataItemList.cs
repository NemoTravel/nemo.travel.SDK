using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Массив элементов с данными
	/// </summary>
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "DataItem")]
	public class PNRDataItemList : List<PNRDataItem>
	{
		public PNRDataItemList()
		{ }

		public PNRDataItemList(List<PNRDataItem> list)
			: base(list)
		{ }


		/// <summary>
		/// Получение дата итема по типу
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public PNRDataItem Select(PNRDataItemType type)
		{
			return this.FirstOrDefault(di => di.Type == type);
		}

		/// <summary>
		/// Получение датаитема по селектору
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="selector"></param>
		/// <returns></returns>
		public T Select<T>(Func<PNRDataItem, T> selector)
		{
			var item = this.FirstOrDefault(di => selector(di) != null);

			return EqualityComparer<PNRDataItem>.Default.Equals(item, default(PNRDataItem)) ? default(T) : selector(item);
		}
	}
}