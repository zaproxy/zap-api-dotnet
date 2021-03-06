# zap-api-dotnet
OWASP ZAP Dot NET API

  * Nuget package downloadable at [OWASPZAPDotNetAPI](https://www.nuget.org/packages/OWASPZAPDotNetAPI)
  * Nuget package manager command 
  ```bat
Install-Package OWASPZAPDotNetAPI -Version 2.10.0	
```

Samples and how to:

 * Simple point and click scan - [SimplePointAndClickScan.cs](https://github.com/zaproxy/zap-api-dotnet/blob/master/src/OWASPZAPDotNetAPI/OWASPZAPDotNetAPI.Samples/SimplePointAndClickScan.cs)
 
 * Authenticated scan - [AuthenticatedScanWithFormsAuthentication.cs](https://github.com/zaproxy/zap-api-dotnet/blob/master/src/OWASPZAPDotNetAPI/OWASPZAPDotNetAPI.Samples/AuthenticatedScanWithFormsAuthentication.cs)


Although the target framework for this dll is .Net framework 4.5, you could also use the library from a .Net core application.


In case of TLS errors, [try](https://github.com/zaproxy/zap-api-dotnet/blob/master/src/OWASPZAPDotNetAPI/OWASPZAPDotNetAPI.Samples/Program.cs):  
```csharp
        private static void ConfigureTLSSettingsForDotNet45()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls
                   | SecurityProtocolType.Tls11
                   | SecurityProtocolType.Tls12
                   | SecurityProtocolType.Ssl3;
        }
```