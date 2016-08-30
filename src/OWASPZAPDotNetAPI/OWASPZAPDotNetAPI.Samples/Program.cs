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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI.Samples
{
    class Program
    {
        static async Task AsyncMain(string[] args)
        {
            await Console.Out.WriteLineAsync("ZAP.StartZapUI() helps you get started on how to start ZAP UI (that is the ZAP Desktop)" + Environment.NewLine);
            //await ZAP.StartZapUI();
            await Console.Out.WriteLineAsync("ZAP.StartZAPDaemon() helps you get started on how to start ZAP in daemon mode (that is the headless mode - without the UI)" + Environment.NewLine);
            //await ZAP.StartZAPDaemon();
            await Console.Out.WriteLineAsync("SimplePointAndClickScan.Go() helps you get started on scanning a website just by providing a URL" + Environment.NewLine);
            //await SimplePointAndClickScan.Go();
            await Console.Out.WriteLineAsync("AuthenticatedScanWithFormsAuthentication.Go() helps you get started on scanning a website that has a Login page and uses Forms based authentication" + Environment.NewLine);
            //await AuthenticatedScanWithFormsAuthentication.Go();
            await Console.Out.WriteLineAsync("More samples enroute" + Environment.NewLine);
        }

        static void Main(string[] args)
        {
            AsyncHelper.RunSync(() => AsyncMain(args));
        }
    }
}
