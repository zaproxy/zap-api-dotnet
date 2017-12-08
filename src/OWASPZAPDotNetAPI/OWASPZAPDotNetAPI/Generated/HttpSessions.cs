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
	public class HttpSessions 
	{
		private ClientApi api = null;

		public HttpSessions(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets all of the sites that have sessions.
		/// </summary>
		/// <returns></returns>
		public IApiResponse sites()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("httpSessions", "view", "sites", parameters);
		}

		/// <summary>
		///Gets the sessions for the given site. Optionally returning just the session with the given name.
		/// </summary>
		/// <returns></returns>
		public IApiResponse sessions(string site, string session)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("session", session);
			return api.CallApi("httpSessions", "view", "sessions", parameters);
		}

		/// <summary>
		///Gets the name of the active session for the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse activeSession(string site)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			return api.CallApi("httpSessions", "view", "activeSession", parameters);
		}

		/// <summary>
		///Gets the names of the session tokens for the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse sessionTokens(string site)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			return api.CallApi("httpSessions", "view", "sessionTokens", parameters);
		}

		/// <summary>
		///Creates an empty session for the given site. Optionally with the given name.
		/// </summary>
		/// <returns></returns>
		public IApiResponse createEmptySession(string site, string session)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("session", session);
			return api.CallApi("httpSessions", "action", "createEmptySession", parameters);
		}

		/// <summary>
		///Removes the session from the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeSession(string site, string session)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("session", session);
			return api.CallApi("httpSessions", "action", "removeSession", parameters);
		}

		/// <summary>
		///Sets the given session as active for the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setActiveSession(string site, string session)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("session", session);
			return api.CallApi("httpSessions", "action", "setActiveSession", parameters);
		}

		/// <summary>
		///Unsets the active session of the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse unsetActiveSession(string site)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			return api.CallApi("httpSessions", "action", "unsetActiveSession", parameters);
		}

		/// <summary>
		///Adds the session token to the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse addSessionToken(string site, string sessiontoken)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("sessionToken", sessiontoken);
			return api.CallApi("httpSessions", "action", "addSessionToken", parameters);
		}

		/// <summary>
		///Removes the session token from the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeSessionToken(string site, string sessiontoken)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("sessionToken", sessiontoken);
			return api.CallApi("httpSessions", "action", "removeSessionToken", parameters);
		}

		/// <summary>
		///Sets the value of the session token of the given session for the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setSessionTokenValue(string site, string session, string sessiontoken, string tokenvalue)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("session", session);
			parameters.Add("sessionToken", sessiontoken);
			parameters.Add("tokenValue", tokenvalue);
			return api.CallApi("httpSessions", "action", "setSessionTokenValue", parameters);
		}

		/// <summary>
		///Renames the session of the given site.
		/// </summary>
		/// <returns></returns>
		public IApiResponse renameSession(string site, string oldsessionname, string newsessionname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("site", site);
			parameters.Add("oldSessionName", oldsessionname);
			parameters.Add("newSessionName", newsessionname);
			return api.CallApi("httpSessions", "action", "renameSession", parameters);
		}

	}
}
