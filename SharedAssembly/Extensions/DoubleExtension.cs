using System.Globalization;

namespace SharedAssembly.Extensions
{
	public static class DoubleExtension
	{
		/// <summary>
		/// Выполняет преобразование типа System.Double в строку, для инвариантной культуры, дающей при обратном преобразовании идентичное число.
		/// <para>Формат преобразования "R" - приемо-передача.</para>
		/// </summary>
		/// <param name="value">Число с плавающей запятой, которое требуется преобразовать.</param>
		public static string ToStringR(this double value)
		{
			return value.ToString("R", CultureInfo.InvariantCulture);
		}
	}
}