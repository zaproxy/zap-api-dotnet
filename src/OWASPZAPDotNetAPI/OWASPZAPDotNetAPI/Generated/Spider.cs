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
	public class Spider 
	{
		private ClientApi api = null;

		public Spider(ClientApi api) 
		{
			this.api = api;
		}

		public IApiResponse status(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "view", "status", parameters);
		}

		public IApiResponse results(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "view", "results", parameters);
		}

		public IApiResponse fullResults(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "view", "fullResults", parameters);
		}

		public IApiResponse scans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "scans", parameters);
		}

		/// <summary>
		///Gets the regexes of URLs excluded from the spider scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedFromScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "excludedFromScan", parameters);
		}

		/// <summary>
		///Returns a list of unique URLs from the history table based on HTTP messages added by the Spider.
		/// </summary>
		/// <returns></returns>
		public IApiResponse allUrls()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "allUrls", parameters);
		}

		/// <summary>
		///Returns a list of the names of the nodes added to the Sites tree by the specified scan.
		/// </summary>
		/// <returns></returns>
		public IApiResponse addedNodes(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "view", "addedNodes", parameters);
		}

		/// <summary>
		///Gets all the domains that are always in scope. For each domain the following are shown: the index, the value (domain), if enabled, and if specified as a regex.
		/// </summary>
		/// <returns></returns>
		public IApiResponse domainsAlwaysInScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "domainsAlwaysInScope", parameters);
		}

		/// <summary>
		///Use view domainsAlwaysInScope instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionDomainsAlwaysInScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionDomainsAlwaysInScope", parameters);
		}

		/// <summary>
		///Use view domainsAlwaysInScope instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionDomainsAlwaysInScopeEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionDomainsAlwaysInScopeEnabled", parameters);
		}

		public IApiResponse optionHandleParameters()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionHandleParameters", parameters);
		}

		/// <summary>
		///Gets the maximum number of child nodes (per node) that can be crawled, 0 means no limit.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxChildren()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionMaxChildren", parameters);
		}

		public IApiResponse optionMaxDepth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionMaxDepth", parameters);
		}

		public IApiResponse optionMaxDuration()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionMaxDuration", parameters);
		}

		/// <summary>
		///Gets the maximum size, in bytes, that a response might have to be parsed.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxParseSizeBytes()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionMaxParseSizeBytes", parameters);
		}

		public IApiResponse optionMaxScansInUI()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionMaxScansInUI", parameters);
		}

		public IApiResponse optionRequestWaitTime()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionRequestWaitTime", parameters);
		}

		[Obsolete]
		public IApiResponse optionScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionScope", parameters);
		}

		[Obsolete]
		public IApiResponse optionScopeText()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionScopeText", parameters);
		}

		public IApiResponse optionSkipURLString()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionSkipURLString", parameters);
		}

		public IApiResponse optionThreadCount()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionThreadCount", parameters);
		}

		public IApiResponse optionUserAgent()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionUserAgent", parameters);
		}

		/// <summary>
		///Gets whether or not a spider process should accept cookies while spidering.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionAcceptCookies()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionAcceptCookies", parameters);
		}

		public IApiResponse optionHandleODataParametersVisited()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionHandleODataParametersVisited", parameters);
		}

		public IApiResponse optionParseComments()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionParseComments", parameters);
		}

		public IApiResponse optionParseGit()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionParseGit", parameters);
		}

		public IApiResponse optionParseRobotsTxt()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionParseRobotsTxt", parameters);
		}

		public IApiResponse optionParseSVNEntries()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionParseSVNEntries", parameters);
		}

		public IApiResponse optionParseSitemapXml()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionParseSitemapXml", parameters);
		}

		public IApiResponse optionPostForm()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionPostForm", parameters);
		}

		public IApiResponse optionProcessForm()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionProcessForm", parameters);
		}

		/// <summary>
		///Gets whether or not the 'Referer' header should be sent while spidering.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionSendRefererHeader()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionSendRefererHeader", parameters);
		}

		public IApiResponse optionShowAdvancedDialog()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "view", "optionShowAdvancedDialog", parameters);
		}

		/// <summary>
		///Runs the spider against the given URL (or context). Optionally, the 'maxChildren' parameter can be set to limit the number of children scanned, the 'recurse' parameter can be used to prevent the spider from seeding recursively, the parameter 'contextName' can be used to constrain the scan to a Context and the parameter 'subtreeOnly' allows to restrict the spider under a site's subtree (using the specified 'url').
		/// </summary>
		/// <returns></returns>
		public IApiResponse scan(string url, string maxchildren, string recurse, string contextname, string subtreeonly)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("maxChildren", maxchildren);
			parameters.Add("recurse", recurse);
			parameters.Add("contextName", contextname);
			parameters.Add("subtreeOnly", subtreeonly);
			return api.CallApi("spider", "action", "scan", parameters);
		}

		/// <summary>
		///Runs the spider from the perspective of a User, obtained using the given Context ID and User ID. See 'scan' action for more details.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanAsUser(string contextid, string userid, string url, string maxchildren, string recurse, string subtreeonly)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("url", url);
			parameters.Add("maxChildren", maxchildren);
			parameters.Add("recurse", recurse);
			parameters.Add("subtreeOnly", subtreeonly);
			return api.CallApi("spider", "action", "scanAsUser", parameters);
		}

		public IApiResponse pause(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "action", "pause", parameters);
		}

		public IApiResponse resume(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "action", "resume", parameters);
		}

		public IApiResponse stop(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "action", "stop", parameters);
		}

		public IApiResponse removeScan(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return api.CallApi("spider", "action", "removeScan", parameters);
		}

		public IApiResponse pauseAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "pauseAllScans", parameters);
		}

		public IApiResponse resumeAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "resumeAllScans", parameters);
		}

		public IApiResponse stopAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "stopAllScans", parameters);
		}

		public IApiResponse removeAllScans()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "removeAllScans", parameters);
		}

		/// <summary>
		///Clears the regexes of URLs excluded from the spider scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearExcludedFromScan()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "clearExcludedFromScan", parameters);
		}

		/// <summary>
		///Adds a regex of URLs that should be excluded from the spider scans.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeFromScan(string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			return api.CallApi("spider", "action", "excludeFromScan", parameters);
		}

		/// <summary>
		///Adds a new domain that's always in scope, using the specified value. Optionally sets if the new entry is enabled (default, true) and whether or not the new value is specified as a regex (default, false).
		/// </summary>
		/// <returns></returns>
		public IApiResponse addDomainAlwaysInScope(string value, string isregex, string isenabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("value", value);
			parameters.Add("isRegex", isregex);
			parameters.Add("isEnabled", isenabled);
			return api.CallApi("spider", "action", "addDomainAlwaysInScope", parameters);
		}

		/// <summary>
		///Modifies a domain that's always in scope. Allows to modify the value, if enabled or if a regex. The domain is selected with its index, which can be obtained with the view domainsAlwaysInScope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse modifyDomainAlwaysInScope(string idx, string value, string isregex, string isenabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			parameters.Add("value", value);
			parameters.Add("isRegex", isregex);
			parameters.Add("isEnabled", isenabled);
			return api.CallApi("spider", "action", "modifyDomainAlwaysInScope", parameters);
		}

		/// <summary>
		///Removes a domain that's always in scope, with the given index. The index can be obtained with the view domainsAlwaysInScope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeDomainAlwaysInScope(string idx)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			return api.CallApi("spider", "action", "removeDomainAlwaysInScope", parameters);
		}

		/// <summary>
		///Enables all domains that are always in scope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableAllDomainsAlwaysInScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "enableAllDomainsAlwaysInScope", parameters);
		}

		/// <summary>
		///Disables all domains that are always in scope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableAllDomainsAlwaysInScope()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("spider", "action", "disableAllDomainsAlwaysInScope", parameters);
		}

		public IApiResponse setOptionHandleParameters(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("spider", "action", "setOptionHandleParameters", parameters);
		}

		/// <summary>
		///Use actions [add|modify|remove]DomainAlwaysInScope instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse setOptionScopeString(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("spider", "action", "setOptionScopeString", parameters);
		}

		public IApiResponse setOptionSkipURLString(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("spider", "action", "setOptionSkipURLString", parameters);
		}

		public IApiResponse setOptionUserAgent(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("spider", "action", "setOptionUserAgent", parameters);
		}

		/// <summary>
		///Sets whether or not a spider process should accept cookies while spidering.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionAcceptCookies(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionAcceptCookies", parameters);
		}

		public IApiResponse setOptionHandleODataParametersVisited(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionHandleODataParametersVisited", parameters);
		}

		/// <summary>
		///Sets the maximum number of child nodes (per node) that can be crawled, 0 means no limit.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxChildren(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionMaxChildren", parameters);
		}

		public IApiResponse setOptionMaxDepth(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionMaxDepth", parameters);
		}

		public IApiResponse setOptionMaxDuration(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionMaxDuration", parameters);
		}

		/// <summary>
		///Sets the maximum size, in bytes, that a response might have to be parsed. This allows the spider to skip big responses/files.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxParseSizeBytes(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionMaxParseSizeBytes", parameters);
		}

		public IApiResponse setOptionMaxScansInUI(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionMaxScansInUI", parameters);
		}

		public IApiResponse setOptionParseComments(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionParseComments", parameters);
		}

		public IApiResponse setOptionParseGit(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionParseGit", parameters);
		}

		public IApiResponse setOptionParseRobotsTxt(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionParseRobotsTxt", parameters);
		}

		public IApiResponse setOptionParseSVNEntries(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionParseSVNEntries", parameters);
		}

		public IApiResponse setOptionParseSitemapXml(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionParseSitemapXml", parameters);
		}

		public IApiResponse setOptionPostForm(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionPostForm", parameters);
		}

		public IApiResponse setOptionProcessForm(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionProcessForm", parameters);
		}

		public IApiResponse setOptionRequestWaitTime(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionRequestWaitTime", parameters);
		}

		/// <summary>
		///Sets whether or not the 'Referer' header should be sent while spidering.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionSendRefererHeader(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionSendRefererHeader", parameters);
		}

		public IApiResponse setOptionShowAdvancedDialog(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("spider", "action", "setOptionShowAdvancedDialog", parameters);
		}

		public IApiResponse setOptionThreadCount(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("spider", "action", "setOptionThreadCount", parameters);
		}

	}
}
