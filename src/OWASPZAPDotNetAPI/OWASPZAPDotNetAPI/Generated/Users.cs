/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2021 the ZAP development team
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
		private ClientApi api = null;

		public Users(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets a list of users that belong to the context with the given ID, or all users if none provided.
		/// </summary>
		/// <returns></returns>
		public IApiResponse usersList(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("users", "view", "usersList", parameters);
		}

		/// <summary>
		///Gets the data of the user with the given ID that belongs to the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getUserById(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getUserById", parameters);
		}

		/// <summary>
		///Gets the configuration parameters for the credentials of the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationCredentialsConfigParams(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("users", "view", "getAuthenticationCredentialsConfigParams", parameters);
		}

		/// <summary>
		///Gets the authentication credentials of the user with given ID that belongs to the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationCredentials(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getAuthenticationCredentials", parameters);
		}

		/// <summary>
		///Gets the authentication state information for the user identified by the Context and User Ids.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationState(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getAuthenticationState", parameters);
		}

		/// <summary>
		///Gets the authentication session information for the user identified by the Context and User Ids, e.g. cookies and realm credentials.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthenticationSession(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "view", "getAuthenticationSession", parameters);
		}

		/// <summary>
		///Creates a new user with the given name for the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse newUser(string contextid, string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("name", name);
			return api.CallApi("users", "action", "newUser", parameters);
		}

		/// <summary>
		///Removes the user with the given ID that belongs to the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeUser(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "action", "removeUser", parameters);
		}

		/// <summary>
		///Sets whether or not the user, with the given ID that belongs to the context with the given ID, should be enabled.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setUserEnabled(string contextid, string userid, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("enabled", enabled);
			return api.CallApi("users", "action", "setUserEnabled", parameters);
		}

		/// <summary>
		///Renames the user with the given ID that belongs to the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setUserName(string contextid, string userid, string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("name", name);
			return api.CallApi("users", "action", "setUserName", parameters);
		}

		/// <summary>
		///Sets the authentication credentials for the user with the given ID that belongs to the context with the given ID.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setAuthenticationCredentials(string contextid, string userid, string authcredentialsconfigparams)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("authCredentialsConfigParams", authcredentialsconfigparams);
			return api.CallApi("users", "action", "setAuthenticationCredentials", parameters);
		}

		/// <summary>
		///Tries to authenticate as the identified user, returning the authentication request and whether it appears to have succeeded.
		/// </summary>
		/// <returns></returns>
		public IApiResponse authenticateAsUser(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "action", "authenticateAsUser", parameters);
		}

		/// <summary>
		///Tries to poll as the identified user, returning the authentication request and whether it appears to have succeeded. This will only work if the polling verification strategy has been configured.
		/// </summary>
		/// <returns></returns>
		public IApiResponse pollAsUser(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("users", "action", "pollAsUser", parameters);
		}

		/// <summary>
		///Sets fields in the authentication state for the user identified by the Context and User Ids.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setAuthenticationState(string contextid, string userid, string lastpollresult, string lastpolltimeinms, string requestssincelastpoll)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("lastPollResult", lastpollresult);
			parameters.Add("lastPollTimeInMs", lastpolltimeinms);
			parameters.Add("requestsSinceLastPoll", requestssincelastpoll);
			return api.CallApi("users", "action", "setAuthenticationState", parameters);
		}

		/// <summary>
		///Sets the specified cookie for the user identified by the Context and User Ids.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setCookie(string contextid, string userid, string domain, string name, string value, string path, string secure)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("domain", domain);
			parameters.Add("name", name);
			parameters.Add("value", value);
			parameters.Add("path", path);
			parameters.Add("secure", secure);
			return api.CallApi("users", "action", "setCookie", parameters);
		}

	}
}
