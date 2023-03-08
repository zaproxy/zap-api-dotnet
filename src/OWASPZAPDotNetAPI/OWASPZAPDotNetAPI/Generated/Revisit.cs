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
	public class Revisit 
	{
		private ClientApi api = null;

		public Revisit(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse revisitList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("revisit", "view", "revisitList", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse revisitSiteOn(string site, string starttime, string endtime)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("startTime", starttime);
			parameters.Add("endTime", endtime);
			return api.CallApi("revisit", "action", "revisitSiteOn", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse revisitSiteOff(string site)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			return api.CallApi("revisit", "action", "revisitSiteOff", parameters);
		}

	}
}
