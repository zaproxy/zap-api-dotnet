/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2023 the ZAP development team
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
using System.Text;


/*
 * This file was automatically generated.
 */
namespace OWASPZAPDotNetAPI.Generated
{
	public class Network 
	{
		private ClientApi api = null;

		public Network(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets the Root CA certificate validity, in days. Used when generating a new Root CA certificate.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getRootCaCertValidity()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getRootCaCertValidity", parameters);
		}

		/// <summary>
		///Gets the server certificate validity, in days. Used when generating server certificates.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getServerCertValidity()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getServerCertValidity", parameters);
		}

		/// <summary>
		///Gets the aliases used to identify the local servers/proxies.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getAliases()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getAliases", parameters);
		}

		/// <summary>
		///Gets the local servers/proxies.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getLocalServers()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getLocalServers", parameters);
		}

		/// <summary>
		///Gets the authorities that will pass-through the local proxies.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getPassThroughs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getPassThroughs", parameters);
		}

		/// <summary>
		///Gets the connection timeout, in seconds.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getConnectionTimeout()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getConnectionTimeout", parameters);
		}

		/// <summary>
		///Gets the default user-agent.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getDefaultUserAgent()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getDefaultUserAgent", parameters);
		}

		/// <summary>
		///Gets the TTL (in seconds) of successful DNS queries.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getDnsTtlSuccessfulQueries()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getDnsTtlSuccessfulQueries", parameters);
		}

		/// <summary>
		///Gets the HTTP proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getHttpProxy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getHttpProxy", parameters);
		}

		/// <summary>
		///Gets the HTTP proxy exclusions.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getHttpProxyExclusions()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getHttpProxyExclusions", parameters);
		}

		/// <summary>
		///Gets the SOCKS proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse getSocksProxy()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "getSocksProxy", parameters);
		}

		/// <summary>
		///Tells whether or not the HTTP proxy authentication is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse isHttpProxyAuthEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "isHttpProxyAuthEnabled", parameters);
		}

		/// <summary>
		///Tells whether or not the HTTP proxy is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse isHttpProxyEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "isHttpProxyEnabled", parameters);
		}

		/// <summary>
		///Tells whether or not the SOCKS proxy is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse isSocksProxyEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "isSocksProxyEnabled", parameters);
		}

		/// <summary>
		///Tells whether or not to use global HTTP state.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse isUseGlobalHttpState()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "view", "isUseGlobalHttpState", parameters);
		}

		/// <summary>
		///Generates a new Root CA certificate, used to issue server certificates.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse generateRootCaCert()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("network", "action", "generateRootCaCert", parameters);
		}

		/// <summary>
		///Imports a Root CA certificate to be used to issue server certificates.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importRootCaCert(string filepath)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			return api.CallApi("network", "action", "importRootCaCert", parameters);
		}

		/// <summary>
		///Sets the Root CA certificate validity. Used when generating a new Root CA certificate.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setRootCaCertValidity(string validity)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("validity", validity);
			return api.CallApi("network", "action", "setRootCaCertValidity", parameters);
		}

		/// <summary>
		///Sets the server certificate validity. Used when generating server certificates.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setServerCertValidity(string validity)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("validity", validity);
			return api.CallApi("network", "action", "setServerCertValidity", parameters);
		}

		/// <summary>
		///Adds an alias for the local servers/proxies.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addAlias(string name, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "addAlias", parameters);
		}

		/// <summary>
		///Adds a local server/proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addLocalServer(string address, string port, string api, string proxy, string behindnat, string decoderesponse, string removeacceptencoding)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("address", address);
			parameters.Add("port", port);
			parameters.Add("api", api);
			parameters.Add("proxy", proxy);
			parameters.Add("behindNat", behindnat);
			parameters.Add("decodeResponse", decoderesponse);
			parameters.Add("removeAcceptEncoding", removeacceptencoding);
			return this.api.CallApi("network", "action", "addLocalServer", parameters);
		}

		/// <summary>
		///Adds an authority to pass-through the local proxies.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addPassThrough(string authority, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("authority", authority);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "addPassThrough", parameters);
		}

		/// <summary>
		///Removes an alias.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeAlias(string name)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			return api.CallApi("network", "action", "removeAlias", parameters);
		}

		/// <summary>
		///Removes a local server/proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeLocalServer(string address, string port)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("address", address);
			parameters.Add("port", port);
			return api.CallApi("network", "action", "removeLocalServer", parameters);
		}

		/// <summary>
		///Removes a pass-through.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removePassThrough(string authority)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("authority", authority);
			return api.CallApi("network", "action", "removePassThrough", parameters);
		}

		/// <summary>
		///Sets whether or not an alias is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setAliasEnabled(string name, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("name", name);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setAliasEnabled", parameters);
		}

		/// <summary>
		///Sets whether or not a pass-through is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setPassThroughEnabled(string authority, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("authority", authority);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setPassThroughEnabled", parameters);
		}

		/// <summary>
		///Sets the timeout, for reads and connects.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setConnectionTimeout(string timeout)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("timeout", timeout);
			return api.CallApi("network", "action", "setConnectionTimeout", parameters);
		}

		/// <summary>
		///Sets the default user-agent.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setDefaultUserAgent(string useragent)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("userAgent", useragent);
			return api.CallApi("network", "action", "setDefaultUserAgent", parameters);
		}

		/// <summary>
		///Sets the TTL of successful DNS queries.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setDnsTtlSuccessfulQueries(string ttl)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("ttl", ttl);
			return api.CallApi("network", "action", "setDnsTtlSuccessfulQueries", parameters);
		}

		/// <summary>
		///Adds a host to be excluded from the HTTP proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addHttpProxyExclusion(string host, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("host", host);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "addHttpProxyExclusion", parameters);
		}

		/// <summary>
		///Removes an HTTP proxy exclusion.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeHttpProxyExclusion(string host)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("host", host);
			return api.CallApi("network", "action", "removeHttpProxyExclusion", parameters);
		}

		/// <summary>
		///Sets the HTTP proxy configuration.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setHttpProxy(string host, string port, string realm, string username, string password)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("host", host);
			parameters.Add("port", port);
			parameters.Add("realm", realm);
			parameters.Add("username", username);
			parameters.Add("password", password);
			return api.CallApi("network", "action", "setHttpProxy", parameters);
		}

		/// <summary>
		///Sets whether or not the HTTP proxy authentication is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setHttpProxyAuthEnabled(string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setHttpProxyAuthEnabled", parameters);
		}

		/// <summary>
		///Sets whether or not the HTTP proxy is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setHttpProxyEnabled(string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setHttpProxyEnabled", parameters);
		}

		/// <summary>
		///Sets whether or not an HTTP proxy exclusion is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setHttpProxyExclusionEnabled(string host, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("host", host);
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setHttpProxyExclusionEnabled", parameters);
		}

		/// <summary>
		///Sets the SOCKS proxy configuration.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setSocksProxy(string host, string port, string version, string usedns, string username, string password)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("host", host);
			parameters.Add("port", port);
			parameters.Add("version", version);
			parameters.Add("useDns", usedns);
			parameters.Add("username", username);
			parameters.Add("password", password);
			return api.CallApi("network", "action", "setSocksProxy", parameters);
		}

		/// <summary>
		///Sets whether or not the SOCKS proxy is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setSocksProxyEnabled(string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("enabled", enabled);
			return api.CallApi("network", "action", "setSocksProxyEnabled", parameters);
		}

		/// <summary>
		///Sets whether or not to use the global HTTP state.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setUseGlobalHttpState(string use)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("use", use);
			return api.CallApi("network", "action", "setUseGlobalHttpState", parameters);
		}

		/// <summary>
		///Adds a client certificate contained in a PKCS#12 file, the certificate is automatically set as active and used.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addPkcs12ClientCertificate(string filepath, string password, string index)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("filePath", filepath);
			parameters.Add("password", password);
			parameters.Add("index", index);
			return api.CallApi("network", "action", "addPkcs12ClientCertificate", parameters);
		}

		/// <summary>
		///Sets whether or not to use the active client certificate.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setUseClientCertificate(string use)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("use", use);
			return api.CallApi("network", "action", "setUseClientCertificate", parameters);
		}

		/// <summary>
		///Provides a PAC file, proxying through the main proxy.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] proxypac()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("network", "other", "proxy.pac", parameters);
		}

		/// <summary>
		///Sets the HTTP proxy configuration.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] setProxy(string proxy)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("proxy", proxy);
			return api.CallApiOther("network", "other", "setProxy", parameters);
		}

		/// <summary>
		///Gets the Root CA certificate used to issue server certificates. Suitable to import into client applications (e.g. browsers).
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public byte[] rootCaCert()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApiOther("network", "other", "rootCaCert", parameters);
		}

	}
}
