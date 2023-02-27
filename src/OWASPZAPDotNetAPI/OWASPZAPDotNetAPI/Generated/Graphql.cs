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
	public class Graphql 
	{
		private ClientApi api = null;

		public Graphql(ClientApi api) 
		{
			this.api = api;
		}

		/// <summary>
		///Returns how arguments are currently specified.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionArgsType()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionArgsType", parameters);
		}

		/// <summary>
		///Returns whether or not lenient maximum query generation depth is enabled.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionLenientMaxQueryDepthEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionLenientMaxQueryDepthEnabled", parameters);
		}

		/// <summary>
		///Returns the current maximum additional query generation depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxAdditionalQueryDepth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionMaxAdditionalQueryDepth", parameters);
		}

		/// <summary>
		///Returns the current maximum arguments generation depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxArgsDepth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionMaxArgsDepth", parameters);
		}

		/// <summary>
		///Returns the current maximum query generation depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionMaxQueryDepth()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionMaxQueryDepth", parameters);
		}

		/// <summary>
		///Returns whether or not optional arguments are currently specified.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionOptionalArgsEnabled()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionOptionalArgsEnabled", parameters);
		}

		/// <summary>
		///Returns the current level for which a single query is generated.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionQuerySplitType()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionQuerySplitType", parameters);
		}

		/// <summary>
		///Returns the current request method.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse optionRequestMethod()
		{
			Dictionary<string, string> parameters = null;
			return api.CallApi("graphql", "view", "optionRequestMethod", parameters);
		}

		/// <summary>
		///Imports a GraphQL Schema from a File.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importFile(string endurl, string file)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("endurl", endurl);
			parameters.Add("file", file);
			return api.CallApi("graphql", "action", "importFile", parameters);
		}

		/// <summary>
		///Imports a GraphQL Schema from a URL.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse importUrl(string endurl, string url)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("endurl", endurl);
			parameters.Add("url", url);
			return api.CallApi("graphql", "action", "importUrl", parameters);
		}

		/// <summary>
		///Sets how arguments are specified.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionArgsType(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("graphql", "action", "setOptionArgsType", parameters);
		}

		/// <summary>
		///Sets the level for which a single query is generated.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionQuerySplitType(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("graphql", "action", "setOptionQuerySplitType", parameters);
		}

		/// <summary>
		///Sets the request method.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionRequestMethod(string str)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("String", str);
			return api.CallApi("graphql", "action", "setOptionRequestMethod", parameters);
		}

		/// <summary>
		///Sets whether or not Maximum Query Depth is enforced leniently.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionLenientMaxQueryDepthEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("graphql", "action", "setOptionLenientMaxQueryDepthEnabled", parameters);
		}

		/// <summary>
		///Sets the maximum additional query generation depth (used if enforced leniently).
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxAdditionalQueryDepth(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("graphql", "action", "setOptionMaxAdditionalQueryDepth", parameters);
		}

		/// <summary>
		///Sets the maximum arguments generation depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxArgsDepth(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("graphql", "action", "setOptionMaxArgsDepth", parameters);
		}

		/// <summary>
		///Sets the maximum query generation depth.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionMaxQueryDepth(int i)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Integer", Convert.ToString(i));
			return api.CallApi("graphql", "action", "setOptionMaxQueryDepth", parameters);
		}

		/// <summary>
		///Sets whether or not Optional Arguments should be specified.
		///This component is optional and therefore the API will only work if it is installed
		/// </summary>
		/// <returns></returns>
		public IApiResponse setOptionOptionalArgsEnabled(bool boolean)
		{
			Dictionary<string, string> parameters = null;
			parameters = new Dictionary<string, string>();
			parameters.Add("Boolean", Convert.ToString(boolean));
			return api.CallApi("graphql", "action", "setOptionOptionalArgsEnabled", parameters);
		}

	}
}
