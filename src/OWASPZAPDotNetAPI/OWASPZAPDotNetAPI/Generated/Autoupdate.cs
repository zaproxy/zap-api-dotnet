/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2021 the ZAP development team
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
	public class Autoupdate 
	{
		private ClientApi api = null;

		public Autoupdate(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns the latest version number
		/// </summary>
		/// <returns></returns>
		public IApiResponse latestVersionNumber()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "latestVersionNumber", parameters);
		}

		/// <summary>
		///Returns 'true' if ZAP is on the latest version
		/// </summary>
		/// <returns></returns>
		public IApiResponse isLatestVersion()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "isLatestVersion", parameters);
		}

		/// <summary>
		///Return a list of all of the installed add-ons
		/// </summary>
		/// <returns></returns>
		public IApiResponse installedAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "installedAddons", parameters);
		}

		/// <summary>
		///Returns a list with all local add-ons, installed or not.
		/// </summary>
		/// <returns></returns>
		public IApiResponse localAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "localAddons", parameters);
		}

		/// <summary>
		///Return a list of any add-ons that have been added to the Marketplace since the last check for updates
		/// </summary>
		/// <returns></returns>
		public IApiResponse newAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "newAddons", parameters);
		}

		/// <summary>
		///Return a list of any add-ons that have been changed in the Marketplace since the last check for updates
		/// </summary>
		/// <returns></returns>
		public IApiResponse updatedAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "updatedAddons", parameters);
		}

		/// <summary>
		///Return a list of all of the add-ons on the ZAP Marketplace (this information is read once and then cached)
		/// </summary>
		/// <returns></returns>
		public IApiResponse marketplaceAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "marketplaceAddons", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionAddonDirectories()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionAddonDirectories", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDayLastChecked()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionDayLastChecked", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDayLastInstallWarned()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionDayLastInstallWarned", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDayLastUpdateWarned()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionDayLastUpdateWarned", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDownloadDirectory()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionDownloadDirectory", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionCheckAddonUpdates()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionCheckAddonUpdates", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionCheckOnStart()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionCheckOnStart", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionDownloadNewRelease()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionDownloadNewRelease", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionInstallAddonUpdates()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionInstallAddonUpdates", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionInstallScannerRules()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionInstallScannerRules", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionReportAlphaAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionReportAlphaAddons", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionReportBetaAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionReportBetaAddons", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionReportReleaseAddons()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "view", "optionReportReleaseAddons", parameters);
		}

		/// <summary>
		///Downloads the latest release, if any 
		/// </summary>
		/// <returns></returns>
		public IApiResponse downloadLatestRelease()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("autoupdate", "action", "downloadLatestRelease", parameters);
		}

		/// <summary>
		///Installs or updates the specified add-on, returning when complete (i.e. not asynchronously)
		/// </summary>
		/// <returns></returns>
		public IApiResponse installAddon(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("autoupdate", "action", "installAddon", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse installLocalAddon(string file)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("file", file);
			return api.CallApi("autoupdate", "action", "installLocalAddon", parameters);
		}

		/// <summary>
		///Uninstalls the specified add-on 
		/// </summary>
		/// <returns></returns>
		public IApiResponse uninstallAddon(string id)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("id", id);
			return api.CallApi("autoupdate", "action", "uninstallAddon", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionCheckAddonUpdates(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionCheckAddonUpdates", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionCheckOnStart(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionCheckOnStart", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionDownloadNewRelease(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionDownloadNewRelease", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionInstallAddonUpdates(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionInstallAddonUpdates", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionInstallScannerRules(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionInstallScannerRules", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionReportAlphaAddons(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionReportAlphaAddons", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionReportBetaAddons(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionReportBetaAddons", parameters);
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionReportReleaseAddons(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("autoupdate", "action", "setOptionReportReleaseAddons", parameters);
		}

	}
}
