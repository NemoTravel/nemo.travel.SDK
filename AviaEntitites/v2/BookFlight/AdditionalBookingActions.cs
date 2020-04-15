using GeneralEntities.Shared;
using System.Runtime.Serialization;
using System;
using SharedAssembly.Extensions;

namespace AviaEntities.v2.BookFlight
{
	/// <summary>
	/// Содержит описание дополнительных действий при создании брони
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class AdditionalBookingActions
	{
		/// <summary>
		/// Номер очереди, в которую требуется поместить бронь
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string QueueNum { get; set; }

		/// <summary>
		/// Терминальные команды, дополнительно выполняющиеся при создании брони
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public TextList HostCommandsToExecute { get; set; }

		/// <summary>
		/// Название компании, из профиля которой необходимо перенести данные в ПНР (Amadeus)
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public string BusinessProfileToTransfer { get; set; }


		public AdditionalBookingActions Copy()
		{
			var result = new AdditionalBookingActions();

			result = new AdditionalBookingActions();
			result.QueueNum = QueueNum;
			result.BusinessProfileToTransfer = BusinessProfileToTransfer;

			if (!HostCommandsToExecute.IsNullOrEmpty())
			{
				result.HostCommandsToExecute = new TextList(HostCommandsToExecute);
			}

			return result;
		}
	}
}