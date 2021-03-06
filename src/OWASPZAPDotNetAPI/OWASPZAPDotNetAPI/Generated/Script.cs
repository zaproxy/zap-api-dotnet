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
		///Lists the script types available.
		/// </summary>
		/// <returns></returns>
		public IApiResponse listTypes()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "view", "listTypes", parameters);
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
		///Gets the value of the global variable with the given key. Returns an API error (DOES_NOT_EXIST) if no value was previously set.
		/// </summary>
		/// <returns></returns>
		public IApiResponse globalVar(string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "view", "globalVar", parameters);
		}

		/// <summary>
		///Gets the value (string representation) of a global custom variable. Returns an API error (DOES_NOT_EXIST) if no value was previously set.
		/// </summary>
		/// <returns></returns>
		public IApiResponse globalCustomVar(string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "view", "globalCustomVar", parameters);
		}

		/// <summary>
		///Gets all the global variables (key/value pairs).
		/// </summary>
		/// <returns></returns>
		public IApiResponse globalVars()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "view", "globalVars", parameters);
		}

		/// <summary>
		///Gets all the global custom variables (key/value pairs, the value is the string representation).
		/// </summary>
		/// <returns></returns>
		public IApiResponse globalCustomVars()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "view", "globalCustomVars", parameters);
		}

		/// <summary>
		///Gets the value of the variable with the given key for the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists or if no value was previously set.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scriptVar(string scriptname, string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "view", "scriptVar", parameters);
		}

		/// <summary>
		///Gets the value (string representation) of a custom variable. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists or if no value was previously set.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scriptCustomVar(string scriptname, string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "view", "scriptCustomVar", parameters);
		}

		/// <summary>
		///Gets all the variables (key/value pairs) of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scriptVars(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "view", "scriptVars", parameters);
		}

		/// <summary>
		///Gets all the custom variables (key/value pairs, the value is the string representation) of a script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
		/// </summary>
		/// <returns></returns>
		public IApiResponse scriptCustomVars(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "view", "scriptCustomVars", parameters);
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
		///Runs the stand alone script with the given name
		/// </summary>
		/// <returns></returns>
		public IApiResponse runStandAloneScript(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "runStandAloneScript", parameters);
		}

		/// <summary>
		///Clears the global variable with the given key.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearGlobalVar(string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "action", "clearGlobalVar", parameters);
		}

		/// <summary>
		///Clears a global custom variable.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearGlobalCustomVar(string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "action", "clearGlobalCustomVar", parameters);
		}

		/// <summary>
		///Clears the global variables.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearGlobalVars()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("script", "action", "clearGlobalVars", parameters);
		}

		/// <summary>
		///Clears the variable with the given key of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearScriptVar(string scriptname, string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "action", "clearScriptVar", parameters);
		}

		/// <summary>
		///Clears a script custom variable.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearScriptCustomVar(string scriptname, string varkey)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("varKey", varkey);
			return api.CallApi("script", "action", "clearScriptCustomVar", parameters);
		}

		/// <summary>
		///Clears the variables of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
		/// </summary>
		/// <returns></returns>
		public IApiResponse clearScriptVars(string scriptname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			return api.CallApi("script", "action", "clearScriptVars", parameters);
		}

		/// <summary>
		///Sets the value of the variable with the given key of the given script. Returns an API error (DOES_NOT_EXIST) if no script with the given name exists.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setScriptVar(string scriptname, string varkey, string varvalue)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("scriptName", scriptname);
			parameters.Add("varKey", varkey);
			parameters.Add("varValue", varvalue);
			return api.CallApi("script", "action", "setScriptVar", parameters);
		}

		/// <summary>
		///Sets the value of the global variable with the given key.
		/// </summary>
		/// <returns></returns>
		public IApiResponse setGlobalVar(string varkey, string varvalue)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("varKey", varkey);
			parameters.Add("varValue", varvalue);
			return api.CallApi("script", "action", "setGlobalVar", parameters);
		}

	}
}
