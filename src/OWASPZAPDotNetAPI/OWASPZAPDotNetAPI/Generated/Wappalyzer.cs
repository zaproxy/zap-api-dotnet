/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2023 the ZAP development team
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
	public class Wappalyzer 
	{
		private ClientApi api = null;

		public Wappalyzer(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Lists all the sites recognized by the wappalyzer addon.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse listSites()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("wappalyzer", "view", "listSites", parameters);
		}

		/// <summary>
		///Lists all sites and their associated applications (technologies).
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse listAll()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("wappalyzer", "view", "listAll", parameters);
		}

		/// <summary>
		///Lists all the applications (technologies) associated with a specific site.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse listSite(string site)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			return api.CallApi("wappalyzer", "view", "listSite", parameters);
		}

	}
}
