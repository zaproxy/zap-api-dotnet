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
	public class Break 
	{
		private IClientApi api = null;

		public Break(IClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns True if ZAP will break on both requests and responses
		/// </summary>
		/// <returns></returns>
		public IApiResponse isBreakAll()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "view", "isBreakAll", parameters);
		}

		/// <summary>
		///Returns True if ZAP will break on requests
		/// </summary>
		/// <returns></returns>
		public IApiResponse isBreakRequest()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "view", "isBreakRequest", parameters);
		}

		/// <summary>
		///Returns True if ZAP will break on responses
		/// </summary>
		/// <returns></returns>
		public IApiResponse isBreakResponse()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "view", "isBreakResponse", parameters);
		}

		/// <summary>
		///Returns the HTTP message currently intercepted (if any)
		/// </summary>
		/// <returns></returns>
		public IApiResponse httpMessage()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "view", "httpMessage", parameters);
		}

		/// <summary>
		///Controls the global break functionality. The type may be one of: http-all, http-request or http-response. The state may be true (for turning break on for the specified type) or false (for turning break off). Scope is not currently used.
		/// </summary>
		/// <returns></returns>
		public IApiResponse brk(string type, string state, string scope)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("type", type);
			parameters.Add("state", state);
			parameters.Add("scope", scope);
			return api.CallApi("break", "action", "break", parameters);
		}

		/// <summary>
		///Overwrites the currently intercepted message with the data provided
		/// </summary>
		/// <returns></returns>
		public IApiResponse setHttpMessage(string httpheader, string httpbody)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("httpHeader", httpheader);
			parameters.Add("httpBody", httpbody);
			return api.CallApi("break", "action", "setHttpMessage", parameters);
		}

		/// <summary>
		///Submits the currently intercepted message and unsets the global request/response break points
		/// </summary>
		/// <returns></returns>
		public IApiResponse cont()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "action", "continue", parameters);
		}

		/// <summary>
		///Submits the currently intercepted message, the next request or response will automatically be intercepted
		/// </summary>
		/// <returns></returns>
		public IApiResponse step()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "action", "step", parameters);
		}

		/// <summary>
		///Drops the currently intercepted message
		/// </summary>
		/// <returns></returns>
		public IApiResponse drop()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("break", "action", "drop", parameters);
		}

		/// <summary>
		///Adds a custom HTTP breakpont. The string is the string to match. Location may be one of: url, request_header, request_body, response_header or response_body. Match may be: contains or regex. Inverse (match) may be true or false. Lastly, ignorecase (when matching the string) may be true or false.  
		/// </summary>
		/// <returns></returns>
		public IApiResponse addHttpBreakpoint(string str, string location, string match, string inverse, string ignorecase)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("string", str);
			parameters.Add("location", location);
			parameters.Add("match", match);
			parameters.Add("inverse", inverse);
			parameters.Add("ignorecase", ignorecase);
			return api.CallApi("break", "action", "addHttpBreakpoint", parameters);
		}

		/// <summary>
		///Removes the specified break point
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeHttpBreakpoint(string str, string location, string match, string inverse, string ignorecase)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("string", str);
			parameters.Add("location", location);
			parameters.Add("match", match);
			parameters.Add("inverse", inverse);
			parameters.Add("ignorecase", ignorecase);
			return api.CallApi("break", "action", "removeHttpBreakpoint", parameters);
		}

	}
}
