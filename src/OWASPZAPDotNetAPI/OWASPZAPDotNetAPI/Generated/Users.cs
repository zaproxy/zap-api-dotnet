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
	public class Users 
	{
		private IClientApi api = null;

		public Users(IClientApi api) 
		{
			this.api = api;
		}

		public IApiResponse usersList(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("users", "view", "usersList", parameters);
		}

		public IApiResponse getUserById(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getUserById", parameters);
		}

		public IApiResponse getAuthenticationCredentialsConfigParams(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("users", "view", "getAuthenticationCredentialsConfigParams", parameters);
		}

		public IApiResponse getAuthenticationCredentials(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getAuthenticationCredentials", parameters);
		}

		public IApiResponse newUser(string contextid, string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("name", name);
			return api.CallApi("users", "action", "newUser", parameters);
		}

		public IApiResponse removeUser(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "action", "removeUser", parameters);
		}

		public IApiResponse setUserEnabled(string contextid, string userid, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("enabled", enabled);
			return api.CallApi("users", "action", "setUserEnabled", parameters);
		}

		public IApiResponse setUserName(string contextid, string userid, string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("name", name);
			return api.CallApi("users", "action", "setUserName", parameters);
		}

		public IApiResponse setAuthenticationCredentials(string contextid, string userid, string authcredentialsconfigparams)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("authCredentialsConfigParams", authcredentialsconfigparams);
			return api.CallApi("users", "action", "setAuthenticationCredentials", parameters);
		}

	}
}
