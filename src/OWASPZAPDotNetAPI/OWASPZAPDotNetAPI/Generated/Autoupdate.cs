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
using System.Text;
using System.Threading.Tasks;


/*
 * This file was automatically generated.
 */
namespace OWASPZAPDotNetAPI.Generated
{
	public class Autoupdate 
	{
		private ClientApi api = null;

		public Autoupdate(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> latestVersionNumber()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "latestVersionNumber", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> isLatestVersion()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "isLatestVersion", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionCheckOnStart()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionCheckOnStart", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionCheckAddonUpdates()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionCheckAddonUpdates", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionDownloadNewRelease()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionDownloadNewRelease", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionReportBetaAddons()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionReportBetaAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionReportAlphaAddons()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionReportAlphaAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionInstallScannerRules()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionInstallScannerRules", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionInstallAddonUpdates()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionInstallAddonUpdates", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionReportReleaseAddons()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("autoupdate", "view", "optionReportReleaseAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> downloadLatestRelease(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("autoupdate", "action", "downloadLatestRelease", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionCheckOnStart(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionCheckOnStart", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionReportReleaseAddons(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionReportReleaseAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionInstallScannerRules(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionInstallScannerRules", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionReportAlphaAddons(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionReportAlphaAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionReportBetaAddons(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionReportBetaAddons", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionCheckAddonUpdates(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionCheckAddonUpdates", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionInstallAddonUpdates(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionInstallAddonUpdates", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionDownloadNewRelease(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("autoupdate", "action", "setOptionDownloadNewRelease", parameters);
		}

	}
}
