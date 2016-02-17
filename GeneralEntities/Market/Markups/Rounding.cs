using System.Runtime.Serialization;

namespace GeneralEntities.Market.Markups
{
	/// <summary>
	/// Тип округления
	/// </summary>
    [DataContract(Namespace = "http://nemo-ibe.com/STL")]
	public enum Rounding
	{
        [EnumMember]
		Arithmetic = 0,

        [EnumMember]
		Up = 1,

        [EnumMember]
		Down = 2,

		/// <summary>
		/// До кратного 5, например 10, 25, 365
		/// </summary>
        [EnumMember]
        Multiple5 = 5,

        [EnumMember]
		Multiple10   = 10,

        [EnumMember]
        Multiple50 = 50,

        [EnumMember]
        Multiple100  = 100,

        [EnumMember]
        Multiple1000 = 1000
	}
}