/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2017 the ZAP development team
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */



using System;
using System.Collections.Generic;
using System.Text;


/*
 * This file was automatically generated.
 */
namespace OWASPZAPDotNetAPI.Generated
{
	public class Stats 
	{
		private IClientApi api = null;

		public Stats(IClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Statistics
		/// </summary>
		/// <returns></returns>
		public IApiResponse stats(string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("keyPrefix", keyprefix);
			return api.CallApi("stats", "view", "stats", parameters);
		}

		/// <summary>
		///Gets all of the site based statistics, optionally filtered by a key prefix
		/// </summary>
		/// <returns></returns>
		public IApiResponse allSitesStats(string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("keyPrefix", keyprefix);
			return api.CallApi("stats", "view", "allSitesStats", parameters);
		}

		/// <summary>
		///Gets all of the global statistics, optionally filtered by a key prefix
		/// </summary>
		/// <returns></returns>
		public IApiResponse siteStats(string site, string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("keyPrefix", keyprefix);
			return api.CallApi("stats", "view", "siteStats", parameters);
		}

		/// <summary>
		///Gets the Statsd service hostname
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionStatsdHost()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("stats", "view", "optionStatsdHost", parameters);
		}

		/// <summary>
		///Gets the Statsd service port
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionStatsdPort()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("stats", "view", "optionStatsdPort", parameters);
		}

		/// <summary>
		///Gets the prefix to be applied to all stats sent to the configured Statsd service
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionStatsdPrefix()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("stats", "view", "optionStatsdPrefix", parameters);
		}

		/// <summary>
		///Returns 'true' if in memory statistics are enabled, otherwise returns 'false'
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionInMemoryEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("stats", "view", "optionInMemoryEnabled", parameters);
		}

		/// <summary>
		///Returns 'true' if a Statsd server has been correctly configured, otherwise returns 'false'
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionStatsdEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("stats", "view", "optionStatsdEnabled", parameters);
		}

		/// <summary>
		///Clears all of the statistics
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearStats(string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("keyPrefix", keyprefix);
			return api.CallApi("stats", "action", "clearStats", parameters);
		}

		/// <summary>
		///Sets the Statsd service hostname, supply an empty string to stop using a Statsd service
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionStatsdHost(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("stats", "action", "setOptionStatsdHost", parameters);
		}

		/// <summary>
		///Sets the prefix to be applied to all stats sent to the configured Statsd service
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionStatsdPrefix(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("stats", "action", "setOptionStatsdPrefix", parameters);
		}

		/// <summary>
		///Sets whether in memory statistics are enabled
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionInMemoryEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("stats", "action", "setOptionInMemoryEnabled", parameters);
		}

		/// <summary>
		///Sets the Statsd service port
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionStatsdPort(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("stats", "action", "setOptionStatsdPort", parameters);
		}

	}
}
