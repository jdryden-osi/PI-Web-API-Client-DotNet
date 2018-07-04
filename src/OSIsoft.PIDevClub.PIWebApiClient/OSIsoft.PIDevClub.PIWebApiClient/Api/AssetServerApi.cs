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
	/// Represents a collection of functions to interact with the PI Web API AssetServer controller.
	/// </summary>
	public interface IAssetServerApi
	{
		#region Synchronous Operations
		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAssetServer</returns>
		PIItemsAssetServer List(string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAssetServer></returns>
		ApiResponse<PIItemsAssetServer> ListWithHttpInfo(string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		PIAssetServer GetByName(string name, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		ApiResponse<PIAssetServer> GetByNameWithHttpInfo(string name, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		PIAssetServer GetByPath(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		ApiResponse<PIAssetServer> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		PIAssetServer Get(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		ApiResponse<PIAssetServer> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisRulePlugIn</returns>
		PIItemsAnalysisRulePlugIn GetAnalysisRulePlugIns(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisRulePlugIn></returns>
		ApiResponse<PIItemsAnalysisRulePlugIn> GetAnalysisRulePlugInsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAssetDatabase</returns>
		PIItemsAssetDatabase GetDatabases(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAssetDatabase></returns>
		ApiResponse<PIItemsAssetDatabase> GetDatabasesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateAssetDatabase(string webId, PIAssetDatabase database, string webIdType = null);

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateAssetDatabaseWithHttpInfo(string webId, PIAssetDatabase database, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationContactTemplate</returns>
		PIItemsNotificationContactTemplate GetNotificationContactTemplates(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationContactTemplate></returns>
		ApiResponse<PIItemsNotificationContactTemplate> GetNotificationContactTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityRights</returns>
		PIItemsSecurityRights GetSecurity(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityEntry</returns>
		PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null);

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PISecurityEntry</returns>
		PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>Object</returns>
		Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>Object</returns>
		Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null);

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityIdentity</returns>
		PIItemsSecurityIdentity GetSecurityIdentities(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityIdentity></returns>
		ApiResponse<PIItemsSecurityIdentity> GetSecurityIdentitiesWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateSecurityIdentity(string webId, PISecurityIdentity securityIdentity, string webIdType = null);

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityIdentityWithHttpInfo(string webId, PISecurityIdentity securityIdentity, string webIdType = null);

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityIdentity</returns>
		PIItemsSecurityIdentity GetSecurityIdentitiesForUser(string webId, string userIdentity, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityIdentity></returns>
		ApiResponse<PIItemsSecurityIdentity> GetSecurityIdentitiesForUserWithHttpInfo(string webId, string userIdentity, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityMapping</returns>
		PIItemsSecurityMapping GetSecurityMappings(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityMapping></returns>
		ApiResponse<PIItemsSecurityMapping> GetSecurityMappingsWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null);

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateSecurityMapping(string webId, PISecurityMapping securityMapping, string webIdType = null);

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateSecurityMappingWithHttpInfo(string webId, PISecurityMapping securityMapping, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTimeRulePlugIn</returns>
		PIItemsTimeRulePlugIn GetTimeRulePlugIns(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTimeRulePlugIn></returns>
		ApiResponse<PIItemsTimeRulePlugIn> GetTimeRulePlugInsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsUnitClass</returns>
		PIItemsUnitClass GetUnitClasses(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsUnitClass></returns>
		ApiResponse<PIItemsUnitClass> GetUnitClassesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null);

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		Object CreateUnitClass(string webId, PIUnitClass unitClass, string webIdType = null);

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		ApiResponse<Object> CreateUnitClassWithHttpInfo(string webId, PIUnitClass unitClass, string webIdType = null);

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAssetServer></returns>
		System.Threading.Tasks.Task<PIItemsAssetServer> ListAsync(string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetServer>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAssetServer>> ListAsyncWithHttpInfo(string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		System.Threading.Tasks.Task<PIAssetServer> GetByNameAsync(string name, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetByNameAsyncWithHttpInfo(string name, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		System.Threading.Tasks.Task<PIAssetServer> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		System.Threading.Tasks.Task<PIAssetServer> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisRulePlugIn></returns>
		System.Threading.Tasks.Task<PIItemsAnalysisRulePlugIn> GetAnalysisRulePlugInsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisRulePlugIn>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisRulePlugIn>> GetAnalysisRulePlugInsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAssetDatabase></returns>
		System.Threading.Tasks.Task<PIItemsAssetDatabase> GetDatabasesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetDatabase>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsAssetDatabase>> GetDatabasesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateAssetDatabaseAsync(string webId, PIAssetDatabase database, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateAssetDatabaseAsyncWithHttpInfo(string webId, PIAssetDatabase database, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationContactTemplate></returns>
		System.Threading.Tasks.Task<PIItemsNotificationContactTemplate> GetNotificationContactTemplatesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationContactTemplate>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationContactTemplate>> GetNotificationContactTemplatesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityIdentity></returns>
		System.Threading.Tasks.Task<PIItemsSecurityIdentity> GetSecurityIdentitiesAsync(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>> GetSecurityIdentitiesAsyncWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityIdentityAsync(string webId, PISecurityIdentity securityIdentity, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityIdentityAsyncWithHttpInfo(string webId, PISecurityIdentity securityIdentity, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityIdentity></returns>
		System.Threading.Tasks.Task<PIItemsSecurityIdentity> GetSecurityIdentitiesForUserAsync(string webId, string userIdentity, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>> GetSecurityIdentitiesForUserAsyncWithHttpInfo(string webId, string userIdentity, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityMapping></returns>
		System.Threading.Tasks.Task<PIItemsSecurityMapping> GetSecurityMappingsAsync(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityMapping>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityMapping>> GetSecurityMappingsAsyncWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateSecurityMappingAsync(string webId, PISecurityMapping securityMapping, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityMappingAsyncWithHttpInfo(string webId, PISecurityMapping securityMapping, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTimeRulePlugIn></returns>
		System.Threading.Tasks.Task<PIItemsTimeRulePlugIn> GetTimeRulePlugInsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTimeRulePlugIn>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsTimeRulePlugIn>> GetTimeRulePlugInsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsUnitClass></returns>
		System.Threading.Tasks.Task<PIItemsUnitClass> GetUnitClassesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsUnitClass>></returns>
		System.Threading.Tasks.Task<ApiResponse<PIItemsUnitClass>> GetUnitClassesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		System.Threading.Tasks.Task<Object> CreateUnitClassAsync(string webId, PIUnitClass unitClass, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		System.Threading.Tasks.Task<ApiResponse<Object>> CreateUnitClassAsyncWithHttpInfo(string webId, PIUnitClass unitClass, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken));

		#endregion
	}

	public class AssetServerApi : IAssetServerApi
	{
		private OSIsoft.PIDevClub.PIWebApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		public AssetServerApi(Configuration configuration = null)
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
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAssetServer</returns>
		public PIItemsAssetServer List(string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsAssetServer> localVarResponse = ListWithHttpInfo(selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAssetServer></returns>
		public ApiResponse<PIItemsAssetServer> ListWithHttpInfo(string selectedFields = null, string webIdType = null)
		{

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ListWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		public PIAssetServer GetByName(string name, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIAssetServer> localVarResponse = GetByNameWithHttpInfo(name, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		public ApiResponse<PIAssetServer> GetByNameWithHttpInfo(string name, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarQueryParams.Add("name", name, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByNameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		public PIAssetServer GetByPath(string path, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIAssetServer> localVarResponse = GetByPathWithHttpInfo(path, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		public ApiResponse<PIAssetServer> GetByPathWithHttpInfo(string path, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIAssetServer</returns>
		public PIAssetServer Get(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIAssetServer> localVarResponse = GetWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIAssetServer></returns>
		public ApiResponse<PIAssetServer> GetWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAnalysisRulePlugIn</returns>
		public PIItemsAnalysisRulePlugIn GetAnalysisRulePlugIns(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsAnalysisRulePlugIn> localVarResponse = GetAnalysisRulePlugInsWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAnalysisRulePlugIn></returns>
		public ApiResponse<PIItemsAnalysisRulePlugIn> GetAnalysisRulePlugInsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/analysisruleplugins";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisRulePlugInsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisRulePlugIn>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisRulePlugIn)));
		}

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsAssetDatabase</returns>
		public PIItemsAssetDatabase GetDatabases(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsAssetDatabase> localVarResponse = GetDatabasesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsAssetDatabase></returns>
		public ApiResponse<PIItemsAssetDatabase> GetDatabasesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetDatabasesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetDatabase)));
		}

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateAssetDatabase(string webId, PIAssetDatabase database, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateAssetDatabaseWithHttpInfo(webId, database, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateAssetDatabaseWithHttpInfo(string webId, PIAssetDatabase database, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'database' is set
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetservers/{webId}/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(database);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAssetDatabaseWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsNotificationContactTemplate</returns>
		public PIItemsNotificationContactTemplate GetNotificationContactTemplates(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsNotificationContactTemplate> localVarResponse = GetNotificationContactTemplatesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsNotificationContactTemplate></returns>
		public ApiResponse<PIItemsNotificationContactTemplate> GetNotificationContactTemplatesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/notificationcontacttemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationContactTemplatesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationContactTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationContactTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationContactTemplate)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityRights</returns>
		public PIItemsSecurityRights GetSecurity(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = GetSecurityWithHttpInfo(webId, securityItem, userIdentity, forceRefresh, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityRights></returns>
		public ApiResponse<PIItemsSecurityRights> GetSecurityWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityItem' is set
			if (securityItem == null)
				throw new ApiException(400, "Missing required parameter 'securityItem'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetservers/{webId}/security";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, true);
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, true);
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", forceRefresh, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityEntry</returns>
		public PIItemsSecurityEntry GetSecurityEntries(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = GetSecurityEntriesWithHttpInfo(webId, nameFilter, securityItem, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityEntry></returns>
		public ApiResponse<PIItemsSecurityEntry> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityEntryWithHttpInfo(webId, securityEntry, applyToChildren, securityItem, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetservers/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PISecurityEntry</returns>
		public PISecurityEntry GetSecurityEntryByName(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PISecurityEntry> localVarResponse = GetSecurityEntryByNameWithHttpInfo(name, webId, securityItem, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PISecurityEntry></returns>
		public ApiResponse<PISecurityEntry> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>Object</returns>
		public Object UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)
		{
			ApiResponse<Object> localVarResponse = UpdateSecurityEntryWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("PUT"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>Object</returns>
		public Object DeleteSecurityEntry(string name, string webId, bool? applyToChildren = null, string securityItem = null)
		{
			ApiResponse<Object> localVarResponse = DeleteSecurityEntryWithHttpInfo(name, webId, applyToChildren, securityItem);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null)
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityIdentity</returns>
		public PIItemsSecurityIdentity GetSecurityIdentities(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityIdentity> localVarResponse = GetSecurityIdentitiesWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityIdentity></returns>
		public ApiResponse<PIItemsSecurityIdentity> GetSecurityIdentitiesWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityIdentitiesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityIdentity>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateSecurityIdentity(string webId, PISecurityIdentity securityIdentity, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityIdentityWithHttpInfo(webId, securityIdentity, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSecurityIdentityWithHttpInfo(string webId, PISecurityIdentity securityIdentity, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityIdentity' is set
			if (securityIdentity == null)
				throw new ApiException(400, "Missing required parameter 'securityIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityIdentity);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityIdentityWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityIdentity</returns>
		public PIItemsSecurityIdentity GetSecurityIdentitiesForUser(string webId, string userIdentity, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityIdentity> localVarResponse = GetSecurityIdentitiesForUserWithHttpInfo(webId, userIdentity, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityIdentity></returns>
		public ApiResponse<PIItemsSecurityIdentity> GetSecurityIdentitiesForUserWithHttpInfo(string webId, string userIdentity, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityIdentitiesForUserWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityIdentity>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsSecurityMapping</returns>
		public PIItemsSecurityMapping GetSecurityMappings(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			ApiResponse<PIItemsSecurityMapping> localVarResponse = GetSecurityMappingsWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsSecurityMapping></returns>
		public ApiResponse<PIItemsSecurityMapping> GetSecurityMappingsWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securitymappings";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityMappingsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityMapping>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityMapping)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityMapping)));
		}

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateSecurityMapping(string webId, PISecurityMapping securityMapping, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateSecurityMappingWithHttpInfo(webId, securityMapping, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateSecurityMappingWithHttpInfo(string webId, PISecurityMapping securityMapping, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityMapping' is set
			if (securityMapping == null)
				throw new ApiException(400, "Missing required parameter 'securityMapping'");

			var localVarPath = "/assetservers/{webId}/securitymappings";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityMapping);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityMappingWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsTimeRulePlugIn</returns>
		public PIItemsTimeRulePlugIn GetTimeRulePlugIns(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsTimeRulePlugIn> localVarResponse = GetTimeRulePlugInsWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsTimeRulePlugIn></returns>
		public ApiResponse<PIItemsTimeRulePlugIn> GetTimeRulePlugInsWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/timeruleplugins";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTimeRulePlugInsWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTimeRulePlugIn>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTimeRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTimeRulePlugIn)));
		}

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>PIItemsUnitClass</returns>
		public PIItemsUnitClass GetUnitClasses(string webId, string selectedFields = null, string webIdType = null)
		{
			ApiResponse<PIItemsUnitClass> localVarResponse = GetUnitClassesWithHttpInfo(webId, selectedFields, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<PIItemsUnitClass></returns>
		public ApiResponse<PIItemsUnitClass> GetUnitClassesWithHttpInfo(string webId, string selectedFields = null, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/unitclasses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetUnitClassesWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsUnitClass>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsUnitClass)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsUnitClass)));
		}

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>Object</returns>
		public Object CreateUnitClass(string webId, PIUnitClass unitClass, string webIdType = null)
		{
			ApiResponse<Object> localVarResponse = CreateUnitClassWithHttpInfo(webId, unitClass, webIdType);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <returns>ApiResponse<Object></returns>
		public ApiResponse<Object> CreateUnitClassWithHttpInfo(string webId, PIUnitClass unitClass, string webIdType = null)
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'unitClass' is set
			if (unitClass == null)
				throw new ApiException(400, "Missing required parameter 'unitClass'");

			var localVarPath = "/assetservers/{webId}/unitclasses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(unitClass);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateUnitClassWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
		#region Asynchronous Operations
		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAssetServer></returns>
		public async System.Threading.Tasks.Task<PIItemsAssetServer> ListAsync(string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAssetServer> localVarResponse = await ListAsyncWithHttpInfo(selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Asset Servers known to this service.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetServer>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetServer>> ListAsyncWithHttpInfo(string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("ListAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		public async System.Threading.Tasks.Task<PIAssetServer> GetByNameAsync(string name, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAssetServer> localVarResponse = await GetByNameAsyncWithHttpInfo(name, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server by name.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the name associated with it. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetByNameAsyncWithHttpInfo(string name, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarQueryParams.Add("name", name, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByNameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		public async System.Threading.Tasks.Task<PIAssetServer> GetByPathAsync(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAssetServer> localVarResponse = await GetByPathAsyncWithHttpInfo(path, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server by path.
		/// </summary>
		/// <remarks>
		/// This method returns an asset server based on the hierarchical path associated with it, and should be used when a path has been received from a separate part of the PI System for use in the PI Web API. Users should primarily search with the WebID when available.
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="path">The path to the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetByPathAsyncWithHttpInfo(string path, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'path' is set
			if (path == null)
				throw new ApiException(400, "Missing required parameter 'path'");

			var localVarPath = "/assetservers";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (path!= null) localVarQueryParams.Add("path", path, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetByPathAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIAssetServer></returns>
		public async System.Threading.Tasks.Task<PIAssetServer> GetAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIAssetServer> localVarResponse = await GetAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve an Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIAssetServer>> GetAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIAssetServer>(localVarStatusCode,
				localVarResponse.Headers,
				(PIAssetServer)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIAssetServer)));
		}

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAnalysisRulePlugIn></returns>
		public async System.Threading.Tasks.Task<PIItemsAnalysisRulePlugIn> GetAnalysisRulePlugInsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAnalysisRulePlugIn> localVarResponse = await GetAnalysisRulePlugInsAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Analysis Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Analysis Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisRulePlugIn>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAnalysisRulePlugIn>> GetAnalysisRulePlugInsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/analysisruleplugins";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetAnalysisRulePlugInsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAnalysisRulePlugIn>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAnalysisRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAnalysisRulePlugIn)));
		}

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsAssetDatabase></returns>
		public async System.Threading.Tasks.Task<PIItemsAssetDatabase> GetDatabasesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsAssetDatabase> localVarResponse = await GetDatabasesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Asset Databases on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetDatabase>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsAssetDatabase>> GetDatabasesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetDatabasesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsAssetDatabase>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsAssetDatabase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsAssetDatabase)));
		}

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateAssetDatabaseAsync(string webId, PIAssetDatabase database, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateAssetDatabaseAsyncWithHttpInfo(webId, database, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create an asset database.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the database.</param>
		/// <param name="database">The new database definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateAssetDatabaseAsyncWithHttpInfo(string webId, PIAssetDatabase database, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'database' is set
			if (database == null)
				throw new ApiException(400, "Missing required parameter 'database'");

			var localVarPath = "/assetservers/{webId}/assetdatabases";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(database);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateAssetDatabaseAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsNotificationContactTemplate></returns>
		public async System.Threading.Tasks.Task<PIItemsNotificationContactTemplate> GetNotificationContactTemplatesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsNotificationContactTemplate> localVarResponse = await GetNotificationContactTemplatesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all notification contact templates on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationContactTemplate>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsNotificationContactTemplate>> GetNotificationContactTemplatesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/notificationcontacttemplates";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetNotificationContactTemplatesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsNotificationContactTemplate>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsNotificationContactTemplate)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsNotificationContactTemplate)));
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityRights></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityRights> GetSecurityAsync(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityRights> localVarResponse = await GetSecurityAsyncWithHttpInfo(webId, securityItem, userIdentity, forceRefresh, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Get the security information of the specified security item associated with the asset server for a specified user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server for the security to be checked.</param>
		/// <param name="securityItem">The security item of the desired security information to be returned. Multiple security items may be specified with multiple instances of the parameter. If the parameter is not specified, only 'Default' security item of the security information will be returned.</param>
		/// <param name="userIdentity">The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.</param>
		/// <param name="forceRefresh">Indicates if the security cache should be refreshed before getting security information. The default is 'false'.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityRights>> GetSecurityAsyncWithHttpInfo(string webId, List<string> securityItem, List<string> userIdentity, bool? forceRefresh = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityItem' is set
			if (securityItem == null)
				throw new ApiException(400, "Missing required parameter 'securityItem'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetservers/{webId}/security";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, true);
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, true);
			if (forceRefresh!= null) localVarQueryParams.Add("forceRefresh", forceRefresh, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityRights>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityRights)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityRights)));
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityEntry></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityEntry> GetSecurityEntriesAsync(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityEntry> localVarResponse = await GetSecurityEntriesAsyncWithHttpInfo(webId, nameFilter, securityItem, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entries of the specified security item associated with the asset server based on the specified criteria. By default, all security entries for this asset server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="nameFilter">The name query string used for filtering security entries. The default is no filter.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityEntry>> GetSecurityEntriesAsyncWithHttpInfo(string webId, string nameFilter = null, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (nameFilter!= null) localVarQueryParams.Add("nameFilter", nameFilter, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntriesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityEntry)));
		}

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityEntryAsync(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityEntryAsyncWithHttpInfo(webId, securityEntry, applyToChildren, securityItem, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server where the security entry will be created.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be created. If the parameter is not specified, security entries of the 'Default' security item will be created.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityEntryAsyncWithHttpInfo(string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetservers/{webId}/securityentries";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PISecurityEntry></returns>
		public async System.Threading.Tasks.Task<PISecurityEntry> GetSecurityEntryByNameAsync(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PISecurityEntry> localVarResponse = await GetSecurityEntryByNameAsyncWithHttpInfo(name, webId, securityItem, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve the security entry of the specified security item associated with the asset server with the specified name.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server.</param>
		/// <param name="securityItem">The security item of the desired security entries information to be returned. If the parameter is not specified, security entries of the 'Default' security item will be returned.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PISecurityEntry>> GetSecurityEntryByNameAsyncWithHttpInfo(string name, string webId, string securityItem = null, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityEntryByNameAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PISecurityEntry>(localVarStatusCode,
				localVarResponse.Headers,
				(PISecurityEntry)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PISecurityEntry)));
		}

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> UpdateSecurityEntryAsync(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await UpdateSecurityEntryAsyncWithHttpInfo(name, webId, securityEntry, applyToChildren, securityItem, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Update a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be updated.</param>
		/// <param name="securityEntry">The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be updated. If the parameter is not specified, security entries of the 'Default' security item will be updated.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateSecurityEntryAsyncWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityEntry' is set
			if (securityEntry == null)
				throw new ApiException(400, "Missing required parameter 'securityEntry'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityEntry);
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("PUT"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("UpdateSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> DeleteSecurityEntryAsync(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await DeleteSecurityEntryAsyncWithHttpInfo(name, webId, applyToChildren, securityItem, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Delete a security entry owned by the asset server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="name">The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.</param>
		/// <param name="webId">The ID of the asset server where the security entry will be deleted.</param>
		/// <param name="applyToChildren">If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.</param>
		/// <param name="securityItem">The security item of the desired security entries to be deleted. If the parameter is not specified, security entries of the 'Default' security item will be deleted.</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSecurityEntryAsyncWithHttpInfo(string name, string webId, bool? applyToChildren = null, string securityItem = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'name' is set
			if (name == null)
				throw new ApiException(400, "Missing required parameter 'name'");
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityentries/{name}";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (name!= null) localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (applyToChildren!= null) localVarQueryParams.Add("applyToChildren", applyToChildren, false);
			if (securityItem!= null) localVarQueryParams.Add("securityItem", securityItem, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("DELETE"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("DeleteSecurityEntryAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityIdentity></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityIdentity> GetSecurityIdentitiesAsync(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityIdentity> localVarResponse = await GetSecurityIdentitiesAsyncWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security identities based on the specified criteria. By default, all security identities in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>> GetSecurityIdentitiesAsyncWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityIdentitiesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityIdentity>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityIdentityAsync(string webId, PISecurityIdentity securityIdentity, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityIdentityAsyncWithHttpInfo(webId, securityIdentity, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security identity.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security identity.</param>
		/// <param name="securityIdentity">The new security identity definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityIdentityAsyncWithHttpInfo(string webId, PISecurityIdentity securityIdentity, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityIdentity' is set
			if (securityIdentity == null)
				throw new ApiException(400, "Missing required parameter 'securityIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityIdentity);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityIdentityAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityIdentity></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityIdentity> GetSecurityIdentitiesForUserAsync(string webId, string userIdentity, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityIdentity> localVarResponse = await GetSecurityIdentitiesForUserAsyncWithHttpInfo(webId, userIdentity, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security identities for a specific user.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="userIdentity">The user identity to search for.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityIdentity>> GetSecurityIdentitiesForUserAsyncWithHttpInfo(string webId, string userIdentity, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'userIdentity' is set
			if (userIdentity == null)
				throw new ApiException(400, "Missing required parameter 'userIdentity'");

			var localVarPath = "/assetservers/{webId}/securityidentities";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (userIdentity!= null) localVarQueryParams.Add("userIdentity", userIdentity, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityIdentitiesForUserAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityIdentity>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityIdentity)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityIdentity)));
		}

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsSecurityMapping></returns>
		public async System.Threading.Tasks.Task<PIItemsSecurityMapping> GetSecurityMappingsAsync(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsSecurityMapping> localVarResponse = await GetSecurityMappingsAsyncWithHttpInfo(webId, field, maxCount, query, selectedFields, sortField, sortOrder, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve security mappings based on the specified criteria. By default, all security mappings in the specified Asset Server are returned.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server to search.</param>
		/// <param name="field">Specifies which of the object's properties are searched. The default is 'Name'.</param>
		/// <param name="maxCount">The maximum number of objects to be returned. The default is 1000.</param>
		/// <param name="query">The query string used for finding objects. The default is no query string.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="sortField">The field or property of the object used to sort the returned collection. The default is 'Name'.</param>
		/// <param name="sortOrder">The order that the returned collection is sorted. The default is 'Ascending'.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityMapping>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsSecurityMapping>> GetSecurityMappingsAsyncWithHttpInfo(string webId, string field = null, int? maxCount = null, string query = null, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/securitymappings";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (field!= null) localVarQueryParams.Add("field", field, false);
			if (maxCount!= null) localVarQueryParams.Add("maxCount", maxCount, false);
			if (query!= null) localVarQueryParams.Add("query", query, false);
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (sortField!= null) localVarQueryParams.Add("sortField", sortField, false);
			if (sortOrder!= null) localVarQueryParams.Add("sortOrder", sortOrder, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetSecurityMappingsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsSecurityMapping>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsSecurityMapping)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsSecurityMapping)));
		}

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateSecurityMappingAsync(string webId, PISecurityMapping securityMapping, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateSecurityMappingAsyncWithHttpInfo(webId, securityMapping, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a security mapping.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server on which to create the security mapping.</param>
		/// <param name="securityMapping">The new security mapping definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateSecurityMappingAsyncWithHttpInfo(string webId, PISecurityMapping securityMapping, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'securityMapping' is set
			if (securityMapping == null)
				throw new ApiException(400, "Missing required parameter 'securityMapping'");

			var localVarPath = "/assetservers/{webId}/securitymappings";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(securityMapping);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateSecurityMappingAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsTimeRulePlugIn></returns>
		public async System.Threading.Tasks.Task<PIItemsTimeRulePlugIn> GetTimeRulePlugInsAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsTimeRulePlugIn> localVarResponse = await GetTimeRulePlugInsAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all Time Rule Plug-in's.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the asset server, where the Time Rule Plug-in's are installed.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsTimeRulePlugIn>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsTimeRulePlugIn>> GetTimeRulePlugInsAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/timeruleplugins";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetTimeRulePlugInsAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsTimeRulePlugIn>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsTimeRulePlugIn)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsTimeRulePlugIn)));
		}

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<PIItemsUnitClass></returns>
		public async System.Threading.Tasks.Task<PIItemsUnitClass> GetUnitClassesAsync(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<PIItemsUnitClass> localVarResponse = await GetUnitClassesAsyncWithHttpInfo(webId, selectedFields, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Retrieve a list of all unit classes on the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="selectedFields">List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<PIItemsUnitClass>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<PIItemsUnitClass>> GetUnitClassesAsyncWithHttpInfo(string webId, string selectedFields = null, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");

			var localVarPath = "/assetservers/{webId}/unitclasses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			if (selectedFields!= null) localVarQueryParams.Add("selectedFields", selectedFields, false);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("GET"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("GetUnitClassesAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<PIItemsUnitClass>(localVarStatusCode,
				localVarResponse.Headers,
				(PIItemsUnitClass)Configuration.ApiClient.Deserialize(localVarResponse, typeof(PIItemsUnitClass)));
		}

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<Object></returns>
		public async System.Threading.Tasks.Task<Object> CreateUnitClassAsync(string webId, PIUnitClass unitClass, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			ApiResponse<Object> localVarResponse = await CreateUnitClassAsyncWithHttpInfo(webId, unitClass, webIdType, cancellationToken);
			return localVarResponse.Data;
		}

		/// <summary>
		/// Create a unit class in the specified Asset Server.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <exception cref="OSIsoft.PIDevClub.PIWebApiClient.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="webId">The ID of the server.</param>
		/// <param name="unitClass">The new unit class definition.</param>
		/// <param name="webIdType">Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".</param>
		/// <param name="cancellationTokenSource">Signals to a CancellationToken that might be cancelled</param>
		/// <returns>async System.Threading.Tasks.Task<ApiResponse<Object>></returns>
		public async System.Threading.Tasks.Task<ApiResponse<Object>> CreateUnitClassAsyncWithHttpInfo(string webId, PIUnitClass unitClass, string webIdType = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			// verify the required parameter 'webId' is set
			if (webId == null)
				throw new ApiException(400, "Missing required parameter 'webId'");
			// verify the required parameter 'unitClass' is set
			if (unitClass == null)
				throw new ApiException(400, "Missing required parameter 'unitClass'");

			var localVarPath = "/assetservers/{webId}/unitclasses";
			var localVarPathParams = new Dictionary<String, String>();
			var localVarQueryParams = new CustomDictionaryForQueryString();
			var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
			var localVarFormParams = new Dictionary<String, String>();
			string localVarPostBody = null;

			if (webId!= null) localVarPathParams.Add("webId", Configuration.ApiClient.ParameterToString(webId));
			localVarPostBody = Configuration.ApiClient.Serialize(unitClass);
			if (webIdType!= null) localVarQueryParams.Add("webIdType", webIdType, false);
			IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
				new HttpMethod("POST"), localVarQueryParams, localVarPostBody, localVarHeaderParams, 
				localVarPathParams, cancellationToken);

			int localVarStatusCode = (int)localVarResponse.StatusCode;

			if (ExceptionFactory != null)
			{
				Exception exception = ExceptionFactory("CreateUnitClassAsyncWithHttpInfo", localVarResponse);
				if (exception != null) throw exception;
			}

			return new ApiResponse<Object>(localVarStatusCode,
				localVarResponse.Headers,
				(Object)Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
		}

		#endregion
	}
}
