using System;
using System.Collections.Generic;

namespace GeneralEntities.Static
{
	public static class TimeZoneCache
	{
		private static Dictionary<string, TimeZoneInfo> TimeZones { get; set; }

		static TimeZoneCache()
		{
			TimeZones = new Dictionary<string, TimeZoneInfo>();
			foreach (var timeZone in TimeZoneInfo.GetSystemTimeZones())
			{
				TimeZones[timeZone.Id] = timeZone;
			}
		}

		/// <exception cref="InternalServerError в случае если зона с указанным ID не была найдена"></exception>
		public static TimeZoneInfo GetTimeZoneByID(string id)
		{
			if (TimeZones.ContainsKey(id))
			{
				return TimeZones[id];
			}
			else
			{
				throw new Exception("Временная зона с указанным ID не найдена");
			}
		}
	}
}