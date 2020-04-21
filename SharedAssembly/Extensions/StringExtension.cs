using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedAssembly.Extensions
{
	public static class StringExtension
	{
		/// <summary>
		/// Не дает IEnumerableExtension.IsNullOrEmpty обрабатывать строки
		/// </summary>
		[Obsolete("Use string.IsNullOrEmpty instead", true)]
		public static bool IsNullOrEmpty(this string str)
		{
			return String.IsNullOrEmpty(str);
		}

		public static bool IsNullOrWhiteSpace(this string str)
		{
			return String.IsNullOrWhiteSpace(str);
		}

		public static string Format(this string str, params object[] args)
		{
			return String.Format(str, args);
		}

		public static bool ContainsAny(this string str, params string[] args)
		{
			return args.Any(a => str.Contains(a));
		}

		public static string[] Split(this string str, string separator, StringSplitOptions options = StringSplitOptions.None)
		{
			return str.Split(new string[] { separator }, options);
		}
	}
}
