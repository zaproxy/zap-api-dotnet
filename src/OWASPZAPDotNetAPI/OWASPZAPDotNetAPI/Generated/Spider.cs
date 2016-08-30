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
	public class Spider 
	{
		private ClientApi api = null;

		public Spider(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> status(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "view", "status", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> results(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "view", "results", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> fullResults(string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "view", "fullResults", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> scans()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "scans", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> excludedFromScan()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "excludedFromScan", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionDomainsAlwaysInScope()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionDomainsAlwaysInScope", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionShowAdvancedDialog()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionShowAdvancedDialog", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionDomainsAlwaysInScopeEnabled()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionDomainsAlwaysInScopeEnabled", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionHandleParameters()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionHandleParameters", parameters);
		}

		/// <summary>
		///Sets whether or not the 'Referer' header should be sent while spidering
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionSendRefererHeader()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionSendRefererHeader", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionHandleODataParametersVisited()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionHandleODataParametersVisited", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionRequestWaitTime()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionRequestWaitTime", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionParseSitemapXml()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionParseSitemapXml", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionParseSVNEntries()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionParseSVNEntries", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionParseRobotsTxt()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionParseRobotsTxt", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionParseGit()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionParseGit", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionScopeText()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionScopeText", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionUserAgent()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionUserAgent", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionParseComments()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionParseComments", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionMaxDepth()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionMaxDepth", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionPostForm()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionPostForm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionThreadCount()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionThreadCount", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionProcessForm()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionProcessForm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionSkipURLString()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionSkipURLString", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionScope()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionScope", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> optionMaxScansInUI()
		{
			Dictionary<string, string> parameters = null;
			return await api.CallApi("spider", "view", "optionMaxScansInUI", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> scan(string apikey, string url, string maxchildren)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("url", url);
			parameters.Add("maxChildren", maxchildren);
			return await api.CallApi("spider", "action", "scan", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> scanAsUser(string apikey, string url, string contextid, string userid, string maxchildren)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("url", url);
			parameters.Add("contextId", contextid);
			parameters.Add("userId", userid);
			parameters.Add("maxChildren", maxchildren);
			return await api.CallApi("spider", "action", "scanAsUser", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> pause(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "action", "pause", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> resume(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "action", "resume", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> stop(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "action", "stop", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> removeScan(string apikey, string scanid)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("scanId", scanid);
			return await api.CallApi("spider", "action", "removeScan", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> pauseAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("spider", "action", "pauseAllScans", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> resumeAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("spider", "action", "resumeAllScans", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> stopAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("spider", "action", "stopAllScans", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> removeAllScans(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("spider", "action", "removeAllScans", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> clearExcludedFromScan(string apikey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			return await api.CallApi("spider", "action", "clearExcludedFromScan", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> excludeFromScan(string apikey, string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("regex", regex);
			return await api.CallApi("spider", "action", "excludeFromScan", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionHandleParameters(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("spider", "action", "setOptionHandleParameters", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionScopeString(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("spider", "action", "setOptionScopeString", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionSkipURLString(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("spider", "action", "setOptionSkipURLString", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionUserAgent(string apikey, string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("String", str);
			return await api.CallApi("spider", "action", "setOptionUserAgent", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionParseSVNEntries(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionParseSVNEntries", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionShowAdvancedDialog(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionShowAdvancedDialog", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionParseRobotsTxt(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionParseRobotsTxt", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionParseSitemapXml(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionParseSitemapXml", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionSendRefererHeader(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionSendRefererHeader", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionHandleODataParametersVisited(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionHandleODataParametersVisited", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionRequestWaitTime(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("spider", "action", "setOptionRequestWaitTime", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionParseGit(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionParseGit", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionPostForm(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionPostForm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionParseComments(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionParseComments", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionMaxDepth(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("spider", "action", "setOptionMaxDepth", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionThreadCount(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("spider", "action", "setOptionThreadCount", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionProcessForm(string apikey, bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Boolean", Convert.ToString(boolean));
			return await api.CallApi("spider", "action", "setOptionProcessForm", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public async Task<IApiResponse> setOptionMaxScansInUI(string apikey, int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			if (!string.IsNullOrWhiteSpace(apikey)){
				parameters.Add("apikey", apikey);
			}
			parameters.Add("Integer", Convert.ToString(i));
			return await api.CallApi("spider", "action", "setOptionMaxScansInUI", parameters);
		}

	}
}
