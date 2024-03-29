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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI
{
    public static class ExtensionMethods
    {
        public static string TryGetDictionaryString(this Dictionary<string, IApiResponse> dictionary, string key)
        {
            string retVal = string.Empty;
            IApiResponse response = null;
            dictionary.TryGetValue(key, out response);
            if (response != null)
            {
                if (response is ApiResponseElement)
                {
                    retVal = ((ApiResponseElement)response).Value;
                }
                else if (response is ApiResponseList)
                {
                    // If the response is a List, then it is probably the tags introduced in ZAP 2.11.0
                    // TODO
                    // Retrieving tag information is not supported yet
                }
            }
            return retVal;
        }
    }
}
