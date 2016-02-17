using GeneralEntities.BookContent;
using GeneralEntities.ExtendedDateTime;
using GeneralEntities.PNRDataContent;
using GeneralEntities.PriceContent;
using GeneralEntities.Services;
using GeneralEntities.Shared;
using GeneralEntities.Traveller;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Order : ItemIdentification<string>
	{
		/// <summary>
		/// ID владельца брони
		/// </summary>
		[DataMember(Order = 0, IsRequired = true)]
		public OrderSourceInfo OwnerInfo { get; set; }

		/// <summary>
		/// Тип заказа
		/// </summary>
		[DataMember(Order = 1, IsRequired = true)]
		public OrderType Type { get; set; }

		/// <summary>
		/// Статус заказа
		/// </summary>
		[DataMember(Order = 2, IsRequired = true)]
		public PNRStatus Status { get; set; }

		/// <summary>
		/// Подстатус заказа, уточняющий его состояние
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public OrderSubStatus? SubStatus { get; set; }

		[DataMember(Order = 4, IsRequired = true)]
		public OrderPaymentStatus PaymentStatus { get; set; }

		/// <summary>
		/// Информация о времени возникновения различных события с бронью
		/// </summary>
		[DataMember(Order = 5, IsRequired = true)]
		public BookDateInfo DateInfo { get; set; }

		/// <summary>
		/// Список допустимых действий с заказом
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public PNRPossibleActionList PossibleActions { get; set; }

		/// <summary>
		/// Информация о клиентах
		/// </summary>
		[DataMember(Order = 7, IsRequired = true)]
		public TravellerList Travellers { get; set; }

		/// <summary>
		/// Забронированные услуги
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public ServiceList Services { get; set; }

		/// <summary>
		/// Забронированные допуслуги
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public ServiceList AncillaryServices { get; set; }

		/// <summary>
		/// Услуги обработки заказа
		/// </summary>
		[DataMember(Order = 10, EmitDefaultValue = false)]
		public OrderProcessingServiceList ProcessingServices { get; set; }

		/// <summary>
		/// Группы услуг
		/// </summary>
		[DataMember(Order = 11, EmitDefaultValue = false)]
		public List<ServiceGroup> ServiceGroups { get; set; }

		/// <summary>
		/// Цена брони
		/// </summary>
		[DataMember(Order = 12, EmitDefaultValue = false)]
		public Price Price { get; set; }

		/// <summary>
		/// Транзакции оплаты данного заказа
		/// </summary>
		[DataMember(Order = 13, EmitDefaultValue = false)]
		public PaymentTransactionList PaymentTransactions { get; set; }

		/// <summary>
		/// Унифицированные данные брони
		/// </summary>
		[DataMember(Order = 14, EmitDefaultValue = false)]
		public PNRDataItemList DataItems { get; set; }


		public Order()
		{
			OwnerInfo = new OrderSourceInfo();
			DateInfo = new BookDateInfo();
			Travellers = new TravellerList();
			Services = new ServiceList();
			ServiceGroups = new List<ServiceGroup>();
			DataItems = new PNRDataItemList();
			PossibleActions = new PNRPossibleActionList();
		}

		#region Методы для работы с заказом

		/// <summary>
		/// Простановка типа заказа
		/// </summary>
		public void SetOrderType()
		{
			if (Services.All(s => s.IsOffline))
			{
				Type = OrderType.Offline;
			}
			else if (!Services.All(s => s.IsOffline))
			{
				Type = OrderType.Online;
			}
			else
			{
				Type = OrderType.Mixed;
			}
		}

		/// <summary>
		/// Простановка даты создание брони на сервере
		/// </summary>
		public void SetCreationDate()
		{
			DateInfo.Created = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты последнего обновления брони
		/// </summary>
		public void SetLastUpdateDate()
		{
			DateInfo.LastUpdate = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты последнего доступа к брони
		/// </summary>
		public void SetLastAccessDate()
		{
			DateInfo.LastAccess = DateTimeEx.Now;
		}

		/// <summary>
		/// Проставление даты выписки
		/// </summary>
		public void SetTicketingDate()
		{
			DateInfo.Ticketed = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты войдирования брони на сервере
		/// </summary>
		public void SetVoidingDate()
		{
			DateInfo.Voided = DateTimeEx.Now;
		}

		/// <summary>
		/// Простановка даты отмены брони на сервере
		/// </summary>
		public void SetCancelingDate()
		{
			DateInfo.Canceled = DateTimeEx.Now;
		}

		/// <summary>
		/// Перенумеровка контента
		/// </summary>
		public void RenumDataItems()
		{
			if (DataItems != null && DataItems.Count > 0)
			{
				for (int i = 0; i < DataItems.Count; i++)
				{
					DataItems[i].ID = i;
				}
			}
		}

		/// <summary>
		/// Получение эффективного ТЛ заказа
		/// </summary>
		/// <returns>Эффективный ТЛ</returns>
		public DateTimeEx GetEffectiveTimeLimit()
		{
			return DataItems.Find(di => di.Type == PNRDataItemType.TL).TimeLimits.EffectiveTimeLimit;
		}

		/// <summary>
		/// Получение ИД брони для определённой услуги
		/// </summary>
		/// <param name="serviceID">ИД услуги, ИД брони которой требуется получить</param>
		/// <returns>ИД брони для запрошенной услуги</returns>
		public long GetBookID(int serviceID)
		{
			return ServiceGroups.Find(sg => sg.GroupType == ServiceGroupType.SingleBook && sg.ServiceRef.Contains(serviceID)).BookID.Value;
		}

		#endregion	
	}
}