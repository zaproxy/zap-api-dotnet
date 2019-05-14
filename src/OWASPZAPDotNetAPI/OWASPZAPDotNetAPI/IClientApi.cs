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


using OWASPZAPDotNetAPI.Generated;
using System.Collections.Generic;

namespace OWASPZAPDotNetAPI
{
    public interface IClientApi
    {
        Acsrf acsrf { get; set; }
        AjaxSpider ajaxspider { get; set; }
        Ascan ascan { get; set; }
        Authentication authentication { get; set; }
        OWASPZAPDotNetAPI.Generated.Authorization authorization { get; set; }
        Autoupdate autoupdate { get; set; }
        Break brk { get; set; }
        Context context { get; set; }
        Core core { get; set; }
        ForcedUser forcedUser { get; set; }
        HttpSessions httpSessions { get; set; }
        ImportLogFiles importLogFiles { get; set; }
        Params parameters { get; set; }
        Pnh pnh { get; set; }
        Pscan pscan { get; set; }
        Reveal reveal { get; set; }
        Script script { get; set; }
        Search search { get; set; }
        Selenium selenium { get; set; }
        SessionManagement sessionManagement { get; set; }
        Spider spider { get; set; }
        Stats stats { get; set; }
        Users users { get; set; }

        void AccessUrl(string url);
        List<Alert> GetAlerts(string baseUrl, int start, int count, string riskId);
        IApiResponse CallApi(string component, string operationType, string operationName, Dictionary<string, string> parameters);
        byte[] CallApiOther(string component, string operationType, string operationName, Dictionary<string, string> parameters);
    }
}
