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
	public class RuleConfig 
	{
		private ClientApi api = null;

		public RuleConfig(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Show the specified rule configuration
		/// </summary>
		/// <returns></returns>
		public IApiResponse ruleConfigValue(string key)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("key", key);
			return api.CallApi("ruleConfig", "view", "ruleConfigValue", parameters);
		}

		/// <summary>
		///Show all of the rule configurations
		/// </summary>
		/// <returns></returns>
		public IApiResponse allRuleConfigs()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ruleConfig", "view", "allRuleConfigs", parameters);
		}

		/// <summary>
		///Reset the specified rule configuration, which must already exist
		/// </summary>
		/// <returns></returns>
		public IApiResponse resetRuleConfigValue(string key)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("key", key);
			return api.CallApi("ruleConfig", "action", "resetRuleConfigValue", parameters);
		}

		/// <summary>
		///Reset all of the rule configurations
		/// </summary>
		/// <returns></returns>
		public IApiResponse resetAllRuleConfigValues()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("ruleConfig", "action", "resetAllRuleConfigValues", parameters);
		}

		/// <summary>
		///Set the specified rule configuration, which must already exist
		/// </summary>
		/// <returns></returns>
		public IApiResponse setRuleConfigValue(string key, string value)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("key", key);
			parameters.Add("value", value);
			return api.CallApi("ruleConfig", "action", "setRuleConfigValue", parameters);
		}

	}
}
