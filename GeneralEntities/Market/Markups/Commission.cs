using System.Runtime.Serialization;

namespace GeneralEntities.Market.Markups
{
	[DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public class Commission : Profit
    {
        [DataMember]
        public Rounding Rounding { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Commission;
            if (other == null) return false;
            return base.Equals(obj) && this.Rounding == other.Rounding;
        }
    }
}