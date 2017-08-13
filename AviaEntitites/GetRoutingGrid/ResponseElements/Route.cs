using GeneralEntities.Services;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace AviaEntities.GetRoutingGrid
{
	/// <summary>
	/// Содержит информацию о маршруте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	[DebuggerDisplay("[{ArrPoint}]")]
	public class Route
	{
		/// <summary>
		/// Признак является ли перелет прямым
		/// </summary>
		[DataMember(Order = 0)]
		public bool IsDirect { get; set; }

		/// <summary>
		/// Точка прибытия маршрута
		/// </summary>
		[DataMember(Order = 1)]
		public TripPointInformation ArrPoint { get; set; }


		public Route() { }

		public Route(bool isDirect, TripPointInformation arrPoint)
		{
			IsDirect = isDirect;
			ArrPoint = arrPoint;
		}


		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}

			if (obj == this)
			{
				return true;
			}

			var route = obj as Route;
			if (route != null)
			{
				if (route.IsDirect == this.IsDirect &&
					route.ArrPoint != null &&
					route.ArrPoint.Equals(this.ArrPoint))
				{
					return true;
				}
			}

			return false;
		}

		public override int GetHashCode()
		{
			return IsDirect.GetHashCode() + ArrPoint.GetHashCode();
		}
	}
}
