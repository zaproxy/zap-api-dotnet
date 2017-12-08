/* Zed Attack Proxy (ZAP) and its related class files.
 *
 * ZAP is an HTTP/HTTPS proxy for assessing web application security.
 *
 * Copyright 2017 the ZAP development team
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
	public class Script 
	{
		private ClientApi api = null;

		public Script(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Lists the script engines available
		/// </summary>
		/// <returns></returns>
		public IApiResponse listEngines()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "view", "listEngines", parameters);
		}

		/// <summary>
		///Lists the scripts available, with its engine, name, description, type and error state.
		/// </summary>
		/// <returns></returns>
		public IApiResponse listScripts()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "view", "listScripts", parameters);
		}

		/// <summary>
		///Enables the script with the given name
		/// </summary>
		/// <returns></returns>
		public IApiResponse enable(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "enable", parameters);
		}

		/// <summary>
		///Disables the script with the given name
		/// </summary>
		/// <returns></returns>
		public IApiResponse disable(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "disable", parameters);
		}

		/// <summary>
		///Loads a script into ZAP from the given local file, with the given name, type and engine, optionally with a description, and a charset name to read the script (the charset name is required if the script is not in UTF-8, for example, in ISO-8859-1).
		/// </summary>
		/// <returns></returns>
		public IApiResponse load(string scriptname, string scripttype, string scriptengine, string filename, string scriptdescription, string charset)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("scriptType", scripttype);
			parameters.Add("scriptEngine", scriptengine);
			parameters.Add("fileName", filename);
			parameters.Add("scriptDescription", scriptdescription);
			parameters.Add("charset", charset);
			return api.CallApi("script", "action", "load", parameters);
		}

		/// <summary>
		///Removes the script with the given name
		/// </summary>
		/// <returns></returns>
		public IApiResponse remove(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "remove", parameters);
		}

		/// <summary>
		///Runs the stand alone script with the give name
		/// </summary>
		/// <returns></returns>
		public IApiResponse runStandAloneScript(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "runStandAloneScript", parameters);
		}

	}
}
