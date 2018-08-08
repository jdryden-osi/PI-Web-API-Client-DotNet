# StreamSetApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetChannel**](StreamSetApi.md#getchannel) | **GET** /streamsets/{webId}/channel | Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
[**GetEnd**](StreamSetApi.md#getend) | **GET** /streamsets/{webId}/end | Returns End of stream values of the attributes for an Element, Event Frame or Attribute
[**GetInterpolated**](StreamSetApi.md#getinterpolated) | **GET** /streamsets/{webId}/interpolated | Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
[**GetInterpolatedAtTimes**](StreamSetApi.md#getinterpolatedattimes) | **GET** /streamsets/{webId}/interpolatedattimes | Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
[**GetPlot**](StreamSetApi.md#getplot) | **GET** /streamsets/{webId}/plot | Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetRecorded**](StreamSetApi.md#getrecorded) | **GET** /streamsets/{webId}/recorded | Returns recorded values of the attributes for an element, event frame, or attribute.
[**UpdateValues**](StreamSetApi.md#updatevalues) | **POST** /streamsets/{webId}/recorded | Updates multiple values for the specified streams.
[**GetRecordedAtTime**](StreamSetApi.md#getrecordedattime) | **GET** /streamsets/{webId}/recordedattime | Returns recorded values of the attributes for an element, event frame, or attribute.
[**GetRecordedAtTimes**](StreamSetApi.md#getrecordedattimes) | **GET** /streamsets/{webId}/recordedattimes | Returns recorded values of attributes for an element, event frame or attribute at the specified times.
[**GetSummaries**](StreamSetApi.md#getsummaries) | **GET** /streamsets/{webId}/summary | Returns summary values of the attributes for an element, event frame or attribute.
[**GetValues**](StreamSetApi.md#getvalues) | **GET** /streamsets/{webId}/value | Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
[**UpdateValue**](StreamSetApi.md#updatevalue) | **POST** /streamsets/{webId}/value | Updates a single value for the specified streams.
[**GetChannelAdHoc**](StreamSetApi.md#getchanneladhoc) | **GET** /streamsets/channel | Opens a channel that will send messages about any value changes for the specified streams.
[**GetEndAdHoc**](StreamSetApi.md#getendadhoc) | **GET** /streamsets/end | Returns End Of Stream values for attributes of the specified streams
[**GetInterpolatedAdHoc**](StreamSetApi.md#getinterpolatedadhoc) | **GET** /streamsets/interpolated | Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
[**GetInterpolatedAtTimesAdHoc**](StreamSetApi.md#getinterpolatedattimesadhoc) | **GET** /streamsets/interpolatedattimes | Returns interpolated values of the specified streams at the specified times.
[**GetPlotAdHoc**](StreamSetApi.md#getplotadhoc) | **GET** /streamsets/plot | Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetRecordedAdHoc**](StreamSetApi.md#getrecordedadhoc) | **GET** /streamsets/recorded | Returns recorded values of the specified streams.
[**UpdateValuesAdHoc**](StreamSetApi.md#updatevaluesadhoc) | **POST** /streamsets/recorded | Updates multiple values for the specified streams.
[**GetRecordedAtTimeAdHoc**](StreamSetApi.md#getrecordedattimeadhoc) | **GET** /streamsets/recordedattime | Returns recorded values based on the passed time and retrieval mode.
[**GetRecordedAtTimesAdHoc**](StreamSetApi.md#getrecordedattimesadhoc) | **GET** /streamsets/recordedattimes | Returns recorded values of the specified streams at the specified times.
[**GetSummariesAdHoc**](StreamSetApi.md#getsummariesadhoc) | **GET** /streamsets/summary | Returns summary values of the specified streams.
[**RetrieveStreamSetUpdates**](StreamSetApi.md#retrievestreamsetupdates) | **GET** /streamsets/updates | Receive stream updates
[**RegisterStreamSetUpdates**](StreamSetApi.md#registerstreamsetupdates) | **POST** /streamsets/updates | Register for stream updates
[**GetValuesAdHoc**](StreamSetApi.md#getvaluesadhoc) | **GET** /streamsets/value | Returns values of the specified streams.
[**UpdateValueAdHoc**](StreamSetApi.md#updatevalueadhoc) | **POST** /streamsets/value | Updates a single value for the specified streams.


# **GetChannel**
> GetChannel(string webId, string categoryName = null, int? heartbeatRate = null, bool? includeInitialValues = null, string nameFilter = null, bool? searchFullHierarchy = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string webIdType = null)

Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **heartbeatRate** | **int?**| Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.. | [optional]
 **includeInitialValues** | **bool?**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetEnd**
> GetEnd(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string webIdType = null)

Returns End of stream values of the attributes for an Element, Event Frame or Attribute

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetInterpolated**
> GetInterpolated(string webId, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **syncTime** | **string**| An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.. | [optional]
 **syncTimeBoundaryType** | **string**| An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetInterpolatedAtTimes**
> GetInterpolatedAtTimes(string webId, List<string> time, string categoryName = null, string filterExpression = null, bool? includeFilteredValues = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns interpolated values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **time** | **List<string>**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetPlot**
> GetPlot(string webId, string categoryName = null, string endTime = null, int? intervals = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **intervals** | **int?**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecorded**
> GetRecorded(string webId, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. | [optional]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **maxCount** | **int?**| The maximum number of values to be returned. The default is 1000.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UpdateValues**
> UpdateValues(string webId, List<PIStreamValues> values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. | [required]
 **values** | **List<PIStreamValues>**| The values to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. | [optional]


### Return type

[**PIItemsItemsSubstatus**](../Model/PIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecordedAtTime**
> GetRecordedAtTime(string webId, string time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **time** | **string**| The timestamp at which the values are desired.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecordedAtTimes**
> GetRecordedAtTimes(string webId, List<string> time, string categoryName = null, string nameFilter = null, string retrievalMode = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortOrder = null, string templateName = null, string timeZone = null, string webIdType = null)

Returns recorded values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **time** | **List<string>**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetSummaries**
> GetSummaries(string webId, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string templateName = null, string timeType = null, string timeZone = null, string webIdType = null)

Returns summary values of the attributes for an element, event frame or attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. | [required]
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. | [optional]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. | [optional]
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. | [optional]
 **summaryDuration** | **string**| The duration of each summary interval.. | [optional]
 **summaryType** | **List<string>**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamSummaries**](../Model/PIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetValues**
> GetValues(string webId, string categoryName = null, string nameFilter = null, bool? searchFullHierarchy = null, string selectedFields = null, bool? showExcluded = null, bool? showHidden = null, string sortField = null, string sortOrder = null, string templateName = null, string time = null, string timeZone = null, string webIdType = null)

Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. | [required]
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. | [optional]
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. | [optional]
 **searchFullHierarchy** | **bool?**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **showExcluded** | **bool?**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. | [optional]
 **showHidden** | **bool?**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. | [optional]
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UpdateValue**
> UpdateValue(string webId, List<PIStreamValue> values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. | [required]
 **values** | **List<PIStreamValue>**| The values to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. | [optional]


### Return type

[**PIItemsSubstatus**](../Model/PIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetChannelAdHoc**
> GetChannelAdHoc(List<string> webId, int? heartbeatRate = null, bool? includeInitialValues = null, string webIdType = null)

Opens a channel that will send messages about any value changes for the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **heartbeatRate** | **int?**| Specifies the maximum number of consecutive empty messages that can be elapsed with no new data updates from the PI System, after which the client receives an empty payload. It helps to check if the connection is still alive. Zero/negative values correspond to no heartbeat, and the default value is no heartbeat.. | [optional]
 **includeInitialValues** | **bool?**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetEndAdHoc**
> GetEndAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string webIdType = null)

Returns End Of Stream values for attributes of the specified streams

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetInterpolatedAdHoc**
> GetInterpolatedAdHoc(List<string> webId, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, string interval = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string syncTime = null, string syncTimeBoundaryType = null, string timeZone = null, string webIdType = null)

Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d'.. | [optional]
 **syncTime** | **string**| An optional start time anchor, in AFTime format. When specified, interpolated data retrieval will use the sync time as the origin for calculating the interval times.. | [optional]
 **syncTimeBoundaryType** | **string**| An optional string specifying the boundary type to use when applying a syncTime. The allowed values are 'Inside' and 'Outside'. The default is 'Inside'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetInterpolatedAtTimesAdHoc**
> GetInterpolatedAtTimesAdHoc(List<string> time, List<string> webId, string filterExpression = null, bool? includeFilteredValues = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)

Returns interpolated values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **time** | **List<string>**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. | [required]
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetPlotAdHoc**
> GetPlotAdHoc(List<string> webId, string endTime = null, int? intervals = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)

Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **intervals** | **int?**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecordedAdHoc**
> GetRecordedAdHoc(List<string> webId, string boundaryType = null, string endTime = null, string filterExpression = null, bool? includeFilteredValues = null, int? maxCount = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null, string timeZone = null, string webIdType = null)

Returns recorded values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. | [optional]
 **includeFilteredValues** | **bool?**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. | [optional]
 **maxCount** | **int?**| The maximum number of values to be returned. The default is 1000.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UpdateValuesAdHoc**
> UpdateValuesAdHoc(List<PIStreamValues> values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **values** | **List<PIStreamValues>**| The values to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. | [optional]


### Return type

[**PIItemsItemsSubstatus**](../Model/PIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecordedAtTimeAdHoc**
> GetRecordedAtTimeAdHoc(string time, List<string> webId, string retrievalMode = null, string selectedFields = null, string timeZone = null, string webIdType = null)

Returns recorded values based on the passed time and retrieval mode.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **time** | **string**| The timestamp at which the values are desired.. | [required]
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetRecordedAtTimesAdHoc**
> GetRecordedAtTimesAdHoc(List<string> time, List<string> webId, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null, string webIdType = null)

Returns recorded values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **time** | **List<string>**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. | [required]
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetSummariesAdHoc**
> GetSummariesAdHoc(List<string> webId, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, List<string> summaryType = null, string timeType = null, string timeZone = null, string webIdType = null)

Returns summary values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. | [optional]
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. | [optional]
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. | [optional]
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. | [optional]
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. | [optional]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **startTime** | **string**| An optional start time. The default is '*-1d'.. | [optional]
 **summaryDuration** | **string**| The duration of each summary interval.. | [optional]
 **summaryType** | **List<string>**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. | [optional]
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamSummaries**](../Model/PIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **RetrieveStreamSetUpdates**
> RetrieveStreamSetUpdates(List<string> marker, string selectedFields = null, string webIdType = null)

Receive stream updates

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **marker** | **List<string>**| Identifier of stream source and current position. Multiple markers may be specified with multiple instances of the parameter.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamUpdatesRetrieve**](../Model/PIItemsStreamUpdatesRetrieve.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **RegisterStreamSetUpdates**
> RegisterStreamSetUpdates(List<string> webId, string selectedFields = null, string webIdType = null)

Register for stream updates

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamUpdatesRegister**](../Model/PIItemsStreamUpdatesRegister.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetValuesAdHoc**
> GetValuesAdHoc(List<string> webId, string selectedFields = null, string sortField = null, string sortOrder = null, string time = null, string timeZone = null, string webIdType = null)

Returns values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **List<string>**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional]
 **sortField** | **string**| The field or property of the object used to sort the returned collection. For better performance, by default no sorting is applied. 'Name' is the only supported field by which to sort.. | [optional]
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'. | [optional]
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. | [optional]
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. | [optional]
 **webIdType** | **string**| Optional parameter. Used to specify the type of WebID. Useful for URL brevity and other special cases. Default is the value of the configuration item "WebIDType".. | [optional]


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **UpdateValueAdHoc**
> UpdateValueAdHoc(List<PIStreamValue> values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **values** | **List<PIStreamValue>**| The values to add or update.. | [required]
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. | [optional]
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. | [optional]


### Return type

[**PIItemsSubstatus**](../Model/PIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
