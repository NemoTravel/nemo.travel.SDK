using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			if (Params.ContainsKey(key))
			{
				return Params[key];
			}
			else
			{
				return null;
			}
		}
	}
}
