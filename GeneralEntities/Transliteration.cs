using System.Collections.Generic;

namespace GeneralEntities
{
	/// <summary>
	/// Класс содержащий метод(ы) транслитерации букв
	/// </summary>
	public class Transliteration
	{
		/// <summary>
		/// Словарь соответствий русских и украинских букв  английским
		/// </summary>
		protected static Dictionary<string, string> UARUStoENGDictionary;

		/// <summary>
		/// Создание объекта класса с инициализацией необходимых параметров
		/// </summary>
		static Transliteration()
		{
			UARUStoENGDictionary = new Dictionary<string, string>();
			InitialUARUStoENGDictionary();
		}

		/// <summary>
		/// Инициализация словаря соответствий русских и украинских букв английским
		/// </summary>
		protected static void InitialUARUStoENGDictionary()
		{
			//Порядок важен!
			UARUStoENGDictionary.Add("-", "");

			UARUStoENGDictionary.Add("ый", "yy");
			UARUStoENGDictionary.Add("эй", "ey");
			UARUStoENGDictionary.Add("юй", "yuy");
			UARUStoENGDictionary.Add("яй", "yay");
			UARUStoENGDictionary.Add("ай", "ay");
			UARUStoENGDictionary.Add("ей", "ey");
			UARUStoENGDictionary.Add("ий", "iy");
			UARUStoENGDictionary.Add("ой", "oy");
			UARUStoENGDictionary.Add("уй", "uy");

			UARUStoENGDictionary.Add("а", "a");
			UARUStoENGDictionary.Add("б", "b");
			UARUStoENGDictionary.Add("в", "v");
			UARUStoENGDictionary.Add("г", "g");
			UARUStoENGDictionary.Add("д", "d");
			UARUStoENGDictionary.Add("е", "e");
			UARUStoENGDictionary.Add("ё", "ye");
			UARUStoENGDictionary.Add("ж", "zh");
			UARUStoENGDictionary.Add("з", "z");
			UARUStoENGDictionary.Add("и", "i");
			UARUStoENGDictionary.Add("й", "y");
			UARUStoENGDictionary.Add("к", "k");
			UARUStoENGDictionary.Add("л", "l");
			UARUStoENGDictionary.Add("м", "m");
			UARUStoENGDictionary.Add("н", "n");
			UARUStoENGDictionary.Add("о", "o");
			UARUStoENGDictionary.Add("п", "p");
			UARUStoENGDictionary.Add("р", "r");
			UARUStoENGDictionary.Add("с", "s");
			UARUStoENGDictionary.Add("т", "t");
			UARUStoENGDictionary.Add("у", "u");
			UARUStoENGDictionary.Add("ф", "f");
			UARUStoENGDictionary.Add("х", "kh");
			UARUStoENGDictionary.Add("ц", "ts");
			UARUStoENGDictionary.Add("ч", "ch");
			UARUStoENGDictionary.Add("ш", "sh");
			UARUStoENGDictionary.Add("щ", "shch");
			UARUStoENGDictionary.Add("ъ", "");
			UARUStoENGDictionary.Add("ы", "y");
			UARUStoENGDictionary.Add("ь", "");
			UARUStoENGDictionary.Add("э", "e");
			UARUStoENGDictionary.Add("ю", "yu");
			UARUStoENGDictionary.Add("я", "ya");

			UARUStoENGDictionary.Add("А", "a");
			UARUStoENGDictionary.Add("Б", "b");
			UARUStoENGDictionary.Add("В", "v");
			UARUStoENGDictionary.Add("Г", "g");
			UARUStoENGDictionary.Add("Д", "d");
			UARUStoENGDictionary.Add("Е", "e");
			UARUStoENGDictionary.Add("Ё", "ye");
			UARUStoENGDictionary.Add("Ж", "zh");
			UARUStoENGDictionary.Add("З", "z");
			UARUStoENGDictionary.Add("И", "i");
			UARUStoENGDictionary.Add("Й", "y");
			UARUStoENGDictionary.Add("К", "k");
			UARUStoENGDictionary.Add("Л", "l");
			UARUStoENGDictionary.Add("М", "m");
			UARUStoENGDictionary.Add("Н", "n");
			UARUStoENGDictionary.Add("О", "o");
			UARUStoENGDictionary.Add("П", "p");
			UARUStoENGDictionary.Add("Р", "r");
			UARUStoENGDictionary.Add("С", "s");
			UARUStoENGDictionary.Add("Т", "t");
			UARUStoENGDictionary.Add("У", "u");
			UARUStoENGDictionary.Add("Ф", "f");
			UARUStoENGDictionary.Add("Х", "kh");
			UARUStoENGDictionary.Add("Ц", "ts");
			UARUStoENGDictionary.Add("Ч", "ch");
			UARUStoENGDictionary.Add("Ш", "sh");
			UARUStoENGDictionary.Add("Щ", "shch");
			UARUStoENGDictionary.Add("Ъ", "");
			UARUStoENGDictionary.Add("Ы", "y");
			UARUStoENGDictionary.Add("Ь", "");
			UARUStoENGDictionary.Add("Э", "e");
			UARUStoENGDictionary.Add("Ю", "yu");
			UARUStoENGDictionary.Add("Я", "ya");

			UARUStoENGDictionary.Add("ґ", "g");
			UARUStoENGDictionary.Add("Ґ", "g");
			UARUStoENGDictionary.Add("ї", "yi");
			UARUStoENGDictionary.Add("Ї", "yi");
			UARUStoENGDictionary.Add("і", "i");
			UARUStoENGDictionary.Add("I", "I");
			UARUStoENGDictionary.Add("є", "ye");
			UARUStoENGDictionary.Add("Є", "ye");
		}

		/// <summary>
		/// Производит транслитерацию русских и украинских букв в английские
		/// </summary>
		/// <param name="orginal">Строка подлежащая транслитерации</param>
		/// <returns>Строка являющаяся результатом транслитерации</returns>
		public static string UARUStoENG(string orginal)
		{
			//пробегаемся по словарю
			foreach (var kvp in UARUStoENGDictionary)
			{
				//проверяем есть такие буквы в оригинальной строке
				if (orginal.Contains(kvp.Key))
				{
					//есили есть, заменяем в соответвии со словарём
					orginal = orginal.Replace(kvp.Key, kvp.Value);
				}
			}

			return orginal;
		}
	}
}