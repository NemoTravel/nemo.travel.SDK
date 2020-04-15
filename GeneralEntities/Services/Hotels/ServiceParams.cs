using System.Collections.Generic;

namespace GeneralEntities.Services.Hotels
{
	public class ServiceParams
	{
		public Dictionary<string, string> Params = new Dictionary<string, string>();

		public void SetServiceParam(string key, string value)
		{
			Params[key] = value;
		}

		public string GetServiceParam(string key)
		{
			if (Params.TryGetValue(key, out string value))
			{
				return value;
			}

			return null;
		}
	}
}