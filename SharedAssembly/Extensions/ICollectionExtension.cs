using System.Collections.Generic;

namespace SharedAssembly.Extensions
{
	/// <summary>
	/// Класс-расширение для списков
	/// </summary>
	public static class ICollectionExtension
	{
		/// <summary>
		/// Добавляет элемент в список при условии что он уже не находился в этом списке
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="item"></param>
		/// <returns><c>true</c>, если добавлен</returns>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		public static bool AddIfNotContaints<T>(this ICollection<T> collection, T item)
		{
			if (collection.Contains(item))
			{
				return false;
			}

			collection.Add(item);

			return true;
		}

		/// <summary>
		/// Добавляет в список все новые для него элементы из переданной коллекции
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">Коллекция, в которую происходит добавление</param>
		/// <param name="enumerable">Коллекция из которой происходит добавление</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		public static void AddNew<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
		{
			foreach (var item in enumerable)
			{
				collection.AddIfNotContaints(item);
			}
		}


		/// <summary>
		/// Добавляет элемент в коллекцию и создаёт её если она не проинициализирована.
		/// </summary>
		/// <typeparam name="C">Тип коллекции</typeparam>
		/// <typeparam name="T">Тип элемента коллекции</typeparam>
		/// <param name="collection"></param>
		/// <param name="item"></param>
		/// <param name="check">Перед добавлением проверяет не содержится ли элемент уже в колекции</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <remarks>Не забывайте сохранять ссылку на коллекцию</remarks>
		/// <example>collection = collection.CreateAndAdd(item);</example>
		public static C CreateAndAdd<C, T>(this C collection, T item, bool check = false)
			where C : ICollection<T>, new()
		{
			if (collection == null)
			{
				collection = new C();
			}

			if (!check || !collection.Contains(item))
			{
				collection.Add(item);
			}

			return collection;
		}


		/// <summary>
		/// Проверяет коллекцию на пустоту
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return collection == null || collection.Count == 0;
		}


		/// <summary>
		/// Удаляет все перечисленные элементы из коллекции
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="enumerable"></param>
		/// <returns>Число удалённых элементов</returns>
		public static int RemoveAll<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
		{
			int count = 0;

			foreach (var item in enumerable)
			{
				if (collection.Remove(item))
				{
					count++;
				}
			}

			return count;
		}

		/// <summary>
		/// Создаёт поверхностную копию коллекции
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="C"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static C Clone<C, T>(this C collection)
			where C : ICollection<T>, new()
		{
			var result = new C();

			foreach (var item in collection)
			{
				result.Add(item);
			}

			return result;
		}
	}
}