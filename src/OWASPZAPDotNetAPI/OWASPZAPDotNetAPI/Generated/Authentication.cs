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
	public class Authentication 
	{
		private ClientApi api = null;

		public Authentication(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> getSupportedAuthenticationMethods()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("authentication", "view", "getSupportedAuthenticationMethods", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> getAuthenticationMethodConfigParams(string authmethodname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("authMethodName", authmethodname);
			return await api.CallApi("authentication", "view", "getAuthenticationMethodConfigParams", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> getAuthenticationMethod(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return await api.CallApi("authentication", "view", "getAuthenticationMethod", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> getLoggedInIndicator(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return await api.CallApi("authentication", "view", "getLoggedInIndicator", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> getLoggedOutIndicator(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return await api.CallApi("authentication", "view", "getLoggedOutIndicator", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setAuthenticationMethod(string apikey, string contextid, string authmethodname, string authmethodconfigparams)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("contextId", contextid);
			parameters.Add("authMethodName", authmethodname);
			parameters.Add("authMethodConfigParams", authmethodconfigparams);
			return await api.CallApi("authentication", "action", "setAuthenticationMethod", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setLoggedInIndicator(string apikey, string contextid, string loggedinindicatorregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("contextId", contextid);
			parameters.Add("loggedInIndicatorRegex", loggedinindicatorregex);
			return await api.CallApi("authentication", "action", "setLoggedInIndicator", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setLoggedOutIndicator(string apikey, string contextid, string loggedoutindicatorregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("contextId", contextid);
			parameters.Add("loggedOutIndicatorRegex", loggedoutindicatorregex);
			return await api.CallApi("authentication", "action", "setLoggedOutIndicator", parameters);
		}

	}
}
