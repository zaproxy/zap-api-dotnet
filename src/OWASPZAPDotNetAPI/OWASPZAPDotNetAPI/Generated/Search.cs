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
	public class Search 
	{
		private ClientApi api = null;

		public Search(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns the URLs of the HTTP messages that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urlsByUrlRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "urlsByUrlRegex", parameters);
		}

		/// <summary>
		///Returns the URLs of the HTTP messages that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urlsByRequestRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "urlsByRequestRegex", parameters);
		}

		/// <summary>
		///Returns the URLs of the HTTP messages that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urlsByResponseRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "urlsByResponseRegex", parameters);
		}

		/// <summary>
		///Returns the URLs of the HTTP messages that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urlsByHeaderRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "urlsByHeaderRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesByUrlRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "messagesByUrlRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesByRequestRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "messagesByRequestRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesByResponseRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "messagesByResponseRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public IApiResponse messagesByHeaderRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("search", "view", "messagesByHeaderRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages, in HAR format, that match the given regular expression in the URL optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public byte[] harByUrlRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("search", "other", "harByUrlRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages, in HAR format, that match the given regular expression in the request optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public byte[] harByRequestRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("search", "other", "harByRequestRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages, in HAR format, that match the given regular expression in the response optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public byte[] harByResponseRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("search", "other", "harByResponseRegex", parameters);
		}

		/// <summary>
		///Returns the HTTP messages, in HAR format, that match the given regular expression in the header(s) optionally filtered by URL and paginated with 'start' position and 'count' of messages.
		/// </summary>
		/// <returns></returns>
		public byte[] harByHeaderRegex(string regex, string baseurl, string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("baseurl", baseurl);
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApiOther("search", "other", "harByHeaderRegex", parameters);
		}

	}
}
