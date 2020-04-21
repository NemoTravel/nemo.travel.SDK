using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class InvoiceFOP : BaseFOP
	{
		/// <summary>
		/// Номер ФОПа в ПНРе
		/// </summary>
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Number { get; set; }

		[DataMember(Order = 1, EmitDefaultValue = false)]
		public string Subtype { get; set; }

		public override bool Equals(object other)
		{
			var otherFOP = other as InvoiceFOP;
			if (otherFOP != null)
			{
				return Number == otherFOP.Number && Subtype == otherFOP.Subtype && base.Equals(otherFOP);
			}

			return false;
		}

		public override BaseFOP Copy()
		{
			var result = new InvoiceFOP();
			CopyTo(result);
			return result;
		}

		protected new void CopyTo<T>(T fop) where T: InvoiceFOP
		{
			base.CopyTo(fop);

			fop.Number = Number;
			fop.Subtype = Subtype;
		}
	}
}