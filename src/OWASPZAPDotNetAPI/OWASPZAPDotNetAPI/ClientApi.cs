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


using OWASPZAPDotNetAPI.Generated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OWASPZAPDotNetAPI
{
    public sealed class ClientApi : IDisposable, IClientApi
    {
        private IWebClient webClient;
        private string zapAddress;
        private int zapPort;
        private string apiKey;
        private string format = "xml";
        private string otherFormat = "other";
        private string zapApiKeyHeaderName = "X-ZAP-API-Key";
        private static string _zapApiKeyParameterName = "apikey";

        //New API needs to be added here
        public Acsrf acsrf { get; set; }
        public AjaxSpider ajaxspider { get; set; }
        public Ascan ascan { get; set; }
        public Authentication authentication { get; set; }
        public OWASPZAPDotNetAPI.Generated.Authorization authorization { get; set; }
        public Autoupdate autoupdate { get; set; }
        public Break brk { get; set; }
        public Context context { get; set; }
        public Core core { get; set; }
        public ForcedUser forcedUser { get; set; }
        public HttpSessions httpSessions { get; set; }
        public ImportLogFiles importLogFiles { get; set; }
        public Params parameters { get; set; }
        public Pnh pnh { get; set; }
        public Pscan pscan { get; set; }
        public Reveal reveal { get; set; }
        public Script script { get; set; }
        public Search search { get; set; }
        public Selenium selenium { get; set; }
        public SessionManagement sessionManagement { get; set; }
        public Spider spider { get; set; }
        public Stats stats { get; set; }
        public Users users { get; set; }

        public ClientApi(string zapAddress, int zapPort, string apiKey)
        {
            this.zapAddress = zapAddress;
            this.zapPort = zapPort;
            this.apiKey = apiKey;
            webClient = new SystemWebClient(zapAddress, zapPort);
            InitializeApiObjects();
        }

        public ClientApi(IWebClient webClient)
        {
            this.webClient = webClient;
            InitializeApiObjects();
        }

        private void InitializeApiObjects()
        {
            //New API needs to be instantiated here
            acsrf = new Acsrf(this);
            ajaxspider = new AjaxSpider(this);
            ascan = new Ascan(this);
            authentication = new Authentication(this);
            authorization = new OWASPZAPDotNetAPI.Generated.Authorization(this);
            autoupdate = new Autoupdate(this);
            brk = new Break(this);
            context = new Context(this);
            core = new Core(this);
            forcedUser = new ForcedUser(this);
            httpSessions = new HttpSessions(this);
            importLogFiles = new ImportLogFiles(this);
            parameters = new Params(this);
            pnh = new Pnh(this); 
            pscan = new Pscan(this);
            reveal = new Reveal(this);
            script = new Script(this);
            search = new Search(this);
            selenium = new Selenium(this);
            sessionManagement = new SessionManagement(this);
            spider = new Spider(this);
            stats = new Stats(this);
            users = new Users(this);
        }

        public void AccessUrl(string url)
        {
            var output = webClient.DownloadString(url);
        }

        public List<Alert> GetAlerts(string baseUrl, int start, int count, string riskId)
        {
            List<Alert> alerts = new List<Alert>();
            IApiResponse response = core.alerts(baseUrl, Convert.ToString(start), Convert.ToString(count), riskId);
            if (response != null && response is ApiResponseList)
            {
                ApiResponseList apiResponseList = (ApiResponseList)response;
                foreach (var alertSet in apiResponseList.List)
                {
                    ApiResponseSet apiResponseSet = (ApiResponseSet)alertSet;
                    alerts.Add(GetNewAlertFromAResponseSet(apiResponseSet));
                }
            }
            return alerts;
        }

        private static Alert GetNewAlertFromAResponseSet(ApiResponseSet apiResponseSet)
        {
            return new Alert(apiResponseSet.Dictionary.TryGetDictionaryString("alert"), apiResponseSet.Dictionary.TryGetDictionaryString("url"))
            {
                Attack = apiResponseSet.Dictionary.TryGetDictionaryString("attack"),
                Confidence = string.IsNullOrWhiteSpace(apiResponseSet.Dictionary.TryGetDictionaryString("confidence")) ?
                    Alert.ConfidenceLevel.Low :
                    (Alert.ConfidenceLevel)Enum.Parse(typeof(Alert.ConfidenceLevel), apiResponseSet.Dictionary.TryGetDictionaryString("confidence")),
                CWEId = int.Parse(apiResponseSet.Dictionary.TryGetDictionaryString("cweid")),
                Description = apiResponseSet.Dictionary.TryGetDictionaryString("description"),
                Evidence = apiResponseSet.Dictionary.TryGetDictionaryString("evidence"),
                Other = apiResponseSet.Dictionary.TryGetDictionaryString("other"),
                Parameter = apiResponseSet.Dictionary.TryGetDictionaryString("param"),
                Reference = apiResponseSet.Dictionary.TryGetDictionaryString("reference"),
                Risk = string.IsNullOrWhiteSpace(apiResponseSet.Dictionary.TryGetDictionaryString("risk")) ?
                    Alert.RiskLevel.Low :
                    (Alert.RiskLevel)Enum.Parse(typeof(Alert.RiskLevel), apiResponseSet.Dictionary.TryGetDictionaryString("risk")),
                Solution = apiResponseSet.Dictionary.TryGetDictionaryString("solution"),
                WASCId = int.Parse(apiResponseSet.Dictionary.TryGetDictionaryString("wascid"))
            };
                                
        }

        public IApiResponse CallApi(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            XmlDocument xmlDocument = this.CallApiRaw(component, operationType, operationName, parameters);
            return ApiResponseFactory.GetResponse(xmlDocument.ChildNodes[1]);
        }

        private XmlDocument CallApiRaw(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            Uri requestUrl = PrepareZapRequest(this.format, component, operationType, operationName, parameters);            
            string responseString = webClient.DownloadString(requestUrl);
            XmlDocument responseXmlDocument = new XmlDocument();
            responseXmlDocument.LoadXml(responseString);
            return responseXmlDocument;
        }

        public byte[] CallApiOther(string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            Uri requestUrl = PrepareZapRequest(this.otherFormat, component, operationType, operationName, parameters);  
            byte[] response = webClient.DownloadData(requestUrl);
            return response;
        }

        private Uri PrepareZapRequest(string format, string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            Uri requestUrl = BuildZapRequestUrl(this.zapAddress, this.zapPort, this.apiKey, format, component, operationType, operationName, parameters);
            string apiKeyValueFromRequestHeader = webClient.GetRequestHeaderValue(this.zapApiKeyHeaderName);
            if (String.IsNullOrWhiteSpace(apiKeyValueFromRequestHeader))
            {
                webClient.AddRequestHeader(this.zapApiKeyHeaderName, this.apiKey);
            }
            return requestUrl;
        }

        private static Uri BuildZapRequestUrl(string zapAddress, int zapPort, string apikey, string format, string component, string operationType, string operationName, Dictionary<string, string> parameters)
        {
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = "http";
            uriBuilder.Host = zapAddress;
            uriBuilder.Port = zapPort;
            uriBuilder.Path = new StringBuilder()
                                    .Append(format)
                                    .Append("/")
                                    .Append(component)
                                    .Append("/")
                                    .Append(operationType)
                                    .Append("/")
                                    .Append(operationName)
                                    .ToString();
            StringBuilder query = new StringBuilder();
            if (parameters != null)
            {
                foreach (var parameter in parameters)
                {
                    query.Append(Uri.EscapeDataString(parameter.Key));
                    query.Append("=");
                    query.Append(Uri.EscapeDataString(parameter.Value));
                    query.Append("&");
                }
            }

            if (!string.IsNullOrWhiteSpace(apikey))
            {
                query.Append(Uri.EscapeDataString(_zapApiKeyParameterName));
                query.Append("=");
                query.Append(Uri.EscapeDataString(apikey));
                query.Append("&");
            }
            

            uriBuilder.Query = query.ToString();
            return uriBuilder.Uri;
        }

        public void Dispose()
        {
            ((IDisposable)webClient).Dispose();
        }
    }
}
