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
	public class Acsrf 
	{
		private ClientApi api = null;

		public Acsrf(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Lists the names of all anti-CSRF tokens
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionTokensNames()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("acsrf", "view", "optionTokensNames", parameters);
		}

		/// <summary>
		///Define if ZAP should detect CSRF tokens by searching for partial matches
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionPartialMatchingEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("acsrf", "view", "optionPartialMatchingEnabled", parameters);
		}

		/// <summary>
		///Adds an anti-CSRF token with the given name, enabled by default
		/// </summary>
		/// <returns></returns>
		public IApiResponse addOptionToken(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("acsrf", "action", "addOptionToken", parameters);
		}

		/// <summary>
		///Removes the anti-CSRF token with the given name
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeOptionToken(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("acsrf", "action", "removeOptionToken", parameters);
		}

		/// <summary>
		///Define if ZAP should detect CSRF tokens by searching for partial matches.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionPartialMatchingEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("acsrf", "action", "setOptionPartialMatchingEnabled", parameters);
		}

		/// <summary>
		///Generate a form for testing lack of anti-CSRF tokens - typically invoked via ZAP
		/// </summary>
		/// <returns></returns>
		public byte[] genForm(string hrefid, string actionurl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("hrefId", hrefid);
			parameters.Add("actionUrl", actionurl);
			return api.CallApiOther("acsrf", "other", "genForm", parameters);
		}

	}
}
