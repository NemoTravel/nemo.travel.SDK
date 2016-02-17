namespace SharedAssembly.Warning.Codes
{
	public static class CommonWarningCodes
	{
		/// <summary>
		/// Любая внутренняя ошибка системы
		/// </summary>
		public const ushort SYSTEM_ERROR = 1;

		/// <summary>
		/// Ошибка уровня доступа к чему-либо в системе
		/// </summary>
		public const ushort ACCESS_DENIED = 2;

		/// <summary>
		/// Ошибка формата каких-либо входных данных
		/// </summary>
		public const ushort FORMAT_ERROR = 3;

		/// <summary>
		/// Использование устаревшей версии АПИ, что приводит к неполноценной работе с системой
		/// </summary>
		public const ushort OLD_API_VERSION = 4;
	}
}
