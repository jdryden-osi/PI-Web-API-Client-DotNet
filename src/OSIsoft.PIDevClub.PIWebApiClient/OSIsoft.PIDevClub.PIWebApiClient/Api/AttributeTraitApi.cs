// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Linq;
using OSIsoft.PIDevClub.PIWebApiClient.Client;
using OSIsoft.PIDevClub.PIWebApiClient.Model;

namespace OSIsoft.PIDevClub.PIWebApiClient.Api
{


	/// <summary>
	/// Represents a collection of functions to interact with the PI Web API AttributeTrait controller.
	/// </summary>
	public interface IAttributeTraitApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsAttributeTrait</returns>
		PIItemsAttributeTrait GetByCategory(List<string> category, string selectedFields = null);

		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsAttributeTrait></returns>
		ApiResponse<PIItemsAttributeTrait> GetByCategoryWithHttpInfo(List<string> category, string selectedFields = null);

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIAttributeTrait</returns>
		PIAttributeTrait Get(string name, string selectedFields = null);

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIAttributeTrait></returns>
		ApiResponse<PIAttributeTrait> GetWithHttpInfo(string name, string selectedFields = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttributeTrait></returns>
		System.Threading.Tasks.Task<PIItemsAttributeTrait> GetByCategoryAsync(List<string> category, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeTrait>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeTrait>> GetByCategoryAsyncWithHttpInfo(List<string> category, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAttributeTrait></returns>
		System.Threading.Tasks.Task<PIAttributeTrait> GetAsync(string name, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAttributeTrait>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAttributeTrait>> GetAsyncWithHttpInfo(string name, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class AttributeTraitApi : IAttributeTraitApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AttributeTraitApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

		public Configuration Configuration { get; set; }

		public OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory ExceptionFactory
		{
			get
			{
				if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
				{
					throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
				}
				return _exceptionFactory;
			}
			set { _exceptionFactory = value; }
		}

		#region Synchronous Operations
		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIItemsAttributeTrait</returns>
		public PIItemsAttributeTrait GetByCategory(List<string> category, string selectedFields = null)
		{
			ApiResponse<PIItemsAttributeTrait> localVarResponse = GetByCategoryWithHttpInfo(category, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIItemsAttributeTrait></returns>
		public ApiResponse<PIItemsAttributeTrait> GetByCategoryWithHttpInfo(List<string> category, string selectedFields = null)
		{
			// verify the required parameter 'category' is set
			if (category == null)
				throw new ApiException(400, "Missing required parameter 'category'");

			var localVarPath = "/attributetraits";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (category!= null) localVarQueryParams.Add("category", category, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByCategoryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttributeTrait>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttributeTrait)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeTrait)));
		}

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>PIAttributeTrait</returns>
		public PIAttributeTrait Get(string name, string selectedFields = null)
		{
			ApiResponse<PIAttributeTrait> localVarResponse = GetWithHttpInfo(name, selectedFields);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <returns>ApiResponse<PIAttributeTrait></returns>
		public ApiResponse<PIAttributeTrait> GetWithHttpInfo(string name, string selectedFields = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");

			var localVarPath = "/attributetraits/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAttributeTrait>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAttributeTrait)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAttributeTrait)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAttributeTrait></returns>
		public async System.Threading.Tasks.Task<PIItemsAttributeTrait> GetByCategoryAsync(List<string> category, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAttributeTrait> localVarResponse = await GetByCategoryAsyncWithHttpInfo(category, selectedFields, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve all attribute traits of the specified category/categories.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="category">The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeTrait>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAttributeTrait>> GetByCategoryAsyncWithHttpInfo(List<string> category, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'category' is set
			if (category == null)
				throw new ApiException(400, "Missing required parameter 'category'");

			var localVarPath = "/attributetraits";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (category!= null) localVarQueryParams.Add("category", category, true);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByCategoryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAttributeTrait>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAttributeTrait)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAttributeTrait)));
		}

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAttributeTrait></returns>
		public async System.Threading.Tasks.Task<PIAttributeTrait> GetAsync(string name, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAttributeTrait> localVarResponse = await GetAsyncWithHttpInfo(name, selectedFields, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an attribute trait.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name or abbreviation of the attribute trait.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAttributeTrait>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAttributeTrait>> GetAsyncWithHttpInfo(string name, string selectedFields = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");

			var localVarPath = "/attributetraits/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAttributeTrait>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAttributeTrait)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAttributeTrait)));
		}

		#endregion
	}
}
