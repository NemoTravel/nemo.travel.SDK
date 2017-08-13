using GeneralEntities.Market;
using GeneralEntities.PNRDataContent;
using System.Runtime.Serialization;

namespace GeneralEntities.PriceContent
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PricingData
	{
		[DataMember(Order = 0, IsRequired = true)]
		public int PricingRule { get; set; }

		[DataMember(Order = 1, IsRequired = true)]
		public string Code { get; set; }

		[DataMember(Order = 2, EmitDefaultValue = false)]
		public CommissionDataItem AirlineCommission { get; set; }

		[DataMember(Order = 3, EmitDefaultValue = false)]
		public CommissionDataItem AgencyProfit { get; set; }

		[DataMember(Order = 4, EmitDefaultValue = false)]
		public string TicketDesignator { get; set; }

		[DataMember(Order = 5, EmitDefaultValue = false)]
		public string Endorsment { get; set; }

		[DataMember(Order = 6, EmitDefaultValue = false)]
		public string TourCode { get; set; }

		[DataMember(Order = 7, EmitDefaultValue = false)]
		public string Discount { get; set; }

		[DataMember(Order = 8, EmitDefaultValue = false)]
		public Money AgencyCommission { get; set; }

		[DataMember(Order = 9, EmitDefaultValue = false)]
		public Money Bonus { get; set; }

		[DataMember(Order = 10, EmitDefaultValue = false)]
		public string AuthCode { get; set; }

		public PricingData Clone()
		{
			var result = new PricingData();

			result.PricingRule = PricingRule;
			result.Code = Code;
			result.TicketDesignator = TicketDesignator;
			result.Endorsment = Endorsment;
			result.TourCode = TourCode;
			result.Discount = Discount;
			result.AuthCode = AuthCode;
			result.AgencyCommission = AgencyCommission != null ? new Money(AgencyCommission) : null;
			result.Bonus = Bonus != null ? new Money(Bonus) : null;
			if (AirlineCommission != null)
			{
				result.AirlineCommission = new CommissionDataItem
				{
					Amount = AirlineCommission.Amount,
					Currency = AirlineCommission.Currency,
					Percent = AirlineCommission.Percent
				};
			}
			if (AgencyProfit != null)
			{
				result.AgencyProfit = new CommissionDataItem
				{
					Amount = AgencyProfit.Amount,
					Currency = AgencyProfit.Currency,
					Percent = AgencyProfit.Percent
				};
			}

			return result;
		}

		#region Генерация DataItem'ов

		public T GetCommissionDataItem<T>(int passengersWithFareCount) where T : BasePNRDataItem, new()
		{
			T commissionDI = null;
			if (AirlineCommission != null)
			{
				commissionDI = new T();
				commissionDI.Type = PNRDataItemType.Commission;
				commissionDI.Commission = new CommissionDataItem();
				commissionDI.Commission.Amount = AirlineCommission.Amount;
				commissionDI.Commission.Currency = AirlineCommission.Currency;
				commissionDI.Commission.Percent = AirlineCommission.Percent;

				if (commissionDI.Commission.Amount.HasValue)
				{
					commissionDI.Commission.Amount /= passengersWithFareCount;
				}
			}

			return commissionDI;
		}

		public PNRDataItem GetSubagentCommissionDataItem(int passengersWithFareCount)
		{
			PNRDataItem subagentCommissionDI = null;
			if (AgencyProfit != null)
			{
				subagentCommissionDI = new PNRDataItem();
				subagentCommissionDI.Type = PNRDataItemType.SubagentCommission;
				subagentCommissionDI.SubagentCommission = new CommissionDataItem();
				subagentCommissionDI.SubagentCommission.Amount = AgencyProfit.Amount;
				subagentCommissionDI.SubagentCommission.Currency = AgencyProfit.Currency;
				subagentCommissionDI.SubagentCommission.Percent = AgencyProfit.Percent;

				if (subagentCommissionDI.SubagentCommission.Amount.HasValue)
				{
					subagentCommissionDI.SubagentCommission.Amount /= passengersWithFareCount;
				}
			}

			return subagentCommissionDI;
		}

		public T GetEndorsmentDataItem<T>() where T : BasePNRDataItem, new()
		{
			T endorsmentDI = null;
			if (!string.IsNullOrEmpty(Endorsment))
			{
				endorsmentDI = new T();
				endorsmentDI.Type = PNRDataItemType.FE;
				endorsmentDI.Endorsements = new EndorsementDataItem();
				endorsmentDI.Endorsements.EndorsementText = new Shared.TextList();
				endorsmentDI.Endorsements.EndorsementText.Add(Endorsment.Trim());
			}

			return endorsmentDI;
		}

		public T GetTicketDesignatorDataItem<T>() where T : BasePNRDataItem, new()
		{
			T tktDesignatorDI = null;
			if (!string.IsNullOrEmpty(TicketDesignator))
			{
				tktDesignatorDI = new T();
				tktDesignatorDI.Type = PNRDataItemType.Discount;
				tktDesignatorDI.Discount = new DiscountDataItem();
				tktDesignatorDI.Discount.Percent = 0;
				tktDesignatorDI.Discount.AuthCode = TicketDesignator;
			}

			return tktDesignatorDI;
		}

		public T GetTourCodeDataItem<T>() where T : BasePNRDataItem, new()
		{
			T tourCodeDI = null;
			if (!string.IsNullOrEmpty(TourCode))
			{
				tourCodeDI = new T();
				tourCodeDI.Type = PNRDataItemType.TourCode;
				tourCodeDI.TourCode = new TourCodeDataItem();
				tourCodeDI.TourCode.Type = TourCodeType.Unprintable;
				tourCodeDI.TourCode.Value = TourCode;
			}

			return tourCodeDI;
		}

		public T GetValidatingCompanyDataItem<T>(string supplierValCompany) where T : BasePNRDataItem, new()
		{
			T valCompanyDI = new T();
			valCompanyDI.Type = PNRDataItemType.ValidatingCompany;
			valCompanyDI.ValidatingCompany = new ValidatingCompanyDataItem();
			valCompanyDI.ValidatingCompany.Code = Code;
			valCompanyDI.ValidatingCompany.IsForced = Code != supplierValCompany;

			return valCompanyDI;
		}

		#endregion
	}
}
