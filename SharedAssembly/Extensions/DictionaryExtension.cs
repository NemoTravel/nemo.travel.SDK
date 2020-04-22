using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace SharedAssembly.Extensions
{
	public static class DictionaryExtension
	{
		// ================================================================================================================= //
		//                                                     !АХТУНГ!                                                      //
		//   НЕ ДОБАВЛЯЙТЕ РАСШИРЕНИЯ ДЛЯ IDictionary ИНТЕРФЕЙСА, тк ConcurrentDictionary РЕАЛИЗУЕТ ЕГО, ОТЧЕГО ПОЯВЛЯЕТСЯ   //
		//    ВЕРОЯТНОСТЬ, ЧТО МЕТОД РАСШИРЕНИЯ МОЖЕТ ВЫЗВАТЬ МЕТОД ИНТЕРФЕЙСА НА РЕАЛИЗАЦИИ ConcurrentDictionary КОТОРАЯ    //
		//  АКЬЮРИТ ВСЕ ЛОКИ СЛОВАРЯ, ТЕМ САМЫМ БЛОКИРУЯ ЕГО ВО ВСЕХ ПОТОКАХ, УБИВАЯ СМЫСЛ ЕГО НЕБЛОКИРУЮЩЕГО ИСПОЛЬЗОВАНИЯ  //
		//                                                                                                                   //
		// ================================================================================================================= //

		public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			AddIfNotContaints(dictionary, key, value);
			return dictionary[key];
		}

		public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TValue> valueFactory)
		{
			AddIfNotContaints(dictionary, key, valueFactory);
			return dictionary[key];
		}

		/// <summary>
		/// Adds a key/value pair to the <see cref="Dictionary{TKey,TValue}"/>
		/// if the key does not already exist
		/// </summary>
		/// <typeparam name="TKey">The type of the key</typeparam>
		/// <typeparam name="TValue">The type of the value</typeparam>
		/// <param name="dictionary">The source dictionary</param>
		/// <param name="key">The key of the element to add</param>
		/// <param name="valueFactory">The function used to generate a value for the key</param>
		/// <remarks>The extension is not for the <see cref="Dictionary{TKey,TValue}"/>, which does not affect <see cref="ConcurrentDictionary{TKey,TValue}"/> behaviour</remarks>
		/// <returns>
		/// The value for the key.
		/// This will be either the existing value for the key if the key is already in the dictionary,
		/// or the new value for the key as returned by <paramref name="valueFactory"/>
		/// if the key was not in the dictionary.
		/// </returns>
		public static TValue GetOrAdd<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> valueFactory)
		{
			if (key == null) throw new ArgumentNullException(nameof(key));
			if (valueFactory == null) throw new ArgumentNullException(nameof(valueFactory));

			TValue resultingValue;
			if (dictionary.TryGetValue(key, out resultingValue))
			{
				return resultingValue;
			}

			resultingValue = valueFactory(key);
			dictionary.Add(key, resultingValue);

			return resultingValue;
		}

		/// <summary>
		/// Добавляет в текущий словарь все значения, ключи которых ещё не присутствуют в текущем словаре
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="dictionary"></param>
		/// <param name="source"></param>
		/// <param name="replace">Если проставлено в истину, в случае наличии в текущем словаре данного ключа произойдёт замена значения по этому ключу значением из <paramref name="source"/></param>
		/// <exception cref="System.ArgumentNullException">Ссылка на словарь пуста</exception>
		public static void AddRangeWithNonrecurringKey<T, K>(this Dictionary<T, K> dictionary, Dictionary<T, K> source, bool replace = false)
		{
			foreach (var item in source)
			{
				if (!dictionary.ContainsKey(item.Key))
				{
					dictionary.Add(item.Key, item.Value);
				}
				else if (replace)
				{
					dictionary[item.Key] = item.Value;
				}
			}
		}

		/// <summary>
		/// Добавляет элемент в словарь при условии что последний не содержит такого ключа
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection"></param>
		/// <param name="item"></param>
		/// <returns><c>true</c>, если добавлен</returns>
		/// <exception cref="System.ArgumentNullException">Ссылка на словарь пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на ключ пуста</exception>
		public static bool AddIfNotContaints<T, K>(this Dictionary<T, K> dictionary, T key, K value)
		{
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, value);

				return true;
			}

			return false;
		}

		/// <summary>
		/// Добавляет элемент в словарь при условии что последний не содержит такого ключа
		/// </summary>
		/// <typeparam name="T">Тип ключа</typeparam>
		/// <typeparam name="K">Тип значения</typeparam>
		/// <param name="dictionary">Словарь, в который добавляется значение</param>
		/// <param name="key">Ключ, по которому добавляется значение</param>
		/// <param name="valueFactory">Функция создания значения, если заданного ключа ещё нет</param>
		/// <returns><c>true</c>, если добавлен</returns>
		/// <exception cref="System.ArgumentNullException">Ссылка на словарь пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на ключ пуста</exception>
		public static bool AddIfNotContaints<T, K>(this Dictionary<T, K> dictionary, T key, Func<K> valueFactory)
		{
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, valueFactory());

				return true;
			}

			return false;
		}

		/// <summary>
		/// Добавляет новое значение в словарь, или заменяет значение, если такой ключ уже существует.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="dictionary"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void AddOrExchange<T, K>(this Dictionary<T, K> dictionary, T key, K value)
		{
			if (dictionary.ContainsKey(key))
			{
				dictionary[key] = value;
			}
			else
			{
				dictionary.Add(key, value);
			}
		}

		/// <summary>
		/// Удаляет из словаря по определённому закону
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="dictionary"></param>
		/// <param name="selector">Функция-селектор для отбора элементов для удаления.</param>
		/// <exception cref="System.ArgumentNullException">Ссылка на словарь пуста</exception>
		/// <exception cref="System.ArgumentNullException">Ссылка на функцию пуста</exception>
		public static void Remove<T, K>(this Dictionary<T, K> dictionary, Func<KeyValuePair<T, K>, bool> selector)
		{
			var keysForDelete = new List<T>();
			foreach (var item in dictionary)
			{
				if (selector(item))
				{
					keysForDelete.Add(item.Key);
				}
			}

			foreach (var key in keysForDelete)
			{
				dictionary.Remove(key);
			}
		}

		/// <summary>
		/// Добавляет значение в список, расположенный по определённому ключу или создаёт его, если он не существует
		/// </summary>
		/// <typeparam name="T">Тип ключа</typeparam>
		/// <typeparam name="K">Тип значений списка</typeparam>
		/// <param name="dictionary"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void AddToList<T, K>(this Dictionary<T, List<K>> dictionary, T key, K value)
		{
			if (!dictionary.ContainsKey(key))
			{
				dictionary.Add(key, new List<K>());
			}

			dictionary[key].Add(value);
		}

		/// <summary>
		/// Добавляет переданные значения в соответствующие списки и создаёт их, если требуется
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="K"></typeparam>
		/// <param name="dictionary"></param>
		/// <param name="source"></param>
		public static void AddRangeToLists<T, K>(this Dictionary<T, List<K>> dictionary, Dictionary<T, List<K>> source)
		{
			foreach (var item in source)
			{
				if (!dictionary.ContainsKey(item.Key))
				{
					dictionary.Add(item.Key, new List<K>());
				}

				dictionary[item.Key].AddRange(item.Value);
			}
		}

		/// <summary>
		/// Добавляет значение в словарь, расположенный по определённому ключу или создаёт его, если он не существует
		/// </summary>
		/// <typeparam name="T">Тип ключа</typeparam>
		/// <typeparam name="K">Тип ключа</typeparam>
		/// <typeparam name="V">Тип значений списка</typeparam>
		/// <param name="dictionary"></param>
		/// <param name="key"></param>
		/// <param name="value"></param>
		public static void AddToInnerDictionary<T, K, V>(this Dictionary<T, Dictionary<K, V>> dictionary, T key1, K key2, V value)
		{
			if (!dictionary.ContainsKey(key1))
			{
				dictionary.Add(key1, new Dictionary<K, V>());
			}

			dictionary[key1].Add(key2, value);
		}

		public static IReadOnlyDictionary<K, T> AsReadOnly<K, T>(this Dictionary<K, T> dictionary)
		{
			return new ReadOnlyDictionary<K, T>(dictionary);
		}

		public static Dictionary<K, T> ToDictionary<K, T>(this IEnumerable<KeyValuePair<K, T>> metaDictionary)
		{
			// Лучше подсчитать заранее размер, чем потом терять время на ресайзе словаря
			var result = new Dictionary<K, T>(metaDictionary.Count());

			foreach (var item in metaDictionary)
			{
				result.Add(item.Key, item.Value);
			}

			return result;
		}

		/// <summary>
		/// Сравнивает 2 словаря без учёта порядка следования элементов.
		/// </summary>
		/// <typeparam name="K"></typeparam>
		/// <typeparam name="T"></typeparam>
		/// <param name="dictionary"></param>
		/// <param name="source"></param>
		/// <returns></returns>
		public static bool ElementsEquals<T, K>(this Dictionary<T, K> dictionary, Dictionary<T, K> source)
		{
			if (dictionary.Count != source.Count)
			{
				return false;
			}

			foreach (var item in dictionary)
			{
				if (!source.ContainsKey(item.Key) || !item.Value.Equals(source[item.Key]))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Проверяет содержится ли каждый элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAll<T, K>(this Dictionary<T, K> source, Dictionary<T, K> collection)
		{
			foreach (var item in collection)
			{
				if (!source.ContainsKey(item.Key) || !source[item.Key].Equals(item.Value))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Проверяет содержится ли хоть один элемент переданной коллекции в текущей
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="source"></param>
		/// <param name="collection"></param>
		/// <exception cref="System.ArgumentNullException">Ссылка на коллекцию пуста</exception>
		/// <returns></returns>
		public static bool ContainsAny<T, K>(this Dictionary<T, K> source, Dictionary<T, K> collection)
		{
			foreach (var item in collection)
			{
				if (source.ContainsKey(item.Key) && source[item.Key].Equals(item.Value))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Возвращает значение по ключу или создаёт его в словаре и возвращает.
		/// </summary>
		/// <typeparam name="TKey"></typeparam>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="source"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static TValue GetOrCreate<TKey, TValue>(this Dictionary<TKey, TValue> source, TKey key) where TValue : new()
		{
			TValue value;

			if (source.TryGetValue(key, out value))
			{
				return value;
			}

			value = new TValue();
			source.Add(key, value);

			return value;
		}

		/// <summary>
		///  Возвращает значение по ключу или null, если его нет в словаре
		/// </summary>
		/// <typeparam name="TK"></typeparam>
		/// <typeparam name="TV"></typeparam>
		/// <param name="source"></param>
		/// <param name="key"></param>
		/// <returns></returns>
		public static TV GetOrNull<TK, TV>(this Dictionary<TK, TV> source, TK key)
			where TV : class
		{
			TV value;
			if (!source.TryGetValue(key, out value))
			{
				value = null;
			}

			return value;
		}
	}
}