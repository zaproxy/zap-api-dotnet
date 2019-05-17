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
	public class ImportLogFiles 
	{
		private IClientApi api = null;

		public ImportLogFiles(IClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse ImportZAPLogFromFile(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("FilePath", filepath);
			return api.CallApi("importLogFiles", "action", "ImportZAPLogFromFile", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse ImportModSecurityLogFromFile(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("FilePath", filepath);
			return api.CallApi("importLogFiles", "action", "ImportModSecurityLogFromFile", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse ImportZAPHttpRequestResponsePair(string httprequest, string httpresponse)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("HTTPRequest", httprequest);
			parameters.Add("HTTPResponse", httpresponse);
			return api.CallApi("importLogFiles", "action", "ImportZAPHttpRequestResponsePair", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse PostModSecurityAuditEvent(string auditeventstring)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("AuditEventString", auditeventstring);
			return api.CallApi("importLogFiles", "action", "PostModSecurityAuditEvent", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] OtherPostModSecurityAuditEvent(string auditeventstring)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("AuditEventString", auditeventstring);
			return api.CallApiOther("importLogFiles", "other", "OtherPostModSecurityAuditEvent", parameters);
		}

	}
}
