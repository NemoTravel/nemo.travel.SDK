using System;
using System.Runtime.Serialization;

namespace GeneralEntities.PNRDataContent.FOP
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class PrepaymentFOP : BaseFOP, IEquatable<PrepaymentFOP>
	{
		[DataMember(Order = 0, EmitDefaultValue = false)]
		public string Number { get; set; }


		/// <inheritdoc />
		public bool Equals(PrepaymentFOP other) => Number == other.Number && base.Equals(other);

		public override BaseFOP Copy()
		{
			var result = new PrepaymentFOP();
			CopyTo(result);
			return result;
		}


		private new void CopyTo<T>(T fop) where T : PrepaymentFOP
		{
			base.CopyTo(fop);

			fop.Number = Number;
		}
	}
}