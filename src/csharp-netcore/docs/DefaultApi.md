# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://api.deutschebahn.com/stada/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StationsGet**](DefaultApi.md#stationsget) | **GET** /stations | This operation provides the master data for german railway stations.
[**StationsIdGet**](DefaultApi.md#stationsidget) | **GET** /stations/{id} | This operation provides the master data for a german railway station selected by its station-id.
[**SzentralenGet**](DefaultApi.md#szentralenget) | **GET** /szentralen | This operation provides the master data for 3-S-Zentralen.
[**SzentralenIdGet**](DefaultApi.md#szentralenidget) | **GET** /szentralen/{id} | This operation provides the master data for 3-S-Zentralen select by its id.


<a name="stationsget"></a>
# **StationsGet**
> StationQuery StationsGet (long? offset = null, long? limit = null, string searchstring = null, string category = null, string federalstate = null, long? eva = null, string ril = null, string logicaloperator = null)

This operation provides the master data for german railway stations.

Get a QueryResult object containing station objects from the database applying to the parameters described below.   QueryResult is a container providing the following information about the query result.   1. the total number of hits   2. the maximum number of hits to be returned in that QueryResult object   3. the offset of the first hit returned in that QueryResult object with respect to all hits returned by the query   4. the result objects    The parameters described below work as filters to reduce the number of hits returned. Some of these parameters must be used only once, others are allowed to be used multiple times. Valid parameters that are allowed to be used only once are _offset_, _limit_ and _logicaloperator_.   All other parameters described below may be used multiple times.  If a parameter is given more than once, the result will contain all hits that match all given parameter values.  E.g. _federalstate=berlin&federalstate=saarland_ returns all stations in Berlin and Saarland.  If more than one filter criterion is used at the same time, the different filter criteria are interpreted as if they are combined by a logical AND operator, unless the parameter _logicaloperator_ is set to _or_.  E.g. _category=1-2&federalstate=hamburg_ returns all stations in Hamburg having category 1 or 2.  _category=1-2&federalstate=hamburg&federalsate=hessen_ returns all stations in Hamburg and Hessen having category 1 or 2, while  _searchstring=berlin*&federalstate=hamburg&federalsate=hessen&logicaloperator=or_ will return all stations with a name starting with 'berlin' as well as all stations in Hamburg and Hessen.  If no 'limit' parameter is given, the number of hits (stations) is set to its maximum value of 10000.  To specify parameter values containing German umlauts, the following encoding has to be used   * ä  => %C3%A4   * ö  => %C3%B6   * ü  => %C3%BC   * Ä  => %C3%84   * Ö  => %C3%96   * Ü  => %C3%9C   * ß  => %C3%9F 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.deutschebahn.com/stada/v2";
            // Configure HTTP basic authorization: bearerAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            var offset = 789;  // long? | Offset of the first hit returned in the QueryResult object with respect to all hits returned by the query. If this parameter is omitted, it will be set to 0 internally. (optional) 
            var limit = 789;  // long? | The maximum number of hits to be returned by that query. If 'limit' is set greater than 10000, it will be reset to 10000 internally and only 10000 hits will be returned. (optional) 
            var searchstring = searchstring_example;  // string | String to search for a station name. The wildcards * (indicating an arbitrary number of characters) and ? (indicating one single character) can be used in the search pattern. A comma separated list of station names is also supported (e.g. searchstring=hamburg*,berlin*). (optional) 
            var category = category_example;  // string | Filter by station category. Category ranges are supported as well as lists of categories (e.g. category=2-4 or category=1,3-5). The category must be between 1 and 7 otherwise a parameter exception is returned. (optional) 
            var federalstate = federalstate_example;  // string | Filter by German federal state. Lists of federal states are also supported (e.g. federalstate=bayern,hamburg). Wildcards are not allowed here. (optional) 
            var eva = 789;  // long? | Filter by EVA number. Wildcards are not allowed here. (optional) 
            var ril = ril_example;  // string | Filter by Ril100-identifier. Wildcards are not allowed here. (optional) 
            var logicaloperator = logicaloperator_example;  // string | Logical operator to combine query parameters (default=AND). See above for further details.  Allowed values: or, and (optional) 

            try
            {
                // This operation provides the master data for german railway stations.
                StationQuery result = apiInstance.StationsGet(offset, limit, searchstring, category, federalstate, eva, ril, logicaloperator);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **long?**| Offset of the first hit returned in the QueryResult object with respect to all hits returned by the query. If this parameter is omitted, it will be set to 0 internally. | [optional] 
 **limit** | **long?**| The maximum number of hits to be returned by that query. If &#39;limit&#39; is set greater than 10000, it will be reset to 10000 internally and only 10000 hits will be returned. | [optional] 
 **searchstring** | **string**| String to search for a station name. The wildcards * (indicating an arbitrary number of characters) and ? (indicating one single character) can be used in the search pattern. A comma separated list of station names is also supported (e.g. searchstring&#x3D;hamburg*,berlin*). | [optional] 
 **category** | **string**| Filter by station category. Category ranges are supported as well as lists of categories (e.g. category&#x3D;2-4 or category&#x3D;1,3-5). The category must be between 1 and 7 otherwise a parameter exception is returned. | [optional] 
 **federalstate** | **string**| Filter by German federal state. Lists of federal states are also supported (e.g. federalstate&#x3D;bayern,hamburg). Wildcards are not allowed here. | [optional] 
 **eva** | **long?**| Filter by EVA number. Wildcards are not allowed here. | [optional] 
 **ril** | **string**| Filter by Ril100-identifier. Wildcards are not allowed here. | [optional] 
 **logicaloperator** | **string**| Logical operator to combine query parameters (default&#x3D;AND). See above for further details.  Allowed values: or, and | [optional] 

### Return type

[**StationQuery**](StationQuery.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | station data |  -  |
| **400** | bad request (illegal parameter or illegal parameter value) |  -  |
| **404** | not found |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationsidget"></a>
# **StationsIdGet**
> StationQuery StationsIdGet (int id)

This operation provides the master data for a german railway station selected by its station-id.

Get a QueryResult object containing one station object specified by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationsIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.deutschebahn.com/stada/v2";
            // Configure HTTP basic authorization: bearerAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | Station ID (Bahnhofsnummer)

            try
            {
                // This operation provides the master data for a german railway station selected by its station-id.
                StationQuery result = apiInstance.StationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StationsIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| Station ID (Bahnhofsnummer) | 

### Return type

[**StationQuery**](StationQuery.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | station data |  -  |
| **400** | bad request (illegal parameter or illegal parameter value) |  -  |
| **404** | not found |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="szentralenget"></a>
# **SzentralenGet**
> SZentraleQuery SzentralenGet (long? offset = null, long? limit = null)

This operation provides the master data for 3-S-Zentralen.

Get a QueryResult object containing SZentralen objects from the database applying to the parameters described below.  QueryResult is a container providing the following information about the query result.   1. the total number of hits   2. the maximum number of hits to be returned in that QueryResult object   3. the offset of the first hit returned in that QueryResult object with respect to all hits returned by the query   4. the result objects 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SzentralenGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.deutschebahn.com/stada/v2";
            // Configure HTTP basic authorization: bearerAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            var offset = 789;  // long? | Offset of the first hit returned in the QueryResult object with respect to all hits returned by the query. If this parameter is omitted, it will be set to 0 internally. (optional) 
            var limit = 789;  // long? | The maximum number of hits to be returned by that query. If 'limit' is set greater than 10000, it will be reset to 10000 internally and only 100 hits will be returned. (optional) 

            try
            {
                // This operation provides the master data for 3-S-Zentralen.
                SZentraleQuery result = apiInstance.SzentralenGet(offset, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SzentralenGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offset** | **long?**| Offset of the first hit returned in the QueryResult object with respect to all hits returned by the query. If this parameter is omitted, it will be set to 0 internally. | [optional] 
 **limit** | **long?**| The maximum number of hits to be returned by that query. If &#39;limit&#39; is set greater than 10000, it will be reset to 10000 internally and only 100 hits will be returned. | [optional] 

### Return type

[**SZentraleQuery**](SZentraleQuery.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 3-S-Zentralen data |  -  |
| **400** | bad request (illegal parameter or illegal parameter value) |  -  |
| **404** | not found |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="szentralenidget"></a>
# **SzentralenIdGet**
> SZentraleQuery SzentralenIdGet (int id)

This operation provides the master data for 3-S-Zentralen select by its id.

Get a QueryResult object containing one SZentralen object specified by its id. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SzentralenIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.deutschebahn.com/stada/v2";
            // Configure HTTP basic authorization: bearerAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            var id = 56;  // int | id of the 3-S-Zentrale.

            try
            {
                // This operation provides the master data for 3-S-Zentralen select by its id.
                SZentraleQuery result = apiInstance.SzentralenIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SzentralenIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**| id of the 3-S-Zentrale. | 

### Return type

[**SZentraleQuery**](SZentraleQuery.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | 3-S-Zentralen data |  -  |
| **400** | bad request (illegal parameter or illegal parameter value) |  -  |
| **404** | not found |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

