namespace GeneralEntities.Market
{
	public interface ICurrencyConverter
	{
		T Convert<T>(T source, string targetCurrency) where T : ICurrencyDepended, new();
	}
}
