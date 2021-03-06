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
	public class ForcedUser 
	{
		private ClientApi api = null;

		public ForcedUser(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns 'true' if 'forced user' mode is enabled, 'false' otherwise
		/// </summary>
		/// <returns></returns>
		public IApiResponse isForcedUserModeEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("forcedUser", "view", "isForcedUserModeEnabled", parameters);
		}

		/// <summary>
		///Gets the user (ID) set as 'forced user' for the given context (ID)
		/// </summary>
		/// <returns></returns>
		public IApiResponse getForcedUser(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("forcedUser", "view", "getForcedUser", parameters);
		}

		/// <summary>
		///Sets the user (ID) that should be used in 'forced user' mode for the given context (ID)
		/// </summary>
		/// <returns></returns>
		public IApiResponse setForcedUser(string contextid, string userid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			return api.CallApi("forcedUser", "action", "setForcedUser", parameters);
		}

		/// <summary>
		///Sets if 'forced user' mode should be enabled or not
		/// </summary>
		/// <returns></returns>
		public IApiResponse setForcedUserModeEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("boolean", Convert.ToString(boolean));
			return api.CallApi("forcedUser", "action", "setForcedUserModeEnabled", parameters);
		}

	}
}
