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
	/// Represents a collection of functions to interact with the PI Web API Configuration controller.
	/// </summary>
	public interface IConfigurationApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Dictionary<string, Object></returns>
		Dictionary<string, Object> List();

		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<Dictionary<string, Object>></returns>
		ApiResponse<Dictionary<string, Object>> ListWithHttpInfo();

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <returns>Object</returns>
		Object Get(string key);

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> GetWithHttpInfo(string key);

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <returns>Object</returns>
		Object Delete(string key);

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteWithHttpInfo(string key);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Dictionary<string, Object>></returns>
		System.Threading.Tasks.Task<Dictionary<string, Object>> ListAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>></returns>
		System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> ListAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> GetAsync(string key, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> GetAsyncWithHttpInfo(string key, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteAsync(string key, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string key, CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class ConfigurationApi : IConfigurationApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public ConfigurationApi(Configuration configuration = null)
		{
			this.Configuration = configuration;
			ExceptionFactory = OSIsoft.PIDevClub.PIWebApiClient.Client.Configuration.DefaultExceptionFactory;
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
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>Dictionary<string, Object></returns>
		public Dictionary<string, Object> List()
		{
			ApiResponse<Dictionary<string, Object>> localVarResponse = ListWithHttpInfo();
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <returns>ApiResponse<Dictionary<string, Object>></returns>
		public ApiResponse<Dictionary<string, Object>> ListWithHttpInfo()
		{

			var localVarPath = "/system/configuration";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ListWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
				localVarResponse.Headers,
				(Dictionary<string, Object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
		}

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <returns>Object</returns>
		public Object Get(string key)
		{
			ApiResponse<Object> localVarResponse = GetWithHttpInfo(key);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> GetWithHttpInfo(string key)
		{
			// verify the required parameter 'key' is set
			if (key == null)
				throw new ApiException(400, "Missing required parameter 'key'");

			var localVarPath = "/system/configuration/{key}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (key!= null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <returns>Object</returns>
		public Object Delete(string key)
		{
			ApiResponse<Object> localVarResponse = DeleteWithHttpInfo(key);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteWithHttpInfo(string key)
		{
			// verify the required parameter 'key' is set
			if (key == null)
				throw new ApiException(400, "Missing required parameter 'key'");

			var localVarPath = "/system/configuration/{key}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (key!= null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key));
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Dictionary<string, Object>></returns>
		public async System.Threading.Tasks.Task<Dictionary<string, Object>> ListAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Dictionary<string, Object>> localVarResponse = await ListAsyncWithHttpInfo(cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the current system configuration.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Dictionary<string, Object>>> ListAsyncWithHttpInfo(CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/system/configuration";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ListAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Dictionary<string, Object>>(localVarStatusCode,
				localVarResponse.Headers,
				(Dictionary<string, Object>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Dictionary<string, Object>)));
		}

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> GetAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await GetAsyncWithHttpInfo(key, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the value of a configuration item.
		/// </summary>
		/// <remarks>
		/// The response content may vary based on the configuration item's data type.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> GetAsyncWithHttpInfo(string key, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'key' is set
			if (key == null)
				throw new ApiException(400, "Missing required parameter 'key'");

			var localVarPath = "/system/configuration/{key}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (key!= null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await DeleteAsyncWithHttpInfo(key, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a configuration item.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="key">The key of the configuration item to remove.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAsyncWithHttpInfo(string key, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'key' is set
			if (key == null)
				throw new ApiException(400, "Missing required parameter 'key'");

			var localVarPath = "/system/configuration/{key}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (key!= null) localVarPathParams.Add("key", Configuration.ApiClient.ParameterToString(key));
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
