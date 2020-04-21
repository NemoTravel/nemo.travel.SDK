using System.Data.SqlClient;

namespace SharedAssembly.Extensions
{
	public static class SqlExceptionExtension
	{
		public static bool IsUniqueIndexViolation(this SqlException exception)
		{
			return exception.Number == 2601;
		}

		public static bool IsPrimaryKeyViolation(this SqlException exception)
		{
			return exception.Number == 2627;
		}

		/// <remarks>В том числе и Foreign Key</remarks>
		public static bool IsConstraintViolation(this SqlException exception)
		{
			return exception.Number == 547;
		}
	}
}
