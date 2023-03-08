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
	public class Exim 
	{
		private ClientApi api = null;

		public Exim(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Imports a HAR file.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importHar(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("exim", "action", "importHar", parameters);
		}

		/// <summary>
		///Imports URLs (one per line) from the file with the given file system path.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importUrls(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("exim", "action", "importUrls", parameters);
		}

		/// <summary>
		///Imports previously exported ZAP messages from the file with the given file system path.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importZapLogs(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("exim", "action", "importZapLogs", parameters);
		}

		/// <summary>
		///Imports ModSecurity2 logs from the file with the given file system path.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importModsec2Logs(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("exim", "action", "importModsec2Logs", parameters);
		}

		/// <summary>
		///Gets the HTTP messages sent through/by ZAP, in HAR format, optionally filtered by URL and paginated with 'start' position and 'count' of messages
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] exportHar(string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("exim", "other", "exportHar", parameters);
		}

		/// <summary>
		///Gets the HTTP messages with the given IDs, in HAR format.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] exportHarById(string ids)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ids", ids);
			return api.CallApiOther("exim", "other", "exportHarById", parameters);
		}

		/// <summary>
		///Sends the first HAR request entry, optionally following redirections. Returns, in HAR format, the request sent and response received and followed redirections, if any. The Mode is enforced when sending the request (and following redirections), custom manual requests are not allowed in 'Safe' mode nor in 'Protected' mode if out of scope.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] sendHarRequest(string request, string followredirects)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("request", request);
			parameters.Add("followRedirects", followredirects);
			return api.CallApiOther("exim", "other", "sendHarRequest", parameters);
		}

	}
}
