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
	public class Authorization 
	{
		private ClientApi api = null;

		public Authorization(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Obtains all the configuration of the authorization detection method that is currently set for a context.
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAuthorizationDetectionMethod(string contextid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			return api.CallApi("authorization", "view", "getAuthorizationDetectionMethod", parameters);
		}

		/// <summary>
		///Sets the authorization detection method for a context as one that identifies un-authorized messages based on: the message's status code or a regex pattern in the response's header or body. Also, whether all conditions must match or just some can be specified via the logicalOperator parameter, which accepts two values: "AND" (default), "OR".  
		/// </summary>
		/// <returns></returns>
		public IApiResponse setBasicAuthorizationDetectionMethod(string contextid, string headerregex, string bodyregex, string statuscode, string logicaloperator)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextId", contextid);
			parameters.Add("headerRegex", headerregex);
			parameters.Add("bodyRegex", bodyregex);
			parameters.Add("statusCode", statuscode);
			parameters.Add("logicalOperator", logicaloperator);
			return api.CallApi("authorization", "action", "setBasicAuthorizationDetectionMethod", parameters);
		}

	}
}
