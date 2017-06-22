using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OWASPZAPDotNetAPI.Samples
{
    /// <summary>
    /// Samples to start the OWASP Zed Attack Proxy
    /// Refer to the command line options at https://github.com/zaproxy/zap-core-help/wiki/HelpCmdline
    /// </summary>
    public static class ZAP
    {
        public static void StartZapUI()
        {
            Console.WriteLine("Trying to StartZapUI");
            ProcessStartInfo zapProcessStartInfo = new ProcessStartInfo();
            zapProcessStartInfo.FileName = @"C:\Program Files\OWASP\Zed Attack Proxy\ZAP.exe";
            zapProcessStartInfo.WorkingDirectory = @"C:\Program Files\OWASP\Zed Attack Proxy";

            Console.WriteLine(zapProcessStartInfo.ToString());
            Console.WriteLine("Issuing command to StartZapUI");
            Process zap = Process.Start(zapProcessStartInfo);

            //Sleep(120000);
            CheckIfZAPHasStartedByPollingTheAPI(1);
        }

        public static void StartZAPDaemon()
        {
            Console.WriteLine("Trying to StartZAPDaemon");
            ProcessStartInfo zapProcessStartInfo = new ProcessStartInfo();
            zapProcessStartInfo.FileName = @"C:\Program Files (x86)\OWASP\Zed Attack Proxy\ZAP.exe";
            zapProcessStartInfo.WorkingDirectory = @"C:\Program Files (x86)\OWASP\Zed Attack Proxy";
            zapProcessStartInfo.Arguments = "-daemon -host 127.0.0.1 -port 7070";

            Console.WriteLine("Issuing command to StartZAPDaemon");
            Console.WriteLine(zapProcessStartInfo.ToString());
            Process zap = Process.Start(zapProcessStartInfo);

            //Sleep(120000);
            CheckIfZAPHasStartedByPollingTheAPI(1);
        }

        private static void Sleep(int sleepTime)
        {
            Console.WriteLine("Sleeping for {0} minutes", sleepTime / 1000);
            Thread.Sleep(sleepTime);
        }

        public static void CheckIfZAPHasStartedByPollingTheAPI(int minutesToWait)
        {
            WebClient webClient = new WebClient();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int millisecondsToWait = minutesToWait * 60 * 1000;
            string zapUrlToDownload = "http://localhost:7070";

            while (millisecondsToWait > watch.ElapsedMilliseconds)
            {
                try
                {
                    Console.WriteLine("Trying to check if ZAP has started by accessing the ZAP API at {0}", zapUrlToDownload);
                    string responseString = webClient.DownloadString(zapUrlToDownload);
                    Console.WriteLine(Environment.NewLine + responseString + Environment.NewLine);
                    Console.WriteLine("Obtained a response from the ZAP API at {0} {1}Hence assuming that ZAP started successfully", zapUrlToDownload, Environment.NewLine);
                    return;
                }
                catch (WebException webException)
                {
                    Console.WriteLine("Seems like ZAP did not start yet");
                    Console.WriteLine(webException.Message + Environment.NewLine);
                    Console.WriteLine("Sleeping for 2 seconds");
                    Thread.Sleep(2000);
                } 
            }

            throw new Exception(string.Format("Waited for {0} minute(s), however could not access the API successfully, hence could not verify if ZAP started successfully or not", minutesToWait));
        }

    }
}
