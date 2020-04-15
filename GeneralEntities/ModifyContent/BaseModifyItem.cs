using System.Runtime.Serialization;

namespace GeneralEntities.ModifyContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class BaseModifyItem
	{
		/// <summary>
		/// Тип изменения
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public PNRContentModifyAction Action { get; set; }

		public void CopyTo<T>(T modifyItem)
			 where T : BaseModifyItem
		{
			modifyItem.Action = Action;
		}
	}
}