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
		private static readonly IReadOnlyDictionary<string, string> _cyrillicToLatinDictionary = CreateCyrillicToLatinDictionary();

		/// <summary>
		/// Словарь соответствий английских букв русским
		/// </summary>
		private static readonly IReadOnlyDictionary<string, string> _latinToCyrillicDictionary = CreateLatinToCyrillicDictionary();


		/// <summary>
		/// Производит транслитерацию русских и украинских букв в английские
		/// </summary>
		/// <param name="orginal">Строка подлежащая транслитерации</param>
		/// <returns>Строка являющаяся результатом транслитерации</returns>
		public static string CyrillicToLatin(string original)
		{
			return Transliterate(original, _cyrillicToLatinDictionary);
		}

		public static string LatinToCyrillic(string original)
		{
			return Transliterate(original, _latinToCyrillicDictionary);
		}


		/// <summary>
		/// Инициализация словаря соответствий русских и украинских букв английским
		/// </summary>
		private static Dictionary<string, string> CreateCyrillicToLatinDictionary()
		{
			var result = new Dictionary<string, string>();

			//Порядок важен!
			//Данные правила используются для CheckIn и любые изменения надо согласовать с правилами из #49943#note-46
			result.Add("-", "");

			result.Add("ый", "yi");
			result.Add("эй", "ei");
			result.Add("юй", "iui");
			result.Add("яй", "iai");
			result.Add("ай", "ai");
			result.Add("ей", "ei");
			result.Add("ий", "ii");
			result.Add("ой", "oi");
			result.Add("уй", "ui");

			result.Add("а", "a");
			result.Add("б", "b");
			result.Add("в", "v");
			result.Add("г", "g");
			result.Add("д", "d");
			result.Add("е", "e");
			result.Add("ё", "e");
			result.Add("ж", "zh");
			result.Add("з", "z");
			result.Add("и", "i");
			result.Add("й", "i");
			result.Add("к", "k");
			result.Add("л", "l");
			result.Add("м", "m");
			result.Add("н", "n");
			result.Add("о", "o");
			result.Add("п", "p");
			result.Add("р", "r");
			result.Add("с", "s");
			result.Add("т", "t");
			result.Add("у", "u");
			result.Add("ф", "f");
			result.Add("х", "kh");
			result.Add("ц", "ts");
			result.Add("ч", "ch");
			result.Add("ш", "sh");
			result.Add("щ", "shch");
			result.Add("ъ", "");
			result.Add("ы", "y");
			result.Add("ь", "");
			result.Add("э", "e");
			result.Add("ю", "iu");
			result.Add("я", "ia");

			result.Add("А", "a");
			result.Add("Б", "b");
			result.Add("В", "v");
			result.Add("Г", "g");
			result.Add("Д", "d");
			result.Add("Е", "e");
			result.Add("Ё", "e");
			result.Add("Ж", "zh");
			result.Add("З", "z");
			result.Add("И", "i");
			result.Add("Й", "i");
			result.Add("К", "k");
			result.Add("Л", "l");
			result.Add("М", "m");
			result.Add("Н", "n");
			result.Add("О", "o");
			result.Add("П", "p");
			result.Add("Р", "r");
			result.Add("С", "s");
			result.Add("Т", "t");
			result.Add("У", "u");
			result.Add("Ф", "f");
			result.Add("Х", "kh");
			result.Add("Ц", "ts");
			result.Add("Ч", "ch");
			result.Add("Ш", "sh");
			result.Add("Щ", "shch");
			result.Add("Ъ", "");
			result.Add("Ы", "y");
			result.Add("Ь", "");
			result.Add("Э", "e");
			result.Add("Ю", "iu");
			result.Add("Я", "ia");

			result.Add("ґ", "g");
			result.Add("Ґ", "g");
			result.Add("ї", "yi");
			result.Add("Ї", "yi");
			result.Add("і", "i");
			result.Add("I", "I");
			result.Add("є", "ye");
			result.Add("Є", "ye");

			return result;
		}

		private static Dictionary<string, string> CreateLatinToCyrillicDictionary()
		{
			var result = new Dictionary<string, string>();

			result.Add("-", "");

			result.Add("shch", "щ");
			result.Add("zh",   "ж");
			result.Add("kh",   "х");
			result.Add("ts",   "ц");
			result.Add("ch",   "ч");
			result.Add("sh",   "ш");
			result.Add("iu",   "ю");
			result.Add("ia",   "я");

			result.Add("SHCH", "щ");
			result.Add("ZH",   "ж");
			result.Add("KH",   "х");
			result.Add("TS",   "ц");
			result.Add("CH",   "ч");
			result.Add("SH",   "ш");
			result.Add("IU",   "ю");
			result.Add("IA",   "я");

			result.Add("Shch", "щ");
			result.Add("Zh",   "ж");
			result.Add("Kh",   "х");
			result.Add("Ts",   "ц");
			result.Add("Ch",   "ч");
			result.Add("Sh",   "ш");
			result.Add("Iu",   "ю");
			result.Add("Ia",   "я");

			result.Add("a", "а");
			result.Add("b", "б");
			result.Add("v", "в");
			result.Add("g", "г");
			result.Add("d", "д");
			result.Add("e", "е");
			//result.Add("e", "ё");
			result.Add("z", "з");
			result.Add("i", "и");
			//result.Add("i", "й");
			result.Add("k", "к");
			result.Add("l", "л");
			result.Add("m", "м");
			result.Add("n", "н");
			result.Add("o", "о");
			result.Add("p", "п");
			result.Add("r", "р");
			result.Add("s", "с");
			result.Add("t", "т");
			result.Add("u", "у");
			result.Add("f", "ф");
			result.Add("y", "ы");
			//result.Add("e", "э");

			result.Add("A", "а");
			result.Add("B", "б");
			result.Add("V", "в");
			result.Add("G", "г");
			result.Add("D", "д");
			result.Add("E", "е");
			//result.Add("E", "ё");
			result.Add("Z", "з");
			result.Add("I", "и");
			//result.Add("I", "й");
			result.Add("K", "к");
			result.Add("L", "л");
			result.Add("M", "м");
			result.Add("N", "н");
			result.Add("O", "о");
			result.Add("P", "п");
			result.Add("R", "р");
			result.Add("S", "с");
			result.Add("T", "т");
			result.Add("U", "у");
			result.Add("F", "ф");
			result.Add("Y", "ы");
			//result.Add("E", "э");

			return result;
		}

		private static string Transliterate(string original, IReadOnlyDictionary<string, string> dictionary)
		{
			//пробегаемся по словарю
			foreach (KeyValuePair<string, string> kvp in dictionary)
			{
				//проверяем есть такие буквы в оригинальной строке
				if (original.Contains(kvp.Key))
				{
					//есили есть, заменяем в соответвии со словарём
					original = original.Replace(kvp.Key, kvp.Value);
				}
			}

			return original;
		}
	}
}