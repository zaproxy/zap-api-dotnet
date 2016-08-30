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
using System.Threading.Tasks;


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
		///Gets the alert with the given ID, the corresponding HTTP message can be obtained with the 'messageId' field and 'message' API method
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> alert(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return await api.CallApi("core", "view", "alert", parameters);
		}

		/// <summary>
		///Gets the alerts raised by ZAP, optionally filtering by URL and paginating with 'start' position and 'count' of alerts
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> alerts(string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return await api.CallApi("core", "view", "alerts", parameters);
		}

		/// <summary>
		///Gets the number of alerts, optionally filtering by URL
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> numberOfAlerts(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return await api.CallApi("core", "view", "numberOfAlerts", parameters);
		}

		/// <summary>
		///Gets the name of the hosts accessed through/by ZAP
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> hosts()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "hosts", parameters);
		}

		/// <summary>
		///Gets the sites accessed through/by ZAP (scheme and domain)
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> sites()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "sites", parameters);
		}

		/// <summary>
		///Gets the URLs accessed through/by ZAP
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> urls()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "urls", parameters);
		}

		/// <summary>
		///Gets the HTTP message with the given ID. Returns the ID, request/response headers and bodies, cookies and note.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> message(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return await api.CallApi("core", "view", "message", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent by ZAP, request and response, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> messages(string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return await api.CallApi("core", "view", "messages", parameters);
		}

		/// <summary>
		///Gets the number of messages, optionally filtering by URL
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> numberOfMessages(string baseurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			return await api.CallApi("core", "view", "numberOfMessages", parameters);
		}

		/// <summary>
		///Gets ZAP version
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> version()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "version", parameters);
		}

		/// <summary>
		///Gets the regular expressions, applied to URLs, to exclude from the Proxy
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> excludedFromProxy()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "excludedFromProxy", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> homeDirectory()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "homeDirectory", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> stats(string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("keyPrefix", keyprefix);
			return await api.CallApi("core", "view", "stats", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionHttpState()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionHttpState", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionUseProxyChain()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionUseProxyChain", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionTimeoutInSecs()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionTimeoutInSecs", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainRealm()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainRealm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainPort()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainPort", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainName()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainSkipName()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainSkipName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainPassword()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainPassword", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainPrompt()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainPrompt", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyExcludedDomainsEnabled()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyExcludedDomainsEnabled", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyExcludedDomains()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyExcludedDomains", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionUseProxyChainAuth()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionUseProxyChainAuth", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionHttpStateEnabled()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionHttpStateEnabled", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProxyChainUserName()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionProxyChainUserName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionSingleCookieRequestHeader()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("core", "view", "optionSingleCookieRequestHeader", parameters);
		}

		/// <summary>
		///Shuts down ZAP
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> shutdown(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "shutdown", parameters);
		}

		/// <summary>
		///Creates a new session, optionally overwriting existing files
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> newSession(string apikey, string name, string overwrite)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("name", name);
			parameters.Add("overwrite", overwrite);
			return await api.CallApi("core", "action", "newSession", parameters);
		}

		/// <summary>
		///Loads the session with the given name
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> loadSession(string apikey, string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("name", name);
			return await api.CallApi("core", "action", "loadSession", parameters);
		}

		/// <summary>
		///Saves the session with the name supplied, optionally overwriting existing files
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> saveSession(string apikey, string name, string overwrite)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("name", name);
			parameters.Add("overwrite", overwrite);
			return await api.CallApi("core", "action", "saveSession", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> snapshotSession(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "snapshotSession", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> clearExcludedFromProxy(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "clearExcludedFromProxy", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> excludeFromProxy(string apikey, string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("regex", regex);
			return await api.CallApi("core", "action", "excludeFromProxy", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setHomeDirectory(string apikey, string dir)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("dir", dir);
			return await api.CallApi("core", "action", "setHomeDirectory", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> generateRootCA(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "generateRootCA", parameters);
		}

		/// <summary>
		///Sends the HTTP request, optionally following redirections. Returns the request sent and response received and followed redirections, if any.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> sendRequest(string apikey, string request, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("request", request);
			parameters.Add("followRedirects", followredirects);
			return await api.CallApi("core", "action", "sendRequest", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> deleteAllAlerts(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "deleteAllAlerts", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> runGarbageCollection(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("core", "action", "runGarbageCollection", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> clearStats(string apikey, string keyprefix)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("keyPrefix", keyprefix);
			return await api.CallApi("core", "action", "clearStats", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainName(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("core", "action", "setOptionProxyChainName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainRealm(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("core", "action", "setOptionProxyChainRealm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainUserName(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("core", "action", "setOptionProxyChainUserName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainPassword(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("core", "action", "setOptionProxyChainPassword", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainSkipName(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("core", "action", "setOptionProxyChainSkipName", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionTimeoutInSecs(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("core", "action", "setOptionTimeoutInSecs", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionUseProxyChain(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("core", "action", "setOptionUseProxyChain", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainPrompt(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("core", "action", "setOptionProxyChainPrompt", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionHttpStateEnabled(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("core", "action", "setOptionHttpStateEnabled", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionUseProxyChainAuth(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("core", "action", "setOptionUseProxyChainAuth", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionSingleCookieRequestHeader(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("core", "action", "setOptionSingleCookieRequestHeader", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProxyChainPort(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("core", "action", "setOptionProxyChainPort", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> proxypac(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApiOther("core", "other", "proxy.pac", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> rootcert(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApiOther("core", "other", "rootcert", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> setproxy(string apikey, string proxy)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("proxy", proxy);
			return await api.CallApiOther("core", "other", "setproxy", parameters);
		}

		/// <summary>
		///Generates a report in XML format
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> xmlreport(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApiOther("core", "other", "xmlreport", parameters);
		}

		/// <summary>
		///Generates a report in HTML format
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> htmlreport(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApiOther("core", "other", "htmlreport", parameters);
		}

		/// <summary>
		///Gets the message with the given ID in HAR format
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> messageHar(string apikey, string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("id", id);
			return await api.CallApiOther("core", "other", "messageHar", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent through/by ZAP, in HAR format, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> messagesHar(string apikey, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return await api.CallApiOther("core", "other", "messagesHar", parameters);
		}

		/// <summary>
		///Sends the first HAR request entry, optionally following redirections. Returns, in HAR format, the request sent and response received and followed redirections, if any.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<byte[]> sendHarRequest(string apikey, string request, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("request", request);
			parameters.Add("followRedirects", followredirects);
			return await api.CallApiOther("core", "other", "sendHarRequest", parameters);
		}

	}
}
