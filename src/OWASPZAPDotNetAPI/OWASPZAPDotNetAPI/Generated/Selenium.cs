/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2019 the ZAP development team
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
	public class Selenium 
	{
		private ClientApi api = null;

		public Selenium(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns the current path to ChromeDriver
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionChromeDriverPath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("selenium", "view", "optionChromeDriverPath", parameters);
		}

		/// <summary>
		///Returns the current path to Firefox binary
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionFirefoxBinaryPath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("selenium", "view", "optionFirefoxBinaryPath", parameters);
		}

		/// <summary>
		///Returns the current path to Firefox driver (geckodriver)
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionFirefoxDriverPath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("selenium", "view", "optionFirefoxDriverPath", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse optionIeDriverPath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("selenium", "view", "optionIeDriverPath", parameters);
		}

		/// <summary>
		///Returns the current path to PhantomJS binary
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionPhantomJsBinaryPath()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("selenium", "view", "optionPhantomJsBinaryPath", parameters);
		}

		/// <summary>
		///Sets the current path to ChromeDriver
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionChromeDriverPath(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("selenium", "action", "setOptionChromeDriverPath", parameters);
		}

		/// <summary>
		///Sets the current path to Firefox binary
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionFirefoxBinaryPath(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("selenium", "action", "setOptionFirefoxBinaryPath", parameters);
		}

		/// <summary>
		///Sets the current path to Firefox driver (geckodriver)
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionFirefoxDriverPath(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("selenium", "action", "setOptionFirefoxDriverPath", parameters);
		}

		/// <summary>
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		[Obsolete]
		public IApiResponse setOptionIeDriverPath(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("selenium", "action", "setOptionIeDriverPath", parameters);
		}

		/// <summary>
		///Sets the current path to PhantomJS binary
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionPhantomJsBinaryPath(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("selenium", "action", "setOptionPhantomJsBinaryPath", parameters);
		}

	}
}
