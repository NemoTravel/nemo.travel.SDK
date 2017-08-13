using GeneralEntities.PNRDataContent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "ModifyDataItem")]
	public class ModifyPNRDataItemList : List<ModifyPNRDataItem>
	{
		/// <summary>
		/// Датаитемы которые необходимо добавить
		/// <param name="type">Тип искомых датаитемов</param>
		/// </summary>
		public IEnumerable<PNRDataItem> ToAdd(PNRDataItemType type)
		{
			return Select(PNRContentModifyAction.Add, type);
		}

		/// <summary>
		/// Датаитемы которые необходимо модифицировать
		/// <param name="type">Тип искомых датаитемов</param>
		/// </summary>
		public IEnumerable<PNRDataItem> ToModify(PNRDataItemType type)
		{
			return Select(PNRContentModifyAction.Modify, type);
		}

		/// <summary>
		/// Датаитемы которые необходимо удалить
		/// <param name="type">Тип искомых датаитемов</param> 
		/// </summary>
		public IEnumerable<PNRDataItem> ToRemove(PNRDataItemType type)
		{
			return Select(PNRContentModifyAction.Remove, type);
		}


		private IEnumerable<PNRDataItem> Select(PNRContentModifyAction action, PNRDataItemType type)
		{
			return this.Where(di => di.Action == action && di.DataItem.Type == type).Select(di => di.DataItem);
		}
	}
}