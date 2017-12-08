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
	public class Ascan 
	{
		private ClientApi api = null;

		public Ascan(ClientApi api) 
		{
			this.api = api;
		}

		public IApiResponse status(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "status", parameters);
		}

		public IApiResponse scanProgress(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "scanProgress", parameters);
		}

		/// <summary>
		///Gets the IDs of the messages sent during the scan with the given ID. A message can be obtained with 'message' core view.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesIds(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "messagesIds", parameters);
		}

		/// <summary>
		///Gets the IDs of the alerts raised during the scan with the given ID. An alert can be obtained with 'alert' core view.
		/// </summary>
		/// <returns></returns>
		public IApiResponse alertsIds(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "alertsIds", parameters);
		}

		public IApiResponse scans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "scans", parameters);
		}

		public IApiResponse scanPolicyNames()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "scanPolicyNames", parameters);
		}

		/// <summary>
		///Gets the regexes of URLs excluded from the active scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedFromScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "excludedFromScan", parameters);
		}

		public IApiResponse scanners(string scanpolicyname, string policyid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("policyId", policyid);
			return api.CallApi("ascan", "view", "scanners", parameters);
		}

		public IApiResponse policies(string scanpolicyname, string policyid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("policyId", policyid);
			return api.CallApi("ascan", "view", "policies", parameters);
		}

		public IApiResponse attackModeQueue()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "attackModeQueue", parameters);
		}

		/// <summary>
		///Gets all the parameters that are excluded. For each parameter the following are shown: the name, the URL, and the parameter type.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedParams()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "excludedParams", parameters);
		}

		/// <summary>
		///Use view excludedParams instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionExcludedParamList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionExcludedParamList", parameters);
		}

		/// <summary>
		///Gets all the types of excluded parameters. For each type the following are shown: the ID and the name.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedParamTypes()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "excludedParamTypes", parameters);
		}

		public IApiResponse optionAttackPolicy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionAttackPolicy", parameters);
		}

		public IApiResponse optionDefaultPolicy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionDefaultPolicy", parameters);
		}

		public IApiResponse optionDelayInMs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionDelayInMs", parameters);
		}

		public IApiResponse optionHandleAntiCSRFTokens()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionHandleAntiCSRFTokens", parameters);
		}

		public IApiResponse optionHostPerScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionHostPerScan", parameters);
		}

		public IApiResponse optionMaxChartTimeInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxChartTimeInMins", parameters);
		}

		public IApiResponse optionMaxResultsToList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxResultsToList", parameters);
		}

		public IApiResponse optionMaxRuleDurationInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxRuleDurationInMins", parameters);
		}

		public IApiResponse optionMaxScanDurationInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxScanDurationInMins", parameters);
		}

		public IApiResponse optionMaxScansInUI()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxScansInUI", parameters);
		}

		public IApiResponse optionTargetParamsEnabledRPC()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionTargetParamsEnabledRPC", parameters);
		}

		public IApiResponse optionTargetParamsInjectable()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionTargetParamsInjectable", parameters);
		}

		public IApiResponse optionThreadPerHost()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionThreadPerHost", parameters);
		}

		public IApiResponse optionAllowAttackOnStart()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionAllowAttackOnStart", parameters);
		}

		/// <summary>
		///Tells whether or not the active scanner should inject the HTTP request header X-ZAP-Scan-ID, with the ID of the scanner that's sending the requests.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionInjectPluginIdInHeader()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionInjectPluginIdInHeader", parameters);
		}

		public IApiResponse optionPromptInAttackMode()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionPromptInAttackMode", parameters);
		}

		public IApiResponse optionPromptToClearFinishedScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionPromptToClearFinishedScans", parameters);
		}

		public IApiResponse optionRescanInAttackMode()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionRescanInAttackMode", parameters);
		}

		/// <summary>
		///Tells whether or not the HTTP Headers of all requests should be scanned. Not just requests that send parameters, through the query or request body.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionScanHeadersAllRequests()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionScanHeadersAllRequests", parameters);
		}

		public IApiResponse optionShowAdvancedDialog()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionShowAdvancedDialog", parameters);
		}

		/// <summary>
		///Runs the active scanner against the given URL and/or Context. Optionally, the 'recurse' parameter can be used to scan URLs under the given URL, the parameter 'inScopeOnly' can be used to constrain the scan to URLs that are in scope (ignored if a Context is specified), the parameter 'scanPolicyName' allows to specify the scan policy (if none is given it uses the default scan policy), the parameters 'method' and 'postData' allow to select a given request in conjunction with the given URL.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scan(string url, string recurse, string inscopeonly, string scanpolicyname, string method, string postdata, string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("recurse", recurse);
			parameters.Add("inScopeOnly", inscopeonly);
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("method", method);
			parameters.Add("postData", postdata);
			parameters.Add("contextId", contextid);
			return api.CallApi("ascan", "action", "scan", parameters);
		}

		/// <summary>
		///Active Scans from the perspective of a User, obtained using the given Context ID and User ID. See 'scan' action for more details.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanAsUser(string url, string contextid, string userid, string recurse, string scanpolicyname, string method, string postdata)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("recurse", recurse);
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("method", method);
			parameters.Add("postData", postdata);
			return api.CallApi("ascan", "action", "scanAsUser", parameters);
		}

		public IApiResponse pause(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "pause", parameters);
		}

		public IApiResponse resume(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "resume", parameters);
		}

		public IApiResponse stop(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "stop", parameters);
		}

		public IApiResponse removeScan(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "removeScan", parameters);
		}

		public IApiResponse pauseAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "pauseAllScans", parameters);
		}

		public IApiResponse resumeAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "resumeAllScans", parameters);
		}

		public IApiResponse stopAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "stopAllScans", parameters);
		}

		public IApiResponse removeAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "removeAllScans", parameters);
		}

		/// <summary>
		///Clears the regexes of URLs excluded from the active scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearExcludedFromScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "clearExcludedFromScan", parameters);
		}

		/// <summary>
		///Adds a regex of URLs that should be excluded from the active scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeFromScan(string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			return api.CallApi("ascan", "action", "excludeFromScan", parameters);
		}

		public IApiResponse enableAllScanners(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableAllScanners", parameters);
		}

		public IApiResponse disableAllScanners(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableAllScanners", parameters);
		}

		public IApiResponse enableScanners(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableScanners", parameters);
		}

		public IApiResponse disableScanners(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableScanners", parameters);
		}

		public IApiResponse setEnabledPolicies(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setEnabledPolicies", parameters);
		}

		public IApiResponse setPolicyAttackStrength(string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAttackStrength", parameters);
		}

		public IApiResponse setPolicyAlertThreshold(string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAlertThreshold", parameters);
		}

		public IApiResponse setScannerAttackStrength(string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAttackStrength", parameters);
		}

		public IApiResponse setScannerAlertThreshold(string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAlertThreshold", parameters);
		}

		public IApiResponse addScanPolicy(string scanpolicyname, string alertthreshold, string attackstrength)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("attackStrength", attackstrength);
			return api.CallApi("ascan", "action", "addScanPolicy", parameters);
		}

		public IApiResponse removeScanPolicy(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "removeScanPolicy", parameters);
		}

		public IApiResponse updateScanPolicy(string scanpolicyname, string alertthreshold, string attackstrength)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("attackStrength", attackstrength);
			return api.CallApi("ascan", "action", "updateScanPolicy", parameters);
		}

		/// <summary>
		///Imports a Scan Policy using the given file system path.
		/// </summary>
		/// <returns></returns>
		public IApiResponse importScanPolicy(string path)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("path", path);
			return api.CallApi("ascan", "action", "importScanPolicy", parameters);
		}

		/// <summary>
		///Adds a new parameter excluded from the scan, using the specified name. Optionally sets if the new entry applies to a specific URL (default, all URLs) and sets the ID of the type of the parameter (default, ID of any type). The type IDs can be obtained with the view excludedParamTypes. 
		/// </summary>
		/// <returns></returns>
		public IApiResponse addExcludedParam(string name, string type, string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("type", type);
			parameters.Add("url", url);
			return api.CallApi("ascan", "action", "addExcludedParam", parameters);
		}

		/// <summary>
		///Modifies a parameter excluded from the scan. Allows to modify the name, the URL and the type of parameter. The parameter is selected with its index, which can be obtained with the view excludedParams.
		/// </summary>
		/// <returns></returns>
		public IApiResponse modifyExcludedParam(string idx, string name, string type, string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			parameters.Add("name", name);
			parameters.Add("type", type);
			parameters.Add("url", url);
			return api.CallApi("ascan", "action", "modifyExcludedParam", parameters);
		}

		/// <summary>
		///Removes a parameter excluded from the scan, with the given index. The index can be obtained with the view excludedParams.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeExcludedParam(string idx)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			return api.CallApi("ascan", "action", "removeExcludedParam", parameters);
		}

		/// <summary>
		///Skips the scanner using the given IDs of the scan and the scanner.
		/// </summary>
		/// <returns></returns>
		public IApiResponse skipScanner(string scanid, string scannerid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			parameters.Add("scannerId", scannerid);
			return api.CallApi("ascan", "action", "skipScanner", parameters);
		}

		public IApiResponse setOptionAttackPolicy(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionAttackPolicy", parameters);
		}

		public IApiResponse setOptionDefaultPolicy(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionDefaultPolicy", parameters);
		}

		public IApiResponse setOptionAllowAttackOnStart(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionAllowAttackOnStart", parameters);
		}

		public IApiResponse setOptionDelayInMs(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionDelayInMs", parameters);
		}

		public IApiResponse setOptionHandleAntiCSRFTokens(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionHandleAntiCSRFTokens", parameters);
		}

		public IApiResponse setOptionHostPerScan(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionHostPerScan", parameters);
		}

		/// <summary>
		///Sets whether or not the active scanner should inject the HTTP request header X-ZAP-Scan-ID, with the ID of the scanner that's sending the requests.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionInjectPluginIdInHeader(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionInjectPluginIdInHeader", parameters);
		}

		public IApiResponse setOptionMaxChartTimeInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxChartTimeInMins", parameters);
		}

		public IApiResponse setOptionMaxResultsToList(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxResultsToList", parameters);
		}

		public IApiResponse setOptionMaxRuleDurationInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxRuleDurationInMins", parameters);
		}

		public IApiResponse setOptionMaxScanDurationInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScanDurationInMins", parameters);
		}

		public IApiResponse setOptionMaxScansInUI(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScansInUI", parameters);
		}

		public IApiResponse setOptionPromptInAttackMode(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptInAttackMode", parameters);
		}

		public IApiResponse setOptionPromptToClearFinishedScans(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptToClearFinishedScans", parameters);
		}

		public IApiResponse setOptionRescanInAttackMode(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionRescanInAttackMode", parameters);
		}

		/// <summary>
		///Sets whether or not the HTTP Headers of all requests should be scanned. Not just requests that send parameters, through the query or request body.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionScanHeadersAllRequests(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionScanHeadersAllRequests", parameters);
		}

		public IApiResponse setOptionShowAdvancedDialog(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionShowAdvancedDialog", parameters);
		}

		public IApiResponse setOptionTargetParamsEnabledRPC(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsEnabledRPC", parameters);
		}

		public IApiResponse setOptionTargetParamsInjectable(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsInjectable", parameters);
		}

		public IApiResponse setOptionThreadPerHost(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionThreadPerHost", parameters);
		}

	}
}
