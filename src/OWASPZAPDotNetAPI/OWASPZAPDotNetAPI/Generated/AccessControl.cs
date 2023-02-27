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
	public class AccessControl 
	{
		private ClientApi api = null;

		public AccessControl(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets the Access Control scan progress (percentage integer) for the given context ID.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getScanProgress(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("accessControl", "view", "getScanProgress", parameters);
		}

		/// <summary>
		///Gets the Access Control scan status (description string) for the given context ID.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getScanStatus(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("accessControl", "view", "getScanStatus", parameters);
		}

		/// <summary>
		///Starts an Access Control scan with the given context ID and user ID. (Optional parameters: user ID for Unauthenticated user, boolean identifying whether or not Alerts are raised, and the Risk level for the Alerts.) [This assumes the Access Control rules were previously established via ZAP gui and the necessary Context exported/imported.]
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse scan(string contextid, string userid, string scanasunauthuser, string raisealert, string alertrisklevel)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("scanAsUnAuthUser", scanasunauthuser);
			parameters.Add("raiseAlert", raisealert);
			parameters.Add("alertRiskLevel", alertrisklevel);
			return api.CallApi("accessControl", "action", "scan", parameters);
		}

		/// <summary>
		///Generates an Access Control report for the given context ID and saves it based on the provided filename (path). 
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse writeHTMLreport(string contextid, string filename)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("fileName", filename);
			return api.CallApi("accessControl", "action", "writeHTMLreport", parameters);
		}

	}
}
