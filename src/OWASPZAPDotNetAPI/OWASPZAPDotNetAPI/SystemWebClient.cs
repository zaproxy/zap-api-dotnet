﻿/* Zed Attack Proxy (ZAP) and its related class files.
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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI
{
    class SystemWebClient : IWebClient, IDisposable
    {
        WebClient webClient;
        WebProxy webProxy;

        public SystemWebClient(string proxyHost, int proxyPort)
        {
            webProxy = new WebProxy(proxyHost, proxyPort);
            webClient = new WebClient();
            webClient.Proxy = webProxy;
        }

        public string DownloadString(string address)
        {
            return webClient.DownloadString(address);
        }

        public string DownloadString(Uri uri)
        {
            string retVal = string.Empty; 
            try
            {
                retVal = webClient.DownloadString(uri);
            }
            catch (WebException webException)
            {
                var responseStream = webException.Response?.GetResponseStream();
                if (responseStream != null)
                {
                    using (var reader = new StreamReader(responseStream))
                    {
                        retVal = reader.ReadToEnd();
                    }
                }
            }

            return retVal;
        }

        public byte[] DownloadData(Uri uri)
        {
            byte[] retVal = default(byte[]);
            try
            {
                retVal = webClient.DownloadData(uri);
            }
            catch (WebException)
            {
                throw;
            }
            return retVal;
        }

        public void Dispose()
        {
            webClient.Dispose();
        }

        public void AddRequestHeader(string headerName, string headerValue)
        {
            webClient.Headers.Add(headerName, headerValue);
        }

        public string GetRequestHeaderValue(string headerName)
        {
            return webClient.Headers.Get(headerName);
        }

        public void SetRequestHeader(string headerName, string headerValue)
        {
            webClient.Headers.Set(headerName, headerValue);
        }
    }
}
