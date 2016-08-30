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


using OWASPZAPDotNetAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI.Samples
{
    class AuthenticatedScanWithFormsAuthentication
    {
        private static string _target = "http://localhost:8020/SqliModernApp";
        private static string _apikey = string.Empty;
        private static ClientApi _api = new ClientApi("localhost", 7070);
        private static IApiResponse _apiResponse;

        public static async Task Go()
        {
            LoadTargetUrlToSitesTree();

            string contextName = "SqliModernApp";
            int contextId = await CreateContext(contextName);
            string urlToIncludeInContext = @"\Qhttp://localhost:8020/SqliModernApp\E.*";
            await IncludeUrlToContext(contextName, urlToIncludeInContext);

            if (await IsFormsAuthenticationSupported())
            {
                string formBasedAuthenticationConfiguration = PrepareLoginUrlAndRequestData();
                await SetFormsBasedAuthentication(contextId, formBasedAuthenticationConfiguration);
                await SetLoggedInIndicatorForFormsBasedAuthentication(contextId);
            }

            string userName = "ZAP";
            string password = "adminadmin";

            int userId = await CreateNewUser(contextId, userName);
            await SetUserNameAndPassword(contextId, userId, userName, password);
            await EnableUser(contextId, userId);

            await SetASpecificForcedUser(contextId, userId);
            await EnableForcedUserMode();

            int spiderScanId = await StartSpidering();
            await PollTheSpiderTillCompletion(spiderScanId);

            await StartAjaxSpidering();
            await PollTheAjaxSpiderTillCompletion();

            int activeScanId = await StartActiveScanning();
            await PollTheActiveScannerTillCompletion(activeScanId);

            string reportFileName = string.Format("report-{0}", DateTime.Now.ToString("dd-MMM-yyyy-hh-mm-ss"));
            await WriteXmlReport(reportFileName);
            await WriteHtmlReport(reportFileName);
            await PrintAlertsToConsole();

            await ShutdownZAP();
        }

        private static async Task ShutdownZAP()
        {
            _apiResponse = await _api.core.shutdown("");
            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("ZAP shutdown success " + _target);
        }

        private static async Task PrintAlertsToConsole()
        {
            List<Alert> alerts = await _api.GetAlerts(_target, 0, 0);
            foreach (var alert in alerts)
            {
                Console.WriteLine(alert.AlertMessage
                    + Environment.NewLine
                    + alert.CWEId
                    + Environment.NewLine
                    + alert.Url
                    + Environment.NewLine
                    + alert.WASCId
                    + Environment.NewLine
                    + alert.Evidence
                    + Environment.NewLine
                    + alert.Parameter
                    + Environment.NewLine
                );
            }
        }

        private static async Task WriteHtmlReport(string reportFileName)
        {
            byte[] buffer = await _api.core.htmlreport(_apikey);
            File.WriteAllBytes(reportFileName + ".html" , buffer);
        }

        private static async Task WriteXmlReport(string reportFileName)
        {
            byte[] buffer = await _api.core.xmlreport(_apikey);
            File.WriteAllBytes(reportFileName + ".xml", buffer);
        }

        private static async Task PollTheActiveScannerTillCompletion(int activeScanId)
        {
            int activeScannerprogress;
            while (true)
            {
                await Task.Delay(5000);
                var element = await _api.ascan.status(Convert.ToString(activeScanId));
                activeScannerprogress = int.Parse(((ApiResponseElement)element).Value);
                Console.WriteLine("Active scanner progress: {0}%", activeScannerprogress);
                if (activeScannerprogress >= 100)
                    break;
            }
            Console.WriteLine("Active scanner complete");
        }

        private static async Task<int> StartActiveScanning()
        {
            Console.WriteLine("Active Scanner: " + _target);
            _apiResponse = await _api.ascan.scan(_apikey, _target, "", "", "", "", "");

            int activeScanId = int.Parse(((ApiResponseElement)_apiResponse).Value);
            return activeScanId;
        }

        private static async Task PollTheAjaxSpiderTillCompletion()
        {
            while (true)
            {
                await Task.Delay(1000);
                string ajaxSpiderStatusText = string.Empty;
                var status = await _api.ajaxspider.status();
                ajaxSpiderStatusText = Convert.ToString(((ApiResponseElement)status).Value);
                if (ajaxSpiderStatusText.IndexOf("running", StringComparison.OrdinalIgnoreCase) > -1)
                    Console.WriteLine("Ajax Spider running");
                else
                    break;
            }

            Console.WriteLine("Ajax Spider complete");
            await Task.Delay(10000);
        }

        private static async Task StartAjaxSpidering()
        {
            Console.WriteLine("Ajax Spider: " + _target);
            _apiResponse = await _api.ajaxspider.scan(_apikey, _target, "");

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("Ajax Spider started for " + _target);
        }

        private static async Task PollTheSpiderTillCompletion(int scanid)
        {
            int spiderProgress;
            while (true)
            {
                await Task.Delay(1000);
                var status = await _api.spider.status(Convert.ToString(scanid));
                spiderProgress = int.Parse(((ApiResponseElement)status).Value);
                Console.WriteLine("Spider progress: {0}%", spiderProgress);
                if (spiderProgress >= 100)
                    break;
            }

            Console.WriteLine("Spider complete");
            await Task.Delay(10000);
        }

        private static async Task<int> StartSpidering()
        {
            Console.WriteLine("Spider: " + _target);
            _apiResponse = await _api.spider.scan(_apikey, _target, "");
            int scanid = int.Parse(((ApiResponseElement)_apiResponse).Value);
            return scanid;
        }

        private static async Task EnableForcedUserMode()
        {
            _apiResponse = await _api.forcedUser.setForcedUserModeEnabled(_apikey, true);
        }

        private static async Task SetASpecificForcedUser(int contextId, int userId)
        {
            _apiResponse = await _api.forcedUser.setForcedUser(_apikey,  Convert.ToString(contextId), Convert.ToString(userId));
        }

        private static async Task EnableUser(int contextId, int userId)
        {
            _apiResponse = await _api.users.setUserEnabled(_apikey, Convert.ToString(contextId), Convert.ToString(userId), "true");

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("user enabled");
        }

        private static async Task SetUserNameAndPassword(int contextId, int userId, string userName, string password)
        {
            string userAuthenticationConfigFormat = "username={0}&password={1}";
            string userAuthenticationConfig = string.Format(userAuthenticationConfigFormat, userName, password);

            _apiResponse = await _api.users.setAuthenticationCredentials(_apikey, Convert.ToString(contextId), Convert.ToString(userId), userAuthenticationConfig);

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("User credentials set");
        }

        private static async Task<int> CreateNewUser(int contextId, string userName)
        {
            _apiResponse = await _api.users.newUser(_apikey, Convert.ToString(contextId), userName);
            int userId = int.Parse(((ApiResponseElement)_apiResponse).Value);
            return userId;
        }

        private static void ConfigureFormsBasedAuthentication(string contextId)
        {

        }

        private static async Task SetLoggedInIndicatorForFormsBasedAuthentication(int contextId)
        {
            string loggedInIndicator = @"\Q<form action=""/SqliModernApp/Account/LogOff"" id=""logoutForm"" method=""post"">\E";
            _apiResponse = await _api.authentication.setLoggedInIndicator(_apikey, Convert.ToString(contextId), loggedInIndicator);

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("loggedInIndicator is set");
        }

        private static async Task SetFormsBasedAuthentication(int contextId, string formBasedAuthenticationConfiguration)
        {
            _apiResponse = await _api.authentication.setAuthenticationMethod(_apikey, Convert.ToString(contextId), "formBasedAuthentication", formBasedAuthenticationConfiguration);

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("formBasedAuthentication is configured");
        }

        private static string PrepareLoginUrlAndRequestData()
        {
            string loginUrl = "http://localhost:8020/SqliModernApp/Account/Login";
            string loginRequestData = "username={%username%}&password={%password%}";

            string formBasedAuthenticationConfigurationFormat = "loginUrl={0}&loginRequestData={1}";
            string formBasedAuthenticationConfiguration = string.Format(formBasedAuthenticationConfigurationFormat,
                Uri.EscapeDataString(loginUrl),
                Uri.EscapeDataString(loginRequestData));
            return formBasedAuthenticationConfiguration;
        }

        private static async Task<bool> IsFormsAuthenticationSupported()
        {
            bool isFormsAuthenticatedSupported = false;
            string formsAuthenticationString = "formBasedAuthentication";

            _apiResponse = await _api.authentication.getSupportedAuthenticationMethods();

            Console.WriteLine("Supported authentication methods are:" + Environment.NewLine);
            foreach (var authenticationMethod in ((ApiResponseList)_apiResponse).List)
            {
                string authenticationMethodName = ((ApiResponseElement)authenticationMethod).Value;
                if (formsAuthenticationString.IndexOf(authenticationMethodName, StringComparison.OrdinalIgnoreCase) > -1)
                {
                    isFormsAuthenticatedSupported = true;
                }
                Console.WriteLine(authenticationMethodName + Environment.NewLine);
            }

            return isFormsAuthenticatedSupported;
        }

        private static async Task IncludeUrlToContext(string contextName, string urlToIncludeInContext)
        {
            _apiResponse = await _api.context.includeInContext(_apikey, contextName, urlToIncludeInContext);

            if ("OK" == ((ApiResponseElement)_apiResponse).Value)
                Console.WriteLine("{0} included to context {1}", urlToIncludeInContext, contextName);
        }

        private static async Task<int> CreateContext(string contextName)
        {
            _apiResponse = await _api.context.newContext(_apikey, contextName);
            int contextId = int.Parse(((ApiResponseElement)_apiResponse).Value);
            Console.WriteLine("{0} context created with id {1}", contextName, contextId);
            return contextId;
        }

        private static void LoadTargetUrlToSitesTree()
        {
            _api.AccessUrl(_target);
        }
    }
}
