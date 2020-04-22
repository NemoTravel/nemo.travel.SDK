using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedAssembly.Extensions
{
	public static class IListExtension
	{
		/// <summary>
		/// Удаляет первый элемент, попавший под фильтр
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="predicate"></param>
		public static void RemoveFirst<T>(this IList<T> list, Predicate<T> predicate)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (predicate(list[i]))
				{
					list.RemoveAt(i);
					break;
				}
			}
		}

		/// <summary>
		/// Удаляет последний элемент, попавший под фильтр
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="predicate"></param>
		public static void RemoveLast<T>(this IList<T> list, Predicate<T> predicate)
		{
			for (int i = list.Count - 1; i >= 0; i--)
			{
				if (predicate(list[i]))
				{
					list.RemoveAt(i);
					break;
				}
			}
		}
	}
}
