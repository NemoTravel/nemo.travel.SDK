using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedAssembly.Extensions
{
	/// <summary>
	/// Класс-расширение для перечисляемых типов
	/// </summary>
	public static class IEnumerableExtension
	{
		/// <summary>
		/// Выполняет переданное действие для каждого элемента коллекции
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="action">Действие, выполняемое для каждого элемента коллекции</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		/// <returns></returns>
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach (var item in collection)
			{
				action(item);
			}
			return collection;
		}

		/// <summary>
		/// Выполняет переданное действие для каждого элемента коллекции
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="action">Действие, выполняемое для каждого элемента коллекции (принимает текущий элемент и его индекс)</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		/// <returns></returns>
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> collection, Action<T, int> action)
		{
			int index = 0;
			foreach (var item in collection)
			{
				action(item, index);
				index++;
			}
			return collection;
		}

		/// <summary>
		/// Проверяет содержится ли каждый элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAll<T>(this IEnumerable<T> source, IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				if (!source.Contains(item))
					return false;
			}
			return true;
		}

		/// <summary>
		/// Проверяет содержится ли каждый элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <param name="comparer">Функция сранения элементов</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAll<T, K>(this IEnumerable<T> source, IEnumerable<K> collection, Func<T, K, bool> comparer)
		{
			foreach (var item in collection)
			{
				if (!source.Contains(item, comparer))
					return false;
			}
			return true;
		}

		/// <summary>
		/// Проверяет содержится ли переданный элемент в коллекции, используя функцию сравнения
		/// </summary>
		/// <typeparam name="CollectionType"></typeparam>
		/// <typeparam name="ElementType"></typeparam>
		/// <param name="source"></param>
		/// <param name="element">Элемент, чьё наличие проверяется</param>
		/// <param name="comparer">Функция сранения элементов</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		/// <returns></returns>
		public static bool Contains<CollectionType, ElementType>(this IEnumerable<CollectionType> source, ElementType element, Func<CollectionType, ElementType, bool> comparer)
		{
			foreach (var item in source)
			{
				if (comparer(item, element))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Проверяет содержится ли хоть один элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAny<T>(this IEnumerable<T> source, IEnumerable<T> collection)
		{
			foreach (var item in collection)
			{
				if (source.Contains(item))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Проверяет содержится ли хоть один элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <param name="comparer">Функция сранения элементов</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAny<T, K>(this IEnumerable<T> source, IEnumerable<K> collection, Func<T, K, bool> comparer)
		{
			foreach (var item in collection)
			{
				if (source.Contains(item, comparer))
					return true;
			}
			return false;
		}

		/// <summary>
		/// Проверяет коллекцию на пустоту
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
		{
			return collection == null || !collection.Any();
		}

		/// <summary>
		/// Проверяет на равенство 2 коллекции без учёта порядка следования элементов.
		/// Если обе коллекции null, то они будут считаться равными
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <returns></returns>
		public static bool ElementsEquals<T>(this IEnumerable<T> source, IEnumerable<T> collection)
		{
			if (source == null && collection == null)
			{
				return true;
			}

			if (source == null && collection != null)
			{
				return false;
			}

			if (source != null && collection == null)
			{
				return false;
			}

			if (collection.Count() != source.Count())
			{
				return false;
			}

			foreach (var item in collection!)
			{
				if (!source.Contains(item))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Возвращает суммарный хэшкод элементов с защитой от ошибки целочисленного переполнения
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <returns></returns>
		public static int GetSumHashCode<T>(this IEnumerable<T> source)
		{
			unchecked
			{
				int sum = 0;
				foreach (var item in source)
				{
					sum += item.GetHashCode();
				}
				return sum;
			}
		}

		public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
		{
			HashSet<TKey> knownKeys = new HashSet<TKey>();
			foreach (var element in source)
			{
				if (knownKeys.Add(keySelector(element)))
				{
					yield return element;
				}
			}
		}

		/// <summary>
		/// Разбивает последовательность на подпоследовательности с заданным размером
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="subSequenceSize">Размер подпоследовательности</param>
		/// <returns></returns>
		public static IEnumerable<IEnumerable<T>> Decompose<T>(this IEnumerable<T> source, int subSequenceSize)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			if (subSequenceSize < 1)
				throw new ArgumentOutOfRangeException("subSequenceSize: " + subSequenceSize);

			return source
				.Select((v, i) => new { Value = v, Index = i })
				.GroupBy(item => item.Index / subSequenceSize, item => item.Value);
		}

		public static bool NullRespectingSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second, IEqualityComparer<T> comparer = null)
		{
			if (first == null && second == null)
			{
				return true;
			}

			if (first == null || second == null)
			{
				return false;
			}

			if (comparer == null)
			{
				return first.SequenceEqual(second);
			}

			return first.SequenceEqual(second, comparer);
		}

		/// <summary>
		/// Возращает null, если перечисление пусто, иначе выполняет переданное действие
		/// </summary>
		public static IEnumerable<T> NullOrDo<T>(this IEnumerable<T> source, Func<IEnumerable<T>, IEnumerable<T>> map)
		{
			if (source == null)
				return null;
			return map(source);
		}

		/// <summary>
		/// Возращает null, если перечисление пусто, иначе выполняет переданное действие
		/// </summary>
		public static IEnumerable<K> NullOrDo<T, K>(this IEnumerable<T> source, Func<IEnumerable<T>, Func<T, K>, IEnumerable<K>> map, Func<T, K> selector)
		{
			if (source == null)
				return null;
			return map(source, selector);
		}

		/// <summary>
		/// Возращает null, если перечисление пусто, иначе выполняет выборку
		/// </summary>
		/// <returns>null или результат выборки (select)</returns>
		public static IEnumerable<K> SelectOrNull<T, K>(this IEnumerable<T> source, Func<T, K> selector)
		{
			if (source == null)
				return null;
			return source.Select(selector);
		}

		/// <summary>
		/// Аналогичен IEnumerable.SequenceEqual(), только учитывает null аргументы
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="first"></param>
		/// <param name="second"></param>
		/// <returns></returns>
		public static bool NullSequenceEqual<T>(this IEnumerable<T> first, IEnumerable<T> second)
		{
			if (first == null && second == null)
			{
				return true;
			}

			if (first == null && second != null)
			{
				return false;
			}

			if (first != null && second == null)
			{
				return false;
			}

			return first.SequenceEqual(second);
		}

		/// <summary>
		/// Выбирает элемент с наименьшим значением свойства из коллекции
		/// </summary>
		/// <typeparam name="T">Тип выбираемого элемента</typeparam>
		/// <typeparam name="V">Тип сравниваемого свойства</typeparam>
		/// <param name="source">Коллекция элеметов</param>
		/// <param name="selector">Селектор свойства</param>
		/// <param name="comparer"></param>
		/// <returns>Элемент с минимальным значением свойства</returns>
		public static T MinBy<T, V>(this IEnumerable<T> source, Func<T, V> selector, IComparer<V> comparer = null)
		{
			if (source == null)
				throw new ArgumentNullException("source");

			if (selector == null)
				throw new ArgumentNullException("selector");

			if (comparer == null)
			{
				return source.OrderBy(e => selector(e)).FirstOrDefault();
			}

			return source.OrderBy(e => selector(e), comparer).FirstOrDefault();
		}

		public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source)
		{
			return source ?? Enumerable.Empty<T>();
		}

		/// <summary>
		/// Разбивают коллекцию на две, согласно переданному условию
		/// </summary>
		/// <param name="source">Исходная коллекция</param>
		/// <param name="condition">Условие разбивки</param>
		/// <param name="satisfied">Элементы коллекции, удовлетворяющие условию</param>
		/// <param name="notSatisfied">Элементы коллекции, неудовлетворяющие условию</param>
		/// <typeparam name="T">Тип элементов коллекции</typeparam>
		public static void BisectByCondition<T>(this IEnumerable<T> source, Predicate<T> condition, out List<T> satisfied, out List<T> notSatisfied)
		{
			satisfied = new List<T>();
			notSatisfied = new List<T>();

			foreach (var element in source)
			{
				if (condition(element))
				{
					satisfied.Add(element);
				}
				else
				{
					notSatisfied.Add(element);
				}
			}
		}
	}
}