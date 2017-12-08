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
	public class SessionManagement 
	{
		private ClientApi api = null;

		public SessionManagement(ClientApi api) 
		{
			this.api = api;
		}

		public IApiResponse getSupportedSessionManagementMethods()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("sessionManagement", "view", "getSupportedSessionManagementMethods", parameters);
		}

		public IApiResponse getSessionManagementMethodConfigParams(string methodname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("methodName", methodname);
			return api.CallApi("sessionManagement", "view", "getSessionManagementMethodConfigParams", parameters);
		}

		public IApiResponse getSessionManagementMethod(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("sessionManagement", "view", "getSessionManagementMethod", parameters);
		}

		public IApiResponse setSessionManagementMethod(string contextid, string methodname, string methodconfigparams)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("methodName", methodname);
			parameters.Add("methodConfigParams", methodconfigparams);
			return api.CallApi("sessionManagement", "action", "setSessionManagementMethod", parameters);
		}

	}
}
