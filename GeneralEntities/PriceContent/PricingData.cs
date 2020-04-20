using GeneralEntities.Market;
using GeneralEntities.PNRDataContent;
using System;
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

		/// <summary>
		/// Собственная прибыль агента - часть комиссии АК, которую получает Агент как субагент другого агента
		/// </summary>
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

		[DataMember(Order = 11, EmitDefaultValue = false)]
		public string AcquiringMode { get; set; }

		[DataMember(Order = 12, EmitDefaultValue = false)]
		public bool AutoticketingDisabled { get; set; }


		public PricingData Copy()
		{
			var result = new PricingData();

			result.PricingRule = PricingRule;
			result.Code = Code;

			if (AirlineCommission != null)
			{
				result.AirlineCommission = AirlineCommission.Copy();
			}

			if (AgencyProfit != null)
			{
				result.AgencyProfit = AgencyProfit.Copy();
			}

			result.TicketDesignator = TicketDesignator;
			result.Endorsment = Endorsment;
			result.TourCode = TourCode;
			result.Discount = Discount;

			if (AgencyCommission != null)
			{
				result.AgencyCommission = AgencyCommission.Copy();
			}

			if (Bonus != null)
			{
				result.Bonus = Bonus.Copy();
			}

			result.AuthCode = AuthCode;
			result.AcquiringMode = AcquiringMode;
			result.AutoticketingDisabled = AutoticketingDisabled;

			return result;
		}

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

		public PNRDataItem GetAgencyProfitCommissionDataItem(int passengersWithFareCount)
		{
			PNRDataItem subagentCommissionDI = null;
			if (AgencyProfit != null && (AgencyProfit.Percent.HasValue && AgencyProfit.Percent.Value != 0 || AgencyProfit.Amount.HasValue && AgencyProfit.Amount.Value != 0))
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

		public PNRDataItem GetSubAgentCommissionDataItem()
		{
			PNRDataItem subagentCommissionDI = null;
			if (AgencyCommission != null && AgencyCommission.Value != 0)
			{
				subagentCommissionDI = new PNRDataItem();
				subagentCommissionDI.Type = PNRDataItemType.SubagentCommission;
				subagentCommissionDI.SubagentCommission = new CommissionDataItem();
				subagentCommissionDI.SubagentCommission.Amount = Convert.ToSingle(AgencyCommission.Value);
				subagentCommissionDI.SubagentCommission.Currency = AgencyCommission.Currency;
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

		public T GetDiscountDataItem<T>(ICurrencyConverter currencyConverter, string currency) where T : BasePNRDataItem, new()
		{
			if (string.IsNullOrEmpty(Discount))
			{
				return null;
			}

			DiscountDataItem discountDI = null;

			if (Discount.EndsWith("%"))
			{
				discountDI = new DiscountDataItem();
				discountDI.Percent = Convert.ToSingle(Discount.TrimEnd('%'));
			}
			else
			{
				var discountMoney = currencyConverter.Convert(Money.Parse(Discount), currency);

				discountDI = new DiscountDataItem();
				discountDI.Amount = (float)discountMoney.Value;
				discountDI.Currency = discountMoney.Currency;
			}

			if (discountDI != null)
			{
				discountDI.AuthCode = AuthCode;

				var dataItem = new T();
				dataItem.Type = PNRDataItemType.Discount;
				dataItem.Discount = discountDI;

				return dataItem;
			}

			return null;
		}
	}
}