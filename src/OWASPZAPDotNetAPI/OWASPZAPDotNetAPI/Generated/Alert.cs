/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2020 the ZAP development team
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
	public class Alert 
	{
		private ClientApi api = null;

		public Alert(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets the alert with the given ID, the corresponding HTTP message can be obtained with the 'messageId' field and 'message' API method
		/// </summary>
		/// <returns></returns>
		public IApiResponse alert(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("alert", "view", "alert", parameters);
		}

		/// <summary>
		///Gets the alerts raised by ZAP, optionally filtering by URL or riskId, and paginating with 'start' position and 'count' of alerts
		/// </summary>
		/// <returns></returns>
		public IApiResponse alerts(string baseurl, string start, string count, string riskid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			parameters.Add("riskId", riskid);
			return api.CallApi("alert", "view", "alerts", parameters);
		}

		/// <summary>
		///Gets number of alerts grouped by each risk level, optionally filtering by URL
		/// </summary>
		/// <returns></returns>
		public IApiResponse alertsSummary(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return api.CallApi("alert", "view", "alertsSummary", parameters);
		}

		/// <summary>
		///Gets the number of alerts, optionally filtering by URL or riskId
		/// </summary>
		/// <returns></returns>
		public IApiResponse numberOfAlerts(string baseurl, string riskid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("riskId", riskid);
			return api.CallApi("alert", "view", "numberOfAlerts", parameters);
		}

		/// <summary>
		///Gets a summary of the alerts, optionally filtered by a 'url'. If 'recurse' is true then all alerts that apply to urls that start with the specified 'url' will be returned, otherwise only those on exactly the same 'url' (ignoring url parameters)
		/// </summary>
		/// <returns></returns>
		public IApiResponse alertsByRisk(string url, string recurse)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("recurse", recurse);
			return api.CallApi("alert", "view", "alertsByRisk", parameters);
		}

		/// <summary>
		///Gets a count of the alerts, optionally filtered as per alertsPerRisk
		/// </summary>
		/// <returns></returns>
		public IApiResponse alertCountsByRisk(string url, string recurse)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("recurse", recurse);
			return api.CallApi("alert", "view", "alertCountsByRisk", parameters);
		}

		/// <summary>
		///Deletes all alerts of the current session.
		/// </summary>
		/// <returns></returns>
		public IApiResponse deleteAllAlerts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("alert", "action", "deleteAllAlerts", parameters);
		}

		/// <summary>
		///Deletes the alert with the given ID. 
		/// </summary>
		/// <returns></returns>
		public IApiResponse deleteAlert(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("alert", "action", "deleteAlert", parameters);
		}

		/// <summary>
		///Update the alert with the given ID, with the provided details.
		/// </summary>
		/// <returns></returns>
		public IApiResponse updateAlert(string id, string name, string riskid, string confidenceid, string description, string param, string attack, string otherinfo, string solution, string references, string evidence, string cweid, string wascid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("name", name);
			parameters.Add("riskId", riskid);
			parameters.Add("confidenceId", confidenceid);
			parameters.Add("description", description);
			parameters.Add("param", param);
			parameters.Add("attack", attack);
			parameters.Add("otherInfo", otherinfo);
			parameters.Add("solution", solution);
			parameters.Add("references", references);
			parameters.Add("evidence", evidence);
			parameters.Add("cweId", cweid);
			parameters.Add("wascId", wascid);
			return api.CallApi("alert", "action", "updateAlert", parameters);
		}

		/// <summary>
		///Add an alert associated with the given message ID, with the provided details. (The ID of the created alert is returned.)
		/// </summary>
		/// <returns></returns>
		public IApiResponse addAlert(string messageid, string name, string riskid, string confidenceid, string description, string param, string attack, string otherinfo, string solution, string references, string evidence, string cweid, string wascid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("messageId", messageid);
			parameters.Add("name", name);
			parameters.Add("riskId", riskid);
			parameters.Add("confidenceId", confidenceid);
			parameters.Add("description", description);
			parameters.Add("param", param);
			parameters.Add("attack", attack);
			parameters.Add("otherInfo", otherinfo);
			parameters.Add("solution", solution);
			parameters.Add("references", references);
			parameters.Add("evidence", evidence);
			parameters.Add("cweId", cweid);
			parameters.Add("wascId", wascid);
			return api.CallApi("alert", "action", "addAlert", parameters);
		}

	}
}
