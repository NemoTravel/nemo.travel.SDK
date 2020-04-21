namespace GeneralEntities.PriceContent
{
	public interface ITariff
	{
		string FareFamilyCode { get; }

		int? FareFamilyDescID { get; set; }


		string GetFareBasisCode(bool forceSplit = false);

		/// <summary>
		/// Получение ссылки на сегмент методом, чтобы не сломать сериализацию переименование свойства в реализации
		/// </summary>
		/// <returns></returns>
		int GetSegmentRef();
	}
}