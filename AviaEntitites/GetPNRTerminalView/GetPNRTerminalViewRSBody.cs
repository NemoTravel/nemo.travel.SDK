using System.Runtime.Serialization;

namespace AviaEntities.GetPNRTerminalView
{
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class GetPNRTerminalViewRSBody
	{
		[DataMember(Order = 0, IsRequired = true)]
		public string TerminalView { get; set; }
	}
}