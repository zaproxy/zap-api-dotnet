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
	public class Context 
	{
		private ClientApi api = null;

		public Context(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///List context names of current session
		/// </summary>
		/// <returns></returns>
		public IApiResponse contextList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("context", "view", "contextList", parameters);
		}

		/// <summary>
		///List excluded regexs for context
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeRegexs(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "excludeRegexs", parameters);
		}

		/// <summary>
		///List included regexs for context
		/// </summary>
		/// <returns></returns>
		public IApiResponse includeRegexs(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "includeRegexs", parameters);
		}

		/// <summary>
		///List the information about the named context
		/// </summary>
		/// <returns></returns>
		public IApiResponse context(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "context", parameters);
		}

		/// <summary>
		///Lists the names of all built in technologies
		/// </summary>
		/// <returns></returns>
		public IApiResponse technologyList()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("context", "view", "technologyList", parameters);
		}

		/// <summary>
		///Lists the names of all technologies included in a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse includedTechnologyList(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "includedTechnologyList", parameters);
		}

		/// <summary>
		///Lists the names of all technologies excluded from a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludedTechnologyList(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "excludedTechnologyList", parameters);
		}

		/// <summary>
		///Lists the URLs accessed through/by ZAP, that belong to the context with the given name.
		/// </summary>
		/// <returns></returns>
		public IApiResponse urls(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "view", "urls", parameters);
		}

		/// <summary>
		///Add exclude regex to context
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeFromContext(string contextname, string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("regex", regex);
			return api.CallApi("context", "action", "excludeFromContext", parameters);
		}

		/// <summary>
		///Add include regex to context
		/// </summary>
		/// <returns></returns>
		public IApiResponse includeInContext(string contextname, string regex)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("regex", regex);
			return api.CallApi("context", "action", "includeInContext", parameters);
		}

		/// <summary>
		///Set the regexs to include and exclude for a context, both supplied as JSON string arrays
		/// </summary>
		/// <returns></returns>
		public IApiResponse setContextRegexs(string contextname, string incregexs, string excregexs)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("incRegexs", incregexs);
			parameters.Add("excRegexs", excregexs);
			return api.CallApi("context", "action", "setContextRegexs", parameters);
		}

		/// <summary>
		///Set the checking strategy for a context - this defines how ZAP checks that a request is authenticated
		/// </summary>
		/// <returns></returns>
		public IApiResponse setContextCheckingStrategy(string contextname, string checkingstrategy, string pollurl, string polldata, string pollheaders, string pollfrequency, string pollfrequencyunits)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("checkingStrategy", checkingstrategy);
			parameters.Add("pollUrl", pollurl);
			parameters.Add("pollData", polldata);
			parameters.Add("pollHeaders", pollheaders);
			parameters.Add("pollFrequency", pollfrequency);
			parameters.Add("pollFrequencyUnits", pollfrequencyunits);
			return api.CallApi("context", "action", "setContextCheckingStrategy", parameters);
		}

		/// <summary>
		///Creates a new context with the given name in the current session
		/// </summary>
		/// <returns></returns>
		public IApiResponse newContext(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "action", "newContext", parameters);
		}

		/// <summary>
		///Removes a context in the current session
		/// </summary>
		/// <returns></returns>
		public IApiResponse removeContext(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "action", "removeContext", parameters);
		}

		/// <summary>
		///Exports the context with the given name to a file. If a relative file path is specified it will be resolved against the "contexts" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse exportContext(string contextname, string contextfile)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("contextFile", contextfile);
			return api.CallApi("context", "action", "exportContext", parameters);
		}

		/// <summary>
		///Imports a context from a file. If a relative file path is specified it will be resolved against the "contexts" directory in ZAP "home" dir.
		/// </summary>
		/// <returns></returns>
		public IApiResponse importContext(string contextfile)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextFile", contextfile);
			return api.CallApi("context", "action", "importContext", parameters);
		}

		/// <summary>
		///Includes technologies with the given names, separated by a comma, to a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse includeContextTechnologies(string contextname, string technologynames)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("technologyNames", technologynames);
			return api.CallApi("context", "action", "includeContextTechnologies", parameters);
		}

		/// <summary>
		///Includes all built in technologies in to a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse includeAllContextTechnologies(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "action", "includeAllContextTechnologies", parameters);
		}

		/// <summary>
		///Excludes technologies with the given names, separated by a comma, from a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeContextTechnologies(string contextname, string technologynames)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("technologyNames", technologynames);
			return api.CallApi("context", "action", "excludeContextTechnologies", parameters);
		}

		/// <summary>
		///Excludes all built in technologies from a context
		/// </summary>
		/// <returns></returns>
		public IApiResponse excludeAllContextTechnologies(string contextname)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			return api.CallApi("context", "action", "excludeAllContextTechnologies", parameters);
		}

		/// <summary>
		///Sets a context to in scope (contexts are in scope by default)
		/// </summary>
		/// <returns></returns>
		public IApiResponse setContextInScope(string contextname, string booleaninscope)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("contextName", contextname);
			parameters.Add("booleanInScope", booleaninscope);
			return api.CallApi("context", "action", "setContextInScope", parameters);
		}

	}
}
