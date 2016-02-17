using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Linq;
using System.Globalization;

namespace GeneralEntities.Market.Markups
{
	/// <summary>
	/// Сбор (Наценка/Скидка)
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Markup : RestrictedProfit
	{
		static Markup()
		{
			passTypes = Enum.GetNames(typeof(PassTypes)).Aggregate("", (p,c) => p + c + '|');
		}

		[DataMember]
		public MultiplierType Multipliers { get; set; }




		/// <summary>
		/// Содержит название всех типов пассажиров на момент запуска сервера.
		/// </summary>
		static string passTypes;

		/// <summary>
		/// Создаёт сложный сбор из строки
		/// </summary>
		/// <param name="value">Строка в формате ({AbsValue}{Curency} + {RelValue}%) * {Multiplier(s)} [{MinValue},{MaxValue}]</param>
		/// <example>(1000RUB + 1%)*ADT [,10%] + (-100.5 RUB)*CNN*SEG [100,1000] + (4.4%+7UAH)*SEG*PAS[,100][3%] + (1.7%)*PAS [10%,100%] [105,500] +(5 EUR)</example>
		public static List<Markup> Parse(string value)
		{
			Regex regex = new Regex(@"\((?:(?:(-?\d+(?:\.\d+)*)%(?: ?\+ ?(-?\d+(?:\.\d+)*) ?(\w+))?)|(?:(-?\d+(?:\.\d+)*) ?(\w+)?(?: ?\+ ?(-?\d+(?:\.\d+)*)%)?))\)(?: ?\* ?(" + passTypes + @"SEG|PAS))*(?:(?:(?: ?\[(?:(-?\d*(?:\.\d+)*))?(?:, ?(-?\d*(?:\.\d+)*))?\])(?: ?\[(?:(-?\d*(?:\.\d+)*)%)?(?:, ?(-?\d*(?:\.\d+)*)%)?\])?)|(?:(?: ?\[(?:(-?\d*(?:\.\d+)*)%)?(?:, ?(-?\d*(?:\.\d+)*)%)?\])(?: ?\[(?:(-?\d*(?:\.\d+)*))?(?:, ?(-?\d*(?:\.\d+)*))?\])?))?", RegexOptions.Compiled);
			var result = new List<Markup>();

			foreach (Match match in regex.Matches(value))
			{
				var markup = new Markup();
				var abs = match.Groups[2].Success ? match.Groups[2] : match.Groups[4];
				if (abs.Success)
				{
					markup.Value = Double.Parse(abs.Value, CultureInfo.InvariantCulture);
				}
				var rel = match.Groups[1].Success ? match.Groups[1] : match.Groups[6];
				if (rel.Success)
				{
					markup.RelativeValue = Double.Parse(rel.Value, CultureInfo.InvariantCulture);
				}
				var cur = match.Groups[3].Success ? match.Groups[3] : match.Groups[5];
				if (cur.Success)
				{
					markup.Currency = cur.Value;
				}
				var min = match.Groups[8].Success ? match.Groups[8] : match.Groups[14];
				if (min.Success)
				{
					markup.MinProfit = Double.Parse(min.Value, CultureInfo.InvariantCulture);
				}
				var max = match.Groups[9].Success ? match.Groups[9] : match.Groups[15];
				if (max.Success)
				{
					markup.MaxProfit = Double.Parse(max.Value, CultureInfo.InvariantCulture);
				}
				var minRel = match.Groups[10].Success ? match.Groups[10] : match.Groups[12];
				if (minRel.Success)
				{
					markup.MaxProfit = Double.Parse(minRel.Value, CultureInfo.InvariantCulture);
				}
				var maxRel = match.Groups[11].Success ? match.Groups[11] : match.Groups[13];
				if (maxRel.Success)
				{
					markup.MaxProfit = Double.Parse(maxRel.Value, CultureInfo.InvariantCulture);
				}
				if (match.Groups[7].Success)
				{
					if (markup.Multipliers == null)
						markup.Multipliers = new MultiplierType();
					foreach (Capture mul in match.Groups[7].Captures)
						markup.Multipliers.Add(mul.Value);
				}
				result.Add(markup);
			}
			return result;
		}




		public override int GetHashCode()
		{
			unchecked
			{
				return base.GetHashCode() + (Multipliers != null ? (int)(Multipliers.Aggregate(0L, (a, v) => a + v.GetHashCode()) % Int32.MaxValue) : 0); 
			}
		}

		public override bool Equals(object obj)
		{
			if (!base.Equals(obj))
				return false;
			var other = obj as Markup;
			if (Multipliers == other.Multipliers)
				return true;
			if (Multipliers.Count != other.Multipliers.Count)
				return false;
			for (int i = 0; i < Multipliers.Count; i++)
			{
				if (!Multipliers[i].Equals(other.Multipliers[i]))
					return false;
			}
			return true;
		}
	}

	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "MultiplierType")]
	public class MultiplierType : List<string>
	{
	}
}