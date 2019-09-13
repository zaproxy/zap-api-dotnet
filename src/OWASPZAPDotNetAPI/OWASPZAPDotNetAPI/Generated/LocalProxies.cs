/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2019 the ZAP development team
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
	public class LocalProxies 
	{
		private ClientApi api = null;

		public LocalProxies(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets all of the additional proxies that have been configured.
		/// </summary>
		/// <returns></returns>
		public IApiResponse additionalProxies()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("localProxies", "view", "additionalProxies", parameters);
		}

		/// <summary>
		///Adds an new proxy using the details supplied.
		/// </summary>
		/// <returns></returns>
		public IApiResponse addAdditionalProxy(string address, string port, string behindnat, string alwaysdecodezip, string removeunsupportedencodings)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("address", address);
			parameters.Add("port", port);
			parameters.Add("behindNat", behindnat);
			parameters.Add("alwaysDecodeZip", alwaysdecodezip);
			parameters.Add("removeUnsupportedEncodings", removeunsupportedencodings);
			return api.CallApi("localProxies", "action", "addAdditionalProxy", parameters);
		}

		/// <summary>
		///Removes the additional proxy with the specified address and port.
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeAdditionalProxy(string address, string port)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("address", address);
			parameters.Add("port", port);
			return api.CallApi("localProxies", "action", "removeAdditionalProxy", parameters);
		}

	}
}
