using System.Runtime.Serialization;
using System.Text;

namespace GeneralEntities.PNRDataContent
{
	/// <summary>
	/// Содержит описание унифицированного блока данных ПНРа
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PNRDataItem : BasePNRDataItem
	{
		/// <summary>
		/// Сумма кэша для проксируемой выписки с мультиФОПом
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public CashValueForMultiFOPProxingDataItem CashValueForMultiFOPProxing { get; set; }

		/// <summary>
		/// ФОП из ПНРа
		/// </summary>
		[DataMember(Order = 1, EmitDefaultValue = false)]
		public PNRFOPDataItem PNRFOP { get; set; }

		/// <summary>
		/// Комиссия субагента
		/// </summary>
		[DataMember(Order = 2, EmitDefaultValue = false)]
		public CommissionDataItem SubagentCommission { get; set; }

		/// <summary>
		/// Тикет десигнатор брони
		/// </summary>
		[DataMember(Order = 3, EmitDefaultValue = false)]
		public TicketDesignatorDataItem TicketDesignator { get; set; }

		/// <summary>
		/// Сбор
		/// </summary>
		[DataMember(Order = 4, EmitDefaultValue = false)]
		public MarkupDataItem Markup { get; set; }

		/// <summary>
		/// Данные для проксирования выписки
		/// </summary>
		[DataMember(Order = 5, EmitDefaultValue = false)]
		public TicketingProxyDataItem TicketingProxy { get; set; }

		/// <summary>
		/// Специфичные данные для интеграции с CRM/Back-office на стороне поставщиков контента
		/// </summary>
		[DataMember(Order = 6, EmitDefaultValue = false)]
		public CRMIntegrationDataItem CRMIntegration { get; set; }

		/// <summary>
		/// Данные конечного пользователя
		/// </summary>
		[DataMember(Order = 8, EmitDefaultValue = false)]
		public EndUserDataDataItem EndUserData { get; set; }

		/// <summary>
		/// Описание точки продажи
		/// </summary>
		[DataMember(Order = 9, EmitDefaultValue = false)]
		public SellingPointDescriptionDataItem SellingPointDescription { get; set; }

		/// <summary>
		/// Получение хэша данного элемента, формируемого на основании типа и контента
		/// </summary>
		/// <returns>Хэш данного элемента</returns>
		public string GetHash()
		{
			var result = new StringBuilder(Type.ToString());
			result.Append(";");

			switch (Type)
			{
				case PNRDataItemType.ArrivalAddress:
					result.Append(ArrivalAddress.City);
					result.Append(";");
					result.Append(ArrivalAddress.CountryCode);
					result.Append(";");
					result.Append(ArrivalAddress.PostalCode);
					result.Append(";");
					result.Append(ArrivalAddress.State);
					result.Append(";");
					result.Append(ArrivalAddress.StreetAddress);
					break;
				case PNRDataItemType.BookedSeat:
					result.Append(BookedSeat.Number);
					result.Append(";");
					result.Append(BookedSeat.Characteristic);
					result.Append(";");
					result.Append(BookedSeat.SmokingPreference);
					break;
				case PNRDataItemType.Commission:
					result.Append(Commission.Percent);
					result.Append(";");
					result.Append(Commission.Amount);
					result.Append(";");
					result.Append(Commission.Currency);
					break;
				case PNRDataItemType.ContactInfo:
					if (ContactInfo.EmailID != null)
					{
						result.Append(ContactInfo.EmailID.ToUpper());
					}
					result.Append(";");
					if (ContactInfo.Telephone != null)
					{
						result.Append(ContactInfo.Telephone.Type);
						result.Append(";");
						result.Append(ContactInfo.Telephone.PhoneNumber);
						result.Append(";");
					}
					break;
				case PNRDataItemType.ED:
					result.Append(ElectronicDocument.Number);
					result.Append(";");
					result.Append(ElectronicDocument.ServiceType);
					result.Append(";");
					result.Append(ElectronicDocument.Status);
					result.Append(";");
					result.Append(ElectronicDocument.IssueDateTime);
					result.Append(";");
					result.Append(ElectronicDocument.ExecutionTimeLimit);
					result.Append(";");
					if (ElectronicDocument.ConjunctionNumbers != null)
					{
						foreach (var number in ElectronicDocument.ConjunctionNumbers)
						{
							result.Append(number);
							result.Append(";");
						}
					}
					if (ElectronicDocument.VAT != null)
					{
						result.Append(ElectronicDocument.VAT.ToString());
						result.Append(";");
					}
					if (ElectronicDocument.VATBreakdown != null)
					{
						if (ElectronicDocument.VATBreakdown.Tariff != null)
						{
							result.Append(ElectronicDocument.VATBreakdown.Tariff.ToString());
							result.Append(";");
						}
						if (ElectronicDocument.VATBreakdown.Taxes != null)
						{
							result.Append(ElectronicDocument.VATBreakdown.Taxes.ToString());
							result.Append(";");
						}
						if (ElectronicDocument.VATBreakdown.Total != null)
						{
							result.Append(ElectronicDocument.VATBreakdown.Total.ToString());
							result.Append(";");
						}
					}
					break;
				case PNRDataItemType.FE:
					foreach (var endorsement in Endorsements.EndorsementText)
					{
						result.Append(endorsement);
						result.Append(";");
					}
					break;
				case PNRDataItemType.FOP:
					foreach (var fop in PNRFOP.FOPs)
					{
						result.Append(fop.Type.ToString());
						result.Append(";");
						result.Append(fop.CreditCardNumber);
						result.Append(";");
						result.Append(fop.Number);
						result.Append(";");
					}
					break;
				case PNRDataItemType.IDDocument:
					result.Append(Document.Type);
					result.Append(";");
					result.Append(Document.Number);
					result.Append(";");
					result.Append(Document.IssueCountryCode);
					result.Append(";");
					result.Append(Document.ElapsedTime);
					break;
				case PNRDataItemType.LoyaltyCard:
					result.Append(LoyaltyCard.Owner);
					result.Append(";");
					result.Append(LoyaltyCard.Number);
					result.Append(";");
					result.Append(LoyaltyCard.OwnerType);
					break;
				case PNRDataItemType.Meal:
					result.Append(Meal.Code);
					result.Append(";");
					result.Append(Meal.Text);
					result.Append(";");
					result.Append(Meal.Status);
					result.Append(";");
					result.Append(Meal.StatusCode);
					break;
				case PNRDataItemType.PD:
					result.Append(PaperDocument.Type);
					result.Append(";");
					result.Append(PaperDocument.Format);
					result.Append(";");
					result.Append(PaperDocument.Encoding);
					result.Append(";");
					result.Append(PaperDocument.DocumentData);
					result.Append(";");
					result.Append(PaperDocument.IsBase64Wrapped);
					break;
				case PNRDataItemType.Remark:
					result.Append(Remark.Type);
					result.Append(";");
					result.Append(Remark.Text);
					break;
				case PNRDataItemType.SourceInfo:
					result.Append(SourceInfo.ID);
					result.Append(";");
					result.Append(SourceInfo.Environment);
					result.Append(";");
					result.Append(SourceInfo.Supplier);
					result.Append(";");
					result.Append(SourceInfo.BookingSupplierAgencyID);
					result.Append(";");
					result.Append(SourceInfo.TicketingSupplierAgencyID);
					result.Append(";");
					result.Append(SourceInfo.TicketingIATAValidator);
					break;
				case PNRDataItemType.SSR:
					result.Append(SSR.Code);
					result.Append(";");
					result.Append(SSR.Text);
					result.Append(";");
					result.Append(SSR.Status);
					result.Append(";");
					result.Append(SSR.StatusCode);
					break;
				case PNRDataItemType.TL:
					result.Append(TimeLimits.EffectiveTimeLimit);
					result.Append(";");
					result.Append(TimeLimits.AgencyTimeLimit);
					result.Append(";");
					result.Append(TimeLimits.PriceTimeLimit);
					result.Append(";");
					result.Append(TimeLimits.TicketingTimeLimit);
					result.Append(";");
					result.Append(TimeLimits.AdvancedPurchaseTimeLimit);
					result.Append(";");
					result.Append(TimeLimits.VoidTimeLimit);
					break;
				case PNRDataItemType.ValidatingCompany:
					result.Append(ValidatingCompany.Code);
					result.Append(";");
					result.Append(ValidatingCompany.IsForced);
					break;
				case PNRDataItemType.Visa:
					result.Append(Visa.Number);
					result.Append(";");
					result.Append(Visa.IssueDate);
					result.Append(";");
					result.Append(Visa.IssuePlace);
					result.Append(";");
					result.Append(Visa.BirthPlace);
					result.Append(";");
					result.Append(Visa.ApplicableCountry);
					break;
				case PNRDataItemType.TourCode:
					result.Append(TourCode.Type);
					result.Append(";");
					result.Append(TourCode.Value);
					break;
				case PNRDataItemType.Discount:
					result.Append(Discount.AuthCode);
					result.Append(";");
					result.Append(Discount.Percent);
					result.Append(";");
					result.Append(Discount.Amount);
					result.Append(";");
					result.Append(Discount.Currency);
					break;

				//АПИ данные, используется при выписке, в брони не отображаются
				//case PNRDataItemType.CashValueForMultiFOPProxing:
				//	break;
				//case PNRDataItemType.Markup:
				//	break;
				//case PNRDataItemType.SubagentCommission:
				//	break;
				//case PNRDataItemType.TicketDesignator:
				//	break;
				//case PNRDataItemType.TicketingProxy:
				//	break;


				//внутреннии данные брони, в АПИ не отображаются
				//case PNRDataItemType.FareRules:
				//	break;
			}

			return result.ToString();
		}
	}
}