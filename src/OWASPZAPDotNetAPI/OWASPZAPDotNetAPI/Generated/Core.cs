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
	public class Core 
	{
		private ClientApi api = null;

		public Core(ClientApi api) 
		{
			this.api = api;
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
		///Gets the child nodes underneath the specified URL in the Sites tree
		/// </summary>
		/// <returns></returns>
		public IApiResponse childNodes(string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			return api.CallApi("core", "view", "childNodes", parameters);
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
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse proxyChainExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "proxyChainExcludedDomains", parameters);
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
		///
		/// [Obsolete]
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse homeDirectory()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "homeDirectory", parameters);
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
		///Gets the alert with the given ID, the corresponding HTTP message can be obtained with the 'messageId' field and 'message' API method
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
		public IApiResponse alert(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("core", "view", "alert", parameters);
		}

		/// <summary>
		///Gets the alerts raised by ZAP, optionally filtering by URL or riskId, and paginating with 'start' position and 'count' of alerts
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
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
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
		public IApiResponse alertsSummary(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return api.CallApi("core", "view", "alertsSummary", parameters);
		}

		/// <summary>
		///Gets the number of alerts, optionally filtering by URL or riskId
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
		public IApiResponse numberOfAlerts(string baseurl, string riskid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("riskId", riskid);
			return api.CallApi("core", "view", "numberOfAlerts", parameters);
		}

		/// <summary>
		///Gets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionDefaultUserAgent()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionDefaultUserAgent", parameters);
		}

		/// <summary>
		///Gets the TTL (in seconds) of successful DNS queries.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionDnsTtlSuccessfulQueries()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionDnsTtlSuccessfulQueries", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionHttpState()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionHttpState", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionHttpStateEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionHttpStateEnabled", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainName()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainName", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainPassword()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPassword", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainPort()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPort", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainPrompt()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainPrompt", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainRealm()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainRealm", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionProxyChainUserName()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionProxyChainUserName", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Option no longer in effective use.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Option no longer in effective use.")]
		public IApiResponse optionSingleCookieRequestHeader()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionSingleCookieRequestHeader", parameters);
		}

		/// <summary>
		///Gets the connection time out (in seconds).
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionTimeoutInSecs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionTimeoutInSecs", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionUseProxyChain()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionUseProxyChain", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionUseProxyChainAuth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionUseProxyChainAuth", parameters);
		}

		/// <summary>
		///Gets whether or not the SOCKS proxy should be used.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse optionUseSocksProxy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "view", "optionUseSocksProxy", parameters);
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
		///Saves the session.
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

		/// <summary>
		///Snapshots the session, optionally with the given name, and overwriting existing files. If no name is specified the name of the current session with a timestamp appended is used. If a relative path is specified it will be resolved against the "session" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse snapshotSession(string name, string overwrite)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("overwrite", overwrite);
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

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
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
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
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
		///
		/// </summary>
		/// <returns></returns>
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
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
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
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
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
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse removeProxyChainExcludedDomain(string idx)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("idx", idx);
			return api.CallApi("core", "action", "removeProxyChainExcludedDomain", parameters);
		}

		/// <summary>
		///Enables all domains excluded from the outgoing proxy.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse enableAllProxyChainExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "enableAllProxyChainExcludedDomains", parameters);
		}

		/// <summary>
		///Disables all domains excluded from the outgoing proxy.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
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
		///Enables use of a PKCS12 client certificate for the certificate with the given file system path, password, and optional index.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse enablePKCS12ClientCertificate(string filepath, string password, string index)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			parameters.Add("password", password);
			parameters.Add("index", index);
			return api.CallApi("core", "action", "enablePKCS12ClientCertificate", parameters);
		}

		/// <summary>
		///Disables the option for use of client certificates.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse disableClientCertificate()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "disableClientCertificate", parameters);
		}

		/// <summary>
		///Deletes all alerts of the current session.
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
		public IApiResponse deleteAllAlerts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("core", "action", "deleteAllAlerts", parameters);
		}

		/// <summary>
		///Deletes the alert with the given ID. 
		/// [Obsolete] Use the API endpoint with the same name in the 'alert' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoint with the same name in the 'alert' component instead.")]
		public IApiResponse deleteAlert(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("core", "action", "deleteAlert", parameters);
		}

		/// <summary>
		///Sets the user agent that ZAP should use when creating HTTP messages (for example, spider messages or CONNECT requests to outgoing proxy).
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionDefaultUserAgent(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionDefaultUserAgent", parameters);
		}

		/// <summary>
		///Sets the TTL (in seconds) of successful DNS queries (applies after ZAP restart).
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionDnsTtlSuccessfulQueries(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionDnsTtlSuccessfulQueries", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionHttpStateEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionHttpStateEnabled", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainName", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainPassword(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainPassword", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainPort(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionProxyChainPort", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainPrompt(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionProxyChainPrompt", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainRealm(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainRealm", parameters);
		}

		/// <summary>
		///Use actions [add|modify|remove]ProxyChainExcludedDomain instead.
		/// [Obsolete] Option no longer in effective use.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Option no longer in effective use.")]
		public IApiResponse setOptionProxyChainSkipName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainSkipName", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionProxyChainUserName(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("core", "action", "setOptionProxyChainUserName", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Option no longer in effective use.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Option no longer in effective use.")]
		public IApiResponse setOptionSingleCookieRequestHeader(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionSingleCookieRequestHeader", parameters);
		}

		/// <summary>
		///Sets the connection time out (in seconds).
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionTimeoutInSecs(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("core", "action", "setOptionTimeoutInSecs", parameters);
		}

		/// <summary>
		///Sets whether or not the outgoing proxy should be used. The address/hostname of the outgoing proxy must be set to enable this option.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionUseProxyChain(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionUseProxyChain", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionUseProxyChainAuth(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionUseProxyChainAuth", parameters);
		}

		/// <summary>
		///Sets whether or not the SOCKS proxy should be used.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public IApiResponse setOptionUseSocksProxy(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("core", "action", "setOptionUseSocksProxy", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public byte[] proxypac()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "proxy.pac", parameters);
		}

		/// <summary>
		///Gets the Root CA certificate used by the local proxies.
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public byte[] rootcert()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "rootcert", parameters);
		}

		/// <summary>
		///
		/// [Obsolete] Use the API endpoints in the 'network' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'network' component instead.")]
		public byte[] setproxy(string proxy)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("proxy", proxy);
			return api.CallApiOther("core", "other", "setproxy", parameters);
		}

		/// <summary>
		///Generates a report in XML format
		/// [Obsolete] Use the 'generate' API endpoint the 'reports' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the 'generate' API endpoint the 'reports' component instead.")]
		public byte[] xmlreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "xmlreport", parameters);
		}

		/// <summary>
		///Generates a report in HTML format
		/// [Obsolete] Use the 'generate' API endpoint the 'reports' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the 'generate' API endpoint the 'reports' component instead.")]
		public byte[] htmlreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "htmlreport", parameters);
		}

		/// <summary>
		///Generates a report in JSON format
		/// [Obsolete] Use the 'generate' API endpoint the 'reports' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the 'generate' API endpoint the 'reports' component instead.")]
		public byte[] jsonreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "jsonreport", parameters);
		}

		/// <summary>
		///Generates a report in Markdown format
		/// [Obsolete] Use the 'generate' API endpoint the 'reports' component instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the 'generate' API endpoint the 'reports' component instead.")]
		public byte[] mdreport()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("core", "other", "mdreport", parameters);
		}

		/// <summary>
		///Gets the message with the given ID in HAR format
		/// [Obsolete] Use the API endpoints in the 'exim' add-on instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'exim' add-on instead.")]
		public byte[] messageHar(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApiOther("core", "other", "messageHar", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent through/by ZAP, in HAR format, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		/// [Obsolete] Use the API endpoints in the 'exim' add-on instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'exim' add-on instead.")]
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
		/// [Obsolete] Use the API endpoints in the 'exim' add-on instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'exim' add-on instead.")]
		public byte[] messagesHarById(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApiOther("core", "other", "messagesHarById", parameters);
		}

		/// <summary>
		///Sends the first HAR request entry, optionally following redirections. Returns, in HAR format, the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
		/// [Obsolete] Use the API endpoints in the 'exim' add-on instead.
		/// </summary>
		/// <returns></returns>
		[Obsolete("Use the API endpoints in the 'exim' add-on instead.")]
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
