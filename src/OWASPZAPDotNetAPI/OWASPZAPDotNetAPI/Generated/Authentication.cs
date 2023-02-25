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
	public class Authentication 
	{
		private ClientApi api = null;

		public Authentication(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets the name of the authentication methods.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getSupportedAuthenticationMethods()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("authentication", "view", "getSupportedAuthenticationMethods", parameters);
		}

		/// <summary>
		///Gets the configuration parameters for the authentication method with the given name.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationMethodConfigParams(string authmethodname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("authMethodName", authmethodname);
			return api.CallApi("authentication", "view", "getAuthenticationMethodConfigParams", parameters);
		}

		/// <summary>
		///Gets the name of the authentication method for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationMethod(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("authentication", "view", "getAuthenticationMethod", parameters);
		}

		/// <summary>
		///Gets the logged in indicator for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getLoggedInIndicator(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("authentication", "view", "getLoggedInIndicator", parameters);
		}

		/// <summary>
		///Gets the logged out indicator for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getLoggedOutIndicator(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("authentication", "view", "getLoggedOutIndicator", parameters);
		}

		/// <summary>
		///Sets the authentication method for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setAuthenticationMethod(string contextid, string authmethodname, string authmethodconfigparams)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("authMethodName", authmethodname);
			parameters.Add("authMethodConfigParams", authmethodconfigparams);
			return api.CallApi("authentication", "action", "setAuthenticationMethod", parameters);
		}

		/// <summary>
		///Sets the logged in indicator for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setLoggedInIndicator(string contextid, string loggedinindicatorregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("loggedInIndicatorRegex", loggedinindicatorregex);
			return api.CallApi("authentication", "action", "setLoggedInIndicator", parameters);
		}

		/// <summary>
		///Sets the logged out indicator for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setLoggedOutIndicator(string contextid, string loggedoutindicatorregex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("loggedOutIndicatorRegex", loggedoutindicatorregex);
			return api.CallApi("authentication", "action", "setLoggedOutIndicator", parameters);
		}

	}
}
