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
	public class Pscan 
	{
		private ClientApi api = null;

		public Pscan(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Tells whether or not the passive scan should be performed only on messages that are in scope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanOnlyInScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "view", "scanOnlyInScope", parameters);
		}

		/// <summary>
		///The number of records the passive scanner still has to scan
		/// </summary>
		/// <returns></returns>
		public IApiResponse recordsToScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "view", "recordsToScan", parameters);
		}

		/// <summary>
		///Lists all passive scanners with its ID, name, enabled state and alert threshold.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanners()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "view", "scanners", parameters);
		}

		/// <summary>
		///Show information about the passive scan rule currently being run (if any).
		/// </summary>
		/// <returns></returns>
		public IApiResponse currentRule()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "view", "currentRule", parameters);
		}

		/// <summary>
		///Gets the maximum number of alerts a passive scan rule should raise.
		/// </summary>
		/// <returns></returns>
		public IApiResponse maxAlertsPerRule()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "view", "maxAlertsPerRule", parameters);
		}

		/// <summary>
		///Sets whether or not the passive scanning is enabled (Note: the enabled state is not persisted).
		/// </summary>
		/// <returns></returns>
		public IApiResponse setEnabled(string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("enabled", enabled);
			return api.CallApi("pscan", "action", "setEnabled", parameters);
		}

		/// <summary>
		///Sets whether or not the passive scan should be performed only on messages that are in scope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setScanOnlyInScope(string onlyinscope)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("onlyInScope", onlyinscope);
			return api.CallApi("pscan", "action", "setScanOnlyInScope", parameters);
		}

		/// <summary>
		///Enables all passive scanners
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableAllScanners()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "action", "enableAllScanners", parameters);
		}

		/// <summary>
		///Disables all passive scanners
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableAllScanners()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "action", "disableAllScanners", parameters);
		}

		/// <summary>
		///Enables all passive scanners with the given IDs (comma separated list of IDs)
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableScanners(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApi("pscan", "action", "enableScanners", parameters);
		}

		/// <summary>
		///Disables all passive scanners with the given IDs (comma separated list of IDs)
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableScanners(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApi("pscan", "action", "disableScanners", parameters);
		}

		/// <summary>
		///Sets the alert threshold of the passive scanner with the given ID, accepted values for alert threshold: OFF, DEFAULT, LOW, MEDIUM and HIGH
		/// </summary>
		/// <returns></returns>
		public IApiResponse setScannerAlertThreshold(string id, string alertthreshold)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			return api.CallApi("pscan", "action", "setScannerAlertThreshold", parameters);
		}

		/// <summary>
		///Sets the maximum number of alerts a passive scan rule should raise.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setMaxAlertsPerRule(string maxalerts)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("maxAlerts", maxalerts);
			return api.CallApi("pscan", "action", "setMaxAlertsPerRule", parameters);
		}

		/// <summary>
		///Disables all passive scan tags.
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableAllTags()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "action", "disableAllTags", parameters);
		}

		/// <summary>
		///Enables all passive scan tags.
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableAllTags()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("pscan", "action", "enableAllTags", parameters);
		}

	}
}
