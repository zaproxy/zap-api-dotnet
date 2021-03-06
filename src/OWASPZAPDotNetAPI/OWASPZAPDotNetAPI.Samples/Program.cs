using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigureTLSSettingsForDotNet45();
            ZAP.StartZapUI();
            //ZAP.StartZAPDaemon();
            //SimplePointAndClickScan.Go();
            AuthenticatedScanWithFormsAuthentication.Go();
        }

        private static void ConfigureTLSSettingsForDotNet45()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;
        }
    }
}
