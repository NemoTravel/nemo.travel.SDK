namespace GeneralEntities.Pay
{
	public static class RequestsParams
	{
		public const string TRANSACTION_NUMBER = "TransactionNumber";
		public const string CARD_DATA = "CardData";
		public const string CARD_NUMBER = "CardData.Number";
		public const string CARD_CODE = "CardData.Code";
		public const string CARD_HOLDER = "CardData.Holder";
		public const string CARD_MONTH = "CardData.Month";
		public const string CARD_YEAR = "CardData.Year";
		public const string IP_ADDRESS = "IpAddress";
		public const string BACK_URL = "BackURL";
		public const string NOTIFICATION_URL = "NotificationURL";
		public const string LANGUAGE = "Language";
		public const string THEME = "Theme";
		public const string ORDER = "Order";
		public const string ORDER_NUMBER = "Order.OrderId";
		public const string ORDER_PAYTIMELIMIT = "Order.PayTimeLimit";
		public const string ORDER_PRICE = "OrderInfo.Price";
		public const string ORDER_SERVICES = "OrderInfo.Services";
		public const string ORDER_SERVIE_ID = "OrderInfo.Service.Id";
		public const string ORDER_SERVICE_PRICE = "OrderInfo.Service.Price";
		public const string ORDER_SERVICE_PRICE_CURRENCY = "OrderInfo.Service.Price.Currency";
		public const string ORDER_SERVICE_PRICE_AMOUNT = "OrderInfo.Service.Price.Amount";
	}
}