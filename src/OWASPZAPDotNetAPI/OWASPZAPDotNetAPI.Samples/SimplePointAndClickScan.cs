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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI.Samples
{
    class SimplePointAndClickScan
    {
        private static string _target = "http://www.renthoughtsweb.com:8020/SqliModernApp/";
        private static string _apikey = string.Empty;
        private static ClientApi _api = new ClientApi("localhost", 7070);
        private static IApiResponse _apiResponse;

        public static async Task Go()
        {
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
            var buffer = await _api.core.htmlreport(_apikey);
            File.WriteAllBytes(reportFileName + ".html", buffer);
        }

        private static async Task WriteXmlReport(string reportFileName)
        {
            var buffer = await _api.core.xmlreport(_apikey);
            File.WriteAllBytes(reportFileName + ".xml", buffer);
        }

        private static async Task PollTheActiveScannerTillCompletion(int activeScanId)
        {
            int activeScannerprogress;
            while (true)
            {
                await Task.Delay(5000);
                var scan = await _api.ascan.status(Convert.ToString(activeScanId));
                activeScannerprogress = int.Parse(((ApiResponseElement)scan).Value);
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
    }
}
