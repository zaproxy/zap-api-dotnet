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
	public class Reports 
	{
		private ClientApi api = null;

		public Reports(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///View available templates.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse templates()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("reports", "view", "templates", parameters);
		}

		/// <summary>
		///View details of the specified template.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse templateDetails(string template)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("template", template);
			return api.CallApi("reports", "view", "templateDetails", parameters);
		}

		/// <summary>
		///Generate a report with the supplied parameters.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse generate(string title, string template, string theme, string description, string contexts, string sites, string sections, string includedconfidences, string includedrisks, string reportfilename, string reportfilenamepattern, string reportdir, string display)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("title", title);
			parameters.Add("template", template);
			parameters.Add("theme", theme);
			parameters.Add("description", description);
			parameters.Add("contexts", contexts);
			parameters.Add("sites", sites);
			parameters.Add("sections", sections);
			parameters.Add("includedConfidences", includedconfidences);
			parameters.Add("includedRisks", includedrisks);
			parameters.Add("reportFileName", reportfilename);
			parameters.Add("reportFileNamePattern", reportfilenamepattern);
			parameters.Add("reportDir", reportdir);
			parameters.Add("display", display);
			return api.CallApi("reports", "action", "generate", parameters);
		}

	}
}
