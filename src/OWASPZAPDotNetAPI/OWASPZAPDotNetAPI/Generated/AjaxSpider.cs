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
	public class AjaxSpider 
	{
		private ClientApi api = null;

		public AjaxSpider(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Gets the allowed resources. The allowed resources are always fetched even if out of scope, allowing to include necessary resources (e.g. scripts) from 3rd-parties.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse allowedResources()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "allowedResources", parameters);
		}

		/// <summary>
		///Gets the current status of the crawler. Actual values are Stopped and Running.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse status()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "status", parameters);
		}

		/// <summary>
		///Gets the current results of the crawler.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse results(string start, string count)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("start", start);
			parameters.Add("count", count);
			return api.CallApi("ajaxSpider", "view", "results", parameters);
		}

		/// <summary>
		///Gets the number of resources found.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse numberOfResults()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "numberOfResults", parameters);
		}

		/// <summary>
		///Gets the full crawled content detected by the AJAX Spider. Returns a set of values based on 'inScope' URLs, 'outOfScope' URLs, and 'errors' encountered during the last/current run of the AJAX Spider.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse fullResults()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "fullResults", parameters);
		}

		/// <summary>
		///Gets the configured browser to use for crawling.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionBrowserId()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionBrowserId", parameters);
		}

		/// <summary>
		///Gets the time to wait after an event (in milliseconds). For example: the wait delay after the cursor hovers over an element, in order for a menu to display, etc.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionEventWait()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionEventWait", parameters);
		}

		/// <summary>
		///Gets the configured value for the max crawl depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxCrawlDepth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionMaxCrawlDepth", parameters);
		}

		/// <summary>
		///Gets the configured value for the maximum crawl states allowed.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxCrawlStates()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionMaxCrawlStates", parameters);
		}

		/// <summary>
		///Gets the configured max duration of the crawl, the value is in minutes.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxDuration()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionMaxDuration", parameters);
		}

		/// <summary>
		///Gets the configured number of browsers to be used.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionNumberOfBrowsers()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionNumberOfBrowsers", parameters);
		}

		/// <summary>
		///Gets the configured time to wait after reloading the page, this value is in milliseconds.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionReloadWait()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionReloadWait", parameters);
		}

		/// <summary>
		///Gets the configured value for 'Click Default Elements Only', HTML elements such as 'a', 'button', 'input', all associated with some action or links on the page.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionClickDefaultElems()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionClickDefaultElems", parameters);
		}

		/// <summary>
		///Gets the value configured for the AJAX Spider to know if it should click on the elements only once.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionClickElemsOnce()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionClickElemsOnce", parameters);
		}

		/// <summary>
		///Gets if the AJAX Spider will use random values in form fields when crawling, if set to true.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionRandomInputs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "view", "optionRandomInputs", parameters);
		}

		/// <summary>
		///Runs the AJAX Spider against a given target.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse scan(string url, string inscope, string contextname, string subtreeonly)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("url", url);
			parameters.Add("inScope", inscope);
			parameters.Add("contextName", contextname);
			parameters.Add("subtreeOnly", subtreeonly);
			return api.CallApi("ajaxSpider", "action", "scan", parameters);
		}

		/// <summary>
		///Runs the AJAX Spider from the perspective of a User of the web application.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse scanAsUser(string contextname, string username, string url, string subtreeonly)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("userName", username);
			parameters.Add("url", url);
			parameters.Add("subtreeOnly", subtreeonly);
			return api.CallApi("ajaxSpider", "action", "scanAsUser", parameters);
		}

		/// <summary>
		///Stops the AJAX Spider.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse stop()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ajaxSpider", "action", "stop", parameters);
		}

		/// <summary>
		///Adds an allowed resource.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse addAllowedResource(string regex, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("enabled", enabled);
			return api.CallApi("ajaxSpider", "action", "addAllowedResource", parameters);
		}

		/// <summary>
		///Removes an allowed resource.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeAllowedResource(string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			return api.CallApi("ajaxSpider", "action", "removeAllowedResource", parameters);
		}

		/// <summary>
		///Sets whether or not an allowed resource is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setEnabledAllowedResource(string regex, string enabled)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("regex", regex);
			parameters.Add("enabled", enabled);
			return api.CallApi("ajaxSpider", "action", "setEnabledAllowedResource", parameters);
		}

		/// <summary>
		///Sets the configuration of the AJAX Spider to use one of the supported browsers.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionBrowserId(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("ajaxSpider", "action", "setOptionBrowserId", parameters);
		}

		/// <summary>
		///Sets whether or not the the AJAX Spider will only click on the default HTML elements.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionClickDefaultElems(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ajaxSpider", "action", "setOptionClickDefaultElems", parameters);
		}

		/// <summary>
		///When enabled, the crawler attempts to interact with each element (e.g., by clicking) only once.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionClickElemsOnce(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ajaxSpider", "action", "setOptionClickElemsOnce", parameters);
		}

		/// <summary>
		///Sets the time to wait after an event (in milliseconds). For example: the wait delay after the cursor hovers over an element, in order for a menu to display, etc.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionEventWait(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionEventWait", parameters);
		}

		/// <summary>
		///Sets the maximum depth that the crawler can reach.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxCrawlDepth(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionMaxCrawlDepth", parameters);
		}

		/// <summary>
		///Sets the maximum number of states that the crawler should crawl.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxCrawlStates(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionMaxCrawlStates", parameters);
		}

		/// <summary>
		///The maximum time that the crawler is allowed to run.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxDuration(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionMaxDuration", parameters);
		}

		/// <summary>
		///Sets the number of windows to be used by AJAX Spider.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionNumberOfBrowsers(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionNumberOfBrowsers", parameters);
		}

		/// <summary>
		///When enabled, inserts random values into form fields.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionRandomInputs(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("ajaxSpider", "action", "setOptionRandomInputs", parameters);
		}

		/// <summary>
		///Sets the time to wait after the page is loaded before interacting with it.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionReloadWait(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("ajaxSpider", "action", "setOptionReloadWait", parameters);
		}

	}
}
