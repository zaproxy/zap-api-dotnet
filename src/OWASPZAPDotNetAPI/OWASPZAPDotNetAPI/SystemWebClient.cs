/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright the ZAP development team
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
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI
{
    class SystemWebClient : IWebClient
    {
        private readonly string _proxyHost;
        private readonly int _proxyPort;

        private class WebProxy : IWebProxy
        {
            private readonly string _proxyHost;
            private readonly int _proxyPort;

            public WebProxy(string proxyHost, int proxyPort)
            {
                _proxyHost = proxyHost;
                _proxyPort = proxyPort;
            }

            public Uri GetProxy(Uri destination)
            {
                return new Uri("http://" + _proxyHost + ":" + _proxyPort);
            }

            public bool IsBypassed(Uri host)
            {
                return false;
            }

            public ICredentials Credentials { get; set; }
        }
        
        public SystemWebClient(string proxyHost, int proxyPort)
        {
            _proxyHost = proxyHost;
            _proxyPort = proxyPort;
        }

        private void HandleException(WebException e, string requestUrl)
        {
            string content = string.Format("Error '{0}' calling '{1}'.", e.Status, requestUrl);
            if (e.Response != null)
            {
                using (var errorStream = e.Response.GetResponseStream())
                using (var errorReader = new StreamReader(errorStream))
                {
                    content += "Details: " + errorReader.ReadToEnd();
                }
            }
            throw new Exception(content, e);
        }


        public async Task<string> DownloadString(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentNullException(nameof(address));
            }

            var request = (HttpWebRequest)WebRequest.Create(address);
            request.Proxy = new WebProxy(_proxyHost, _proxyPort);
            string result = null;
            try
            {
                using (var response = await request.GetResponseAsync().ConfigureAwait(false))
                using (var stream = response.GetResponseStream())
                using (var streamReader = new StreamReader(stream))
                {
                    result = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                }
            }
            catch(WebException e)
            {
                HandleException(e, address);
            }
            return result;
        }

        public async Task<string> DownloadString(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Proxy = new WebProxy(_proxyHost, _proxyPort);
            string result = null;
            try
            {
                using (var response = await request.GetResponseAsync().ConfigureAwait(false))
                using (var stream = response.GetResponseStream())
                using (var streamReader = new StreamReader(stream))
                {
                    result = await streamReader.ReadToEndAsync().ConfigureAwait(false);
                }
            }
            catch (WebException e)
            {
                HandleException(e, uri.ToString());
            }
            return result;
        }

        public async Task<byte[]> DownloadData(Uri uri)
        {
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Proxy = new WebProxy(_proxyHost, _proxyPort);
            byte[] buffer = null;
            try
            {
                using (var response = await request.GetResponseAsync().ConfigureAwait(false))
                using (var stream = response.GetResponseStream())
                using (var memoryStream = new MemoryStream())
                {
                    await stream.CopyToAsync(memoryStream).ConfigureAwait(false);
                    buffer = memoryStream.ToArray();
                }
            }
            catch (WebException e)
            {
                HandleException(e, uri.ToString());
            }
            return buffer;
        }
    }
}
