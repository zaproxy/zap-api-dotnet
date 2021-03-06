/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2021 the ZAP development team
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
	public class AlertFilter 
	{
		private ClientApi api = null;

		public AlertFilter(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Lists the alert filters of the context with the given ID.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse alertFilterList(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("alertFilter", "view", "alertFilterList", parameters);
		}

		/// <summary>
		///Lists the global alert filters.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse globalAlertFilterList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("alertFilter", "view", "globalAlertFilterList", parameters);
		}

		/// <summary>
		///Adds a new alert filter for the context with the given ID. 
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addAlertFilter(string contextid, string ruleid, string newlevel, string url, string urlisregex, string parameter, string enabled, string parameterisregex, string attack, string attackisregex, string evidence, string evidenceisregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("ruleId", ruleid);
			parameters.Add("newLevel", newlevel);
			parameters.Add("url", url);
			parameters.Add("urlIsRegex", urlisregex);
			parameters.Add("parameter", parameter);
			parameters.Add("enabled", enabled);
			parameters.Add("parameterIsRegex", parameterisregex);
			parameters.Add("attack", attack);
			parameters.Add("attackIsRegex", attackisregex);
			parameters.Add("evidence", evidence);
			parameters.Add("evidenceIsRegex", evidenceisregex);
			return api.CallApi("alertFilter", "action", "addAlertFilter", parameters);
		}

		/// <summary>
		///Removes an alert filter from the context with the given ID.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeAlertFilter(string contextid, string ruleid, string newlevel, string url, string urlisregex, string parameter, string enabled, string parameterisregex, string attack, string attackisregex, string evidence, string evidenceisregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("ruleId", ruleid);
			parameters.Add("newLevel", newlevel);
			parameters.Add("url", url);
			parameters.Add("urlIsRegex", urlisregex);
			parameters.Add("parameter", parameter);
			parameters.Add("enabled", enabled);
			parameters.Add("parameterIsRegex", parameterisregex);
			parameters.Add("attack", attack);
			parameters.Add("attackIsRegex", attackisregex);
			parameters.Add("evidence", evidence);
			parameters.Add("evidenceIsRegex", evidenceisregex);
			return api.CallApi("alertFilter", "action", "removeAlertFilter", parameters);
		}

		/// <summary>
		///Adds a new global alert filter. 
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addGlobalAlertFilter(string ruleid, string newlevel, string url, string urlisregex, string parameter, string enabled, string parameterisregex, string attack, string attackisregex, string evidence, string evidenceisregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ruleId", ruleid);
			parameters.Add("newLevel", newlevel);
			parameters.Add("url", url);
			parameters.Add("urlIsRegex", urlisregex);
			parameters.Add("parameter", parameter);
			parameters.Add("enabled", enabled);
			parameters.Add("parameterIsRegex", parameterisregex);
			parameters.Add("attack", attack);
			parameters.Add("attackIsRegex", attackisregex);
			parameters.Add("evidence", evidence);
			parameters.Add("evidenceIsRegex", evidenceisregex);
			return api.CallApi("alertFilter", "action", "addGlobalAlertFilter", parameters);
		}

		/// <summary>
		///Removes a global alert filter.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeGlobalAlertFilter(string ruleid, string newlevel, string url, string urlisregex, string parameter, string enabled, string parameterisregex, string attack, string attackisregex, string evidence, string evidenceisregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ruleId", ruleid);
			parameters.Add("newLevel", newlevel);
			parameters.Add("url", url);
			parameters.Add("urlIsRegex", urlisregex);
			parameters.Add("parameter", parameter);
			parameters.Add("enabled", enabled);
			parameters.Add("parameterIsRegex", parameterisregex);
			parameters.Add("attack", attack);
			parameters.Add("attackIsRegex", attackisregex);
			parameters.Add("evidence", evidence);
			parameters.Add("evidenceIsRegex", evidenceisregex);
			return api.CallApi("alertFilter", "action", "removeGlobalAlertFilter", parameters);
		}

	}
}
