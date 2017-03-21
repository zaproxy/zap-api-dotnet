/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright the ZAP development team
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

		public IApiResponse messagesIds(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "messagesIds", parameters);
		}

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
		/// </summary>
		/// <returns></returns>
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
		public IApiResponse scan(string apikey, string url, string recurse, string inscopeonly, string scanpolicyname, string method, string postdata, string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
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
		public IApiResponse scanAsUser(string apikey, string url, string contextid, string userid, string recurse, string scanpolicyname, string method, string postdata)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("url", url);
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("recurse", recurse);
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("method", method);
			parameters.Add("postData", postdata);
			return api.CallApi("ascan", "action", "scanAsUser", parameters);
		}

		public IApiResponse pause(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "pause", parameters);
		}

		public IApiResponse resume(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "resume", parameters);
		}

		public IApiResponse stop(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "stop", parameters);
		}

		public IApiResponse removeScan(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "removeScan", parameters);
		}

		public IApiResponse pauseAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return api.CallApi("ascan", "action", "pauseAllScans", parameters);
		}

		public IApiResponse resumeAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return api.CallApi("ascan", "action", "resumeAllScans", parameters);
		}

		public IApiResponse stopAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return api.CallApi("ascan", "action", "stopAllScans", parameters);
		}

		public IApiResponse removeAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return api.CallApi("ascan", "action", "removeAllScans", parameters);
		}

		/// <summary>
		///Clears the regexes of URLs excluded from the active scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearExcludedFromScan(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return api.CallApi("ascan", "action", "clearExcludedFromScan", parameters);
		}

		/// <summary>
		///Adds a regex of URLs that should be excluded from the active scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeFromScan(string apikey, string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("regex", regex);
			return api.CallApi("ascan", "action", "excludeFromScan", parameters);
		}

		public IApiResponse enableAllScanners(string apikey, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableAllScanners", parameters);
		}

		public IApiResponse disableAllScanners(string apikey, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableAllScanners", parameters);
		}

		public IApiResponse enableScanners(string apikey, string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableScanners", parameters);
		}

		public IApiResponse disableScanners(string apikey, string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableScanners", parameters);
		}

		public IApiResponse setEnabledPolicies(string apikey, string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setEnabledPolicies", parameters);
		}

		public IApiResponse setPolicyAttackStrength(string apikey, string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAttackStrength", parameters);
		}

		public IApiResponse setPolicyAlertThreshold(string apikey, string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAlertThreshold", parameters);
		}

		public IApiResponse setScannerAttackStrength(string apikey, string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAttackStrength", parameters);
		}

		public IApiResponse setScannerAlertThreshold(string apikey, string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAlertThreshold", parameters);
		}

		public IApiResponse addScanPolicy(string apikey, string scanpolicyname, string alertthreshold, string attackstrength)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("attackStrength", attackstrength);
			return api.CallApi("ascan", "action", "addScanPolicy", parameters);
		}

		public IApiResponse removeScanPolicy(string apikey, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "removeScanPolicy", parameters);
		}

		public IApiResponse updateScanPolicy(string apikey, string scanpolicyname, string alertthreshold, string attackstrength)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("attackStrength", attackstrength);
			return api.CallApi("ascan", "action", "updateScanPolicy", parameters);
		}

		/// <summary>
		///Adds a new parameter excluded from the scan, using the specified name. Optionally sets if the new entry applies to a specific URL (default, all URLs) and sets the ID of the type of the parameter (default, ID of any type). The type IDs can be obtained with the view excludedParamTypes. 
		/// </summary>
		/// <returns></returns>
		public IApiResponse addExcludedParam(string apikey, string name, string type, string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("name", name);
			parameters.Add("type", type);
			parameters.Add("url", url);
			return api.CallApi("ascan", "action", "addExcludedParam", parameters);
		}

		/// <summary>
		///Modifies a parameter excluded from the scan. Allows to modify the name, the URL and the type of parameter. The parameter is selected with its index, which can be obtained with the view excludedParams.
		/// </summary>
		/// <returns></returns>
		public IApiResponse modifyExcludedParam(string apikey, string idx, string name, string type, string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
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
		public IApiResponse removeExcludedParam(string apikey, string idx)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("idx", idx);
			return api.CallApi("ascan", "action", "removeExcludedParam", parameters);
		}

		public IApiResponse setOptionAttackPolicy(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionAttackPolicy", parameters);
		}

		public IApiResponse setOptionDefaultPolicy(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionDefaultPolicy", parameters);
		}

		public IApiResponse setOptionAllowAttackOnStart(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionAllowAttackOnStart", parameters);
		}

		public IApiResponse setOptionDelayInMs(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionDelayInMs", parameters);
		}

		public IApiResponse setOptionHandleAntiCSRFTokens(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionHandleAntiCSRFTokens", parameters);
		}

		public IApiResponse setOptionHostPerScan(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionHostPerScan", parameters);
		}

		/// <summary>
		///Sets whether or not the active scanner should inject the HTTP request header X-ZAP-Scan-ID, with the ID of the scanner that's sending the requests.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionInjectPluginIdInHeader(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionInjectPluginIdInHeader", parameters);
		}

		public IApiResponse setOptionMaxChartTimeInMins(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxChartTimeInMins", parameters);
		}

		public IApiResponse setOptionMaxResultsToList(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxResultsToList", parameters);
		}

		public IApiResponse setOptionMaxRuleDurationInMins(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxRuleDurationInMins", parameters);
		}

		public IApiResponse setOptionMaxScanDurationInMins(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScanDurationInMins", parameters);
		}

		public IApiResponse setOptionMaxScansInUI(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScansInUI", parameters);
		}

		public IApiResponse setOptionPromptInAttackMode(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptInAttackMode", parameters);
		}

		public IApiResponse setOptionPromptToClearFinishedScans(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptToClearFinishedScans", parameters);
		}

		public IApiResponse setOptionRescanInAttackMode(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionRescanInAttackMode", parameters);
		}

		/// <summary>
		///Sets whether or not the HTTP Headers of all requests should be scanned. Not just requests that send parameters, through the query or request body.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionScanHeadersAllRequests(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionScanHeadersAllRequests", parameters);
		}

		public IApiResponse setOptionShowAdvancedDialog(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionShowAdvancedDialog", parameters);
		}

		public IApiResponse setOptionTargetParamsEnabledRPC(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsEnabledRPC", parameters);
		}

		public IApiResponse setOptionTargetParamsInjectable(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsInjectable", parameters);
		}

		public IApiResponse setOptionThreadPerHost(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionThreadPerHost", parameters);
		}

	}
}
