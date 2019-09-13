/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2019 the ZAP development team
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse status(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "view", "status", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse scans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "scans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///Gets the scanners, optionally, of the given scan policy and/or scanner policy/category ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanners(string scanpolicyname, string policyid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("policyId", policyid);
			return api.CallApi("ascan", "view", "scanners", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse policies(string scanpolicyname, string policyid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("policyId", policyid);
			return api.CallApi("ascan", "view", "policies", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionAttackPolicy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionAttackPolicy", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDefaultPolicy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionDefaultPolicy", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDelayInMs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionDelayInMs", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionHandleAntiCSRFTokens()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionHandleAntiCSRFTokens", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionHostPerScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionHostPerScan", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxChartTimeInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxChartTimeInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxResultsToList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxResultsToList", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxRuleDurationInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxRuleDurationInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxScanDurationInMins()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxScanDurationInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxScansInUI()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionMaxScansInUI", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionTargetParamsEnabledRPC()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionTargetParamsEnabledRPC", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionTargetParamsInjectable()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionTargetParamsInjectable", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionThreadPerHost()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionThreadPerHost", parameters);
		}

		/// <summary>
		///Tells whether or not the active scanner should add a query parameter to GET request that don't have parameters to start with.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionAddQueryParam()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionAddQueryParam", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionPromptInAttackMode()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionPromptInAttackMode", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionPromptToClearFinishedScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "view", "optionPromptToClearFinishedScans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse pause(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "pause", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse resume(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "resume", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse stop(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "stop", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeScan(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("ascan", "action", "removeScan", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse pauseAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "pauseAllScans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse resumeAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "resumeAllScans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse stopAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ascan", "action", "stopAllScans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///Enables all scanners of the scan policy with the given name, or the default if none given.
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableAllScanners(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableAllScanners", parameters);
		}

		/// <summary>
		///Disables all scanners of the scan policy with the given name, or the default if none given.
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableAllScanners(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableAllScanners", parameters);
		}

		/// <summary>
		///Enables the scanners with the given IDs (comma separated list of IDs) of the scan policy with the given name, or the default if none given.
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableScanners(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "enableScanners", parameters);
		}

		/// <summary>
		///Disables the scanners with the given IDs (comma separated list of IDs) of the scan policy with the given name, or the default if none given.
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableScanners(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "disableScanners", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setEnabledPolicies(string ids, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setEnabledPolicies", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setPolicyAttackStrength(string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAttackStrength", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setPolicyAlertThreshold(string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setPolicyAlertThreshold", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setScannerAttackStrength(string id, string attackstrength, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("attackStrength", attackstrength);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAttackStrength", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setScannerAlertThreshold(string id, string alertthreshold, string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "setScannerAlertThreshold", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse addScanPolicy(string scanpolicyname, string alertthreshold, string attackstrength)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			parameters.Add("alertThreshold", alertthreshold);
			parameters.Add("attackStrength", attackstrength);
			return api.CallApi("ascan", "action", "addScanPolicy", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeScanPolicy(string scanpolicyname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanPolicyName", scanpolicyname);
			return api.CallApi("ascan", "action", "removeScanPolicy", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionAttackPolicy(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionAttackPolicy", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionDefaultPolicy(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("ascan", "action", "setOptionDefaultPolicy", parameters);
		}

		/// <summary>
		///Sets whether or not the active scanner should add a query param to GET requests which do not have parameters to start with.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionAddQueryParam(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionAddQueryParam", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionAllowAttackOnStart(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionAllowAttackOnStart", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionDelayInMs(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionDelayInMs", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionHandleAntiCSRFTokens(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionHandleAntiCSRFTokens", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxChartTimeInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxChartTimeInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxResultsToList(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxResultsToList", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxRuleDurationInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxRuleDurationInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxScanDurationInMins(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScanDurationInMins", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxScansInUI(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionMaxScansInUI", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionPromptInAttackMode(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptInAttackMode", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionPromptToClearFinishedScans(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionPromptToClearFinishedScans", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionShowAdvancedDialog(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ascan", "action", "setOptionShowAdvancedDialog", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionTargetParamsEnabledRPC(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsEnabledRPC", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionTargetParamsInjectable(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionTargetParamsInjectable", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionThreadPerHost(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ascan", "action", "setOptionThreadPerHost", parameters);
		}

	}
}
