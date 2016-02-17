namespace GeneralEntities.Error
{
	public static class CommonErrorCodes
	{
		/// <summary>
		/// Любая внутренняя ошибка системы
		/// </summary>
		public const ushort SYSTEM_ERROR = 1;

		/// <summary>
		/// Ошибка уровня доступа к чему-либо в системе
		/// </summary>
		public const ushort ACCESS_DENIED = 2;
		public const ushort EMTPY_REQUEST = 3;

		public const ushort AUTHORIZATION_ERROR = 4;
	}
}
