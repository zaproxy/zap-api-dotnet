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
	public class Core 
	{
		private IClientApi api = null;

		public Core(IClientApi api) 
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
			return api.CallApi("core", "view", "alert", parameters);
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
			return api.CallApi("core", "view", "alerts", parameters);
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
			return api.CallApi("core", "view", "alertsSummary", parameters);
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
			return api.CallApi("core", "view", "numberOfAlerts", parameters);
		}

		/// <summary>
		///Gets the name of the hosts accessed through/by ZAP
		/// </summary>
		/// <returns></returns>
		public IApiResponse hosts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "hosts", parameters);
		}

		/// <summary>
		///Gets the sites accessed through/by ZAP (scheme and domain)
		/// </summary>
		/// <returns></returns>
		public IApiResponse sites()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "sites", parameters);
		}

		/// <summary>
		///Gets the URLs accessed through/by ZAP, optionally filtering by (base) URL.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urls(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return api.CallApi("core", "view", "urls", parameters);
		}

		/// <summary>
		///Gets the HTTP message with the given ID. Returns the ID, request/response headers and bodies, cookies, note, type, RTT, and timestamp.
		/// </summary>
		/// <returns></returns>
		public IApiResponse message(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("core", "view", "message", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent by ZAP, request and response, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		/// </summary>
		/// <returns></returns>
		public IApiResponse messages(string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("core", "view", "messages", parameters);
		}

		/// <summary>
		///Gets the HTTP messages with the given IDs.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesById(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApi("core", "view", "messagesById", parameters);
		}

		/// <summary>
		///Gets the number of messages, optionally filtering by URL
		/// </summary>
		/// <returns></returns>
		public IApiResponse numberOfMessages(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return api.CallApi("core", "view", "numberOfMessages", parameters);
		}

		/// <summary>
		///Gets the mode
		/// </summary>
		/// <returns></returns>
		public IApiResponse mode()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "mode", parameters);
		}

		/// <summary>
		///Gets ZAP version
		/// </summary>
		/// <returns></returns>
		public IApiResponse version()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "version", parameters);
		}

		/// <summary>
		///Gets the regular expressions, applied to URLs, to exclude from the local proxies.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedFromProxy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "excludedFromProxy", parameters);
		}

		public IApiResponse homeDirectory()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "homeDirectory", parameters);
		}

		/// <summary>
		///Gets the location of the current session file
		/// </summary>
		/// <returns></returns>
		public IApiResponse sessionLocation()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "sessionLocation", parameters);
		}

		/// <summary>
		///Gets all the domains that are excluded from the outgoing proxy. For each domain the following are shown: the index, the value (domain), if enabled, and if specified as a regex.
		/// </summary>
		/// <returns></returns>
		public IApiResponse proxyChainExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "proxyChainExcludedDomains", parameters);
		}

		/// <summary>
		///Use view proxyChainExcludedDomains instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionProxyChainSkipName()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainSkipName", parameters);
		}

		/// <summary>
		///Use view proxyChainExcludedDomains instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionProxyExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyExcludedDomains", parameters);
		}

		/// <summary>
		///Use view proxyChainExcludedDomains instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionProxyExcludedDomainsEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyExcludedDomainsEnabled", parameters);
		}

		/// <summary>
		///Gets the path to ZAP's home directory.
		/// </summary>
		/// <returns></returns>
		public IApiResponse zapHomePath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "zapHomePath", parameters);
		}

		/// <summary>
		///Gets the maximum number of alert instances to include in a report.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaximumAlertInstances()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionMaximumAlertInstances", parameters);
		}

		/// <summary>
		///Gets whether or not related alerts will be merged in any reports generated.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMergeRelatedAlerts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionMergeRelatedAlerts", parameters);
		}

		/// <summary>
		///Gets the path to the file with alert overrides.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionAlertOverridesFilePath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionAlertOverridesFilePath", parameters);
		}

		/// <summary>
		///Gets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDefaultUserAgent()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionDefaultUserAgent", parameters);
		}

		/// <summary>
		///Gets the TTL (in seconds) of successful DNS queries.
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDnsTtlSuccessfulQueries()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionDnsTtlSuccessfulQueries", parameters);
		}

		public IApiResponse optionHttpState()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionHttpState", parameters);
		}

		public IApiResponse optionProxyChainName()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainName", parameters);
		}

		public IApiResponse optionProxyChainPassword()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPassword", parameters);
		}

		public IApiResponse optionProxyChainPort()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPort", parameters);
		}

		public IApiResponse optionProxyChainRealm()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainRealm", parameters);
		}

		public IApiResponse optionProxyChainUserName()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainUserName", parameters);
		}

		public IApiResponse optionTimeoutInSecs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionTimeoutInSecs", parameters);
		}

		public IApiResponse optionHttpStateEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionHttpStateEnabled", parameters);
		}

		public IApiResponse optionProxyChainPrompt()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPrompt", parameters);
		}

		public IApiResponse optionSingleCookieRequestHeader()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionSingleCookieRequestHeader", parameters);
		}

		public IApiResponse optionUseProxyChain()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionUseProxyChain", parameters);
		}

		public IApiResponse optionUseProxyChainAuth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionUseProxyChainAuth", parameters);
		}

		/// <summary>
		///Convenient and simple action to access a URL, optionally following redirections. Returns the request sent and response received and followed redirections, if any. Other actions are available which offer more control on what is sent, like, 'sendRequest' or 'sendHarRequest'.
		/// </summary>
		/// <returns></returns>
		public IApiResponse accessUrl(string url, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("followRedirects", followredirects);
			return api.CallApi("core", "action", "accessUrl", parameters);
		}

		/// <summary>
		///Shuts down ZAP
		/// </summary>
		/// <returns></returns>
		public IApiResponse shutdown()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "shutdown", parameters);
		}

		/// <summary>
		///Creates a new session, optionally overwriting existing files. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse newSession(string name, string overwrite)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("overwrite", overwrite);
			return api.CallApi("core", "action", "newSession", parameters);
		}

		/// <summary>
		///Loads the session with the given name. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse loadSession(string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			return api.CallApi("core", "action", "loadSession", parameters);
		}

		/// <summary>
		///Saves the session with the name supplied, optionally overwriting existing files. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse saveSession(string name, string overwrite)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("overwrite", overwrite);
			return api.CallApi("core", "action", "saveSession", parameters);
		}

		public IApiResponse snapshotSession()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "snapshotSession", parameters);
		}

		/// <summary>
		///Clears the regexes of URLs excluded from the local proxies.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearExcludedFromProxy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "clearExcludedFromProxy", parameters);
		}

		/// <summary>
		///Adds a regex of URLs that should be excluded from the local proxies.
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeFromProxy(string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			return api.CallApi("core", "action", "excludeFromProxy", parameters);
		}

		public IApiResponse setHomeDirectory(string dir)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("dir", dir);
			return api.CallApi("core", "action", "setHomeDirectory", parameters);
		}

		/// <summary>
		///Sets the mode, which may be one of [safe, protect, standard, attack]
		/// </summary>
		/// <returns></returns>
		public IApiResponse setMode(string mode)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("mode", mode);
			return api.CallApi("core", "action", "setMode", parameters);
		}

		/// <summary>
		///Generates a new Root CA certificate for the local proxies.
		/// </summary>
		/// <returns></returns>
		public IApiResponse generateRootCA()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "generateRootCA", parameters);
		}

		/// <summary>
		///Sends the HTTP request, optionally following redirections. Returns the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
		/// </summary>
		/// <returns></returns>
		public IApiResponse sendRequest(string request, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("request", request);
			parameters.Add("followRedirects", followredirects);
			return api.CallApi("core", "action", "sendRequest", parameters);
		}

		/// <summary>
		///Deletes all alerts of the current session.
		/// </summary>
		/// <returns></returns>
		public IApiResponse deleteAllAlerts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "deleteAllAlerts", parameters);
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
			return api.CallApi("core", "action", "deleteAlert", parameters);
		}

		public IApiResponse runGarbageCollection()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "runGarbageCollection", parameters);
		}

		/// <summary>
		///Deletes the site node found in the Sites Tree on the basis of the URL, HTTP method, and post data (if applicable and specified). 
		/// </summary>
		/// <returns></returns>
		public IApiResponse deleteSiteNode(string url, string method, string postdata)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("method", method);
			parameters.Add("postData", postdata);
			return api.CallApi("core", "action", "deleteSiteNode", parameters);
		}

		/// <summary>
		///Adds a domain to be excluded from the outgoing proxy, using the specified value. Optionally sets if the new entry is enabled (default, true) and whether or not the new value is specified as a regex (default, false).
		/// </summary>
		/// <returns></returns>
		public IApiResponse addProxyChainExcludedDomain(string value, string isregex, string isenabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("value", value);
			parameters.Add("isRegex", isregex);
			parameters.Add("isEnabled", isenabled);
			return api.CallApi("core", "action", "addProxyChainExcludedDomain", parameters);
		}

		/// <summary>
		///Modifies a domain excluded from the outgoing proxy. Allows to modify the value, if enabled or if a regex. The domain is selected with its index, which can be obtained with the view proxyChainExcludedDomains.
		/// </summary>
		/// <returns></returns>
		public IApiResponse modifyProxyChainExcludedDomain(string idx, string value, string isregex, string isenabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			parameters.Add("value", value);
			parameters.Add("isRegex", isregex);
			parameters.Add("isEnabled", isenabled);
			return api.CallApi("core", "action", "modifyProxyChainExcludedDomain", parameters);
		}

		/// <summary>
		///Removes a domain excluded from the outgoing proxy, with the given index. The index can be obtained with the view proxyChainExcludedDomains.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeProxyChainExcludedDomain(string idx)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			return api.CallApi("core", "action", "removeProxyChainExcludedDomain", parameters);
		}

		/// <summary>
		///Enables all domains excluded from the outgoing proxy.
		/// </summary>
		/// <returns></returns>
		public IApiResponse enableAllProxyChainExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "enableAllProxyChainExcludedDomains", parameters);
		}

		/// <summary>
		///Disables all domains excluded from the outgoing proxy.
		/// </summary>
		/// <returns></returns>
		public IApiResponse disableAllProxyChainExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "disableAllProxyChainExcludedDomains", parameters);
		}

		/// <summary>
		///Sets the maximum number of alert instances to include in a report. A value of zero is treated as unlimited.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaximumAlertInstances(string numberofinstances)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("numberOfInstances", numberofinstances);
			return api.CallApi("core", "action", "setOptionMaximumAlertInstances", parameters);
		}

		/// <summary>
		///Sets whether or not related alerts will be merged in any reports generated.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMergeRelatedAlerts(string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("enabled", enabled);
			return api.CallApi("core", "action", "setOptionMergeRelatedAlerts", parameters);
		}

		/// <summary>
		///Sets (or clears, if empty) the path to the file with alert overrides.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionAlertOverridesFilePath(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("core", "action", "setOptionAlertOverridesFilePath", parameters);
		}

		/// <summary>
		///Sets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionDefaultUserAgent(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionDefaultUserAgent", parameters);
		}

		public IApiResponse setOptionProxyChainName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainName", parameters);
		}

		public IApiResponse setOptionProxyChainPassword(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainPassword", parameters);
		}

		public IApiResponse setOptionProxyChainRealm(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainRealm", parameters);
		}

		/// <summary>
		///Use actions [add|modify|remove]ProxyChainExcludedDomain instead.
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse setOptionProxyChainSkipName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainSkipName", parameters);
		}

		public IApiResponse setOptionProxyChainUserName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainUserName", parameters);
		}

		/// <summary>
		///Sets the TTL (in seconds) of successful DNS queries (applies after ZAP restart).
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionDnsTtlSuccessfulQueries(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionDnsTtlSuccessfulQueries", parameters);
		}

		public IApiResponse setOptionHttpStateEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionHttpStateEnabled", parameters);
		}

		public IApiResponse setOptionProxyChainPort(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionProxyChainPort", parameters);
		}

		public IApiResponse setOptionProxyChainPrompt(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionProxyChainPrompt", parameters);
		}

		public IApiResponse setOptionSingleCookieRequestHeader(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionSingleCookieRequestHeader", parameters);
		}

		public IApiResponse setOptionTimeoutInSecs(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionTimeoutInSecs", parameters);
		}

		/// <summary>
		///Sets whether or not the outgoing proxy should be used. The address/hostname of the outgoing proxy must be set to enable this option.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionUseProxyChain(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionUseProxyChain", parameters);
		}

		public IApiResponse setOptionUseProxyChainAuth(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionUseProxyChainAuth", parameters);
		}

		public byte[] proxypac()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "proxy.pac", parameters);
		}

		/// <summary>
		///Gets the Root CA certificate used by the local proxies.
		/// </summary>
		/// <returns></returns>
		public byte[] rootcert()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "rootcert", parameters);
		}

		public byte[] setproxy(string proxy)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("proxy", proxy);
			return api.CallApiOther("core", "other", "setproxy", parameters);
		}

		/// <summary>
		///Generates a report in XML format
		/// </summary>
		/// <returns></returns>
		public byte[] xmlreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "xmlreport", parameters);
		}

		/// <summary>
		///Generates a report in HTML format
		/// </summary>
		/// <returns></returns>
		public byte[] htmlreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "htmlreport", parameters);
		}

		/// <summary>
		///Generates a report in JSON format
		/// </summary>
		/// <returns></returns>
		public byte[] jsonreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "jsonreport", parameters);
		}

		/// <summary>
		///Generates a report in Markdown format
		/// </summary>
		/// <returns></returns>
		public byte[] mdreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "mdreport", parameters);
		}

		/// <summary>
		///Gets the message with the given ID in HAR format
		/// </summary>
		/// <returns></returns>
		public byte[] messageHar(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApiOther("core", "other", "messageHar", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent through/by ZAP, in HAR format, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		/// </summary>
		/// <returns></returns>
		public byte[] messagesHar(string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("core", "other", "messagesHar", parameters);
		}

		/// <summary>
		///Gets the HTTP messages with the given IDs, in HAR format.
		/// </summary>
		/// <returns></returns>
		public byte[] messagesHarById(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApiOther("core", "other", "messagesHarById", parameters);
		}

		/// <summary>
		///Sends the first HAR request entry, optionally following redirections. Returns, in HAR format, the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
		/// </summary>
		/// <returns></returns>
		public byte[] sendHarRequest(string request, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("request", request);
			parameters.Add("followRedirects", followredirects);
			return api.CallApiOther("core", "other", "sendHarRequest", parameters);
		}

	}
}
