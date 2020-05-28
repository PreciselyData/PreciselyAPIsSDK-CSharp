# com.precisely.apis.Api.StreetsServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIntersectionByAddress**](StreetsServiceApi.md#getintersectionbyaddress) | **GET** /streets/v1/intersection/byaddress | Nearest Intersection By Address
[**GetIntersectionByLocation**](StreetsServiceApi.md#getintersectionbylocation) | **GET** /streets/v1/intersection/bylocation | Nearest Intersection By Location
[**GetNearestSpeedLimit**](StreetsServiceApi.md#getnearestspeedlimit) | **GET** /streets/v1/speedlimit | Nearest Speedlimit


<a name="getintersectionbyaddress"></a>
# **GetIntersectionByAddress**
> IntersectionResponse GetIntersectionByAddress (string address, string roadClass = null, string driveTime = null, string driveTimeUnit = null, string searchRadius = null, string searchRadiusUnit = null, string historicSpeed = null, string maxCandidates = null)

Nearest Intersection By Address

This service accepts an address as input and returns the Nearest Intersection.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIntersectionByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new StreetsServiceApi();
            var address = address_example;  // string | Address
            var roadClass = roadClass_example;  // string | Filters roads with specified class, allowed values are (Major, Motorways, Other and All), default is All (optional) 
            var driveTime = driveTime_example;  // string | Returns Intersection in specified drive time (optional) 
            var driveTimeUnit = driveTimeUnit_example;  // string | Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes (optional) 
            var searchRadius = searchRadius_example;  // string | Search radius within which user wants to search, default is 50 miles (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search radius unit, allowed values are (feet, meter, kilometers and miles) (optional) 
            var historicSpeed = historicSpeed_example;  // string | Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) (optional) 
            var maxCandidates = maxCandidates_example;  // string | max candidates to be returned default is 1 (optional) 

            try
            {
                // Nearest Intersection By Address
                IntersectionResponse result = apiInstance.GetIntersectionByAddress(address, roadClass, driveTime, driveTimeUnit, searchRadius, searchRadiusUnit, historicSpeed, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetIntersectionByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address | 
 **roadClass** | **string**| Filters roads with specified class, allowed values are (Major, Motorways, Other and All), default is All | [optional] 
 **driveTime** | **string**| Returns Intersection in specified drive time | [optional] 
 **driveTimeUnit** | **string**| Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes | [optional] 
 **searchRadius** | **string**| Search radius within which user wants to search, default is 50 miles | [optional] 
 **searchRadiusUnit** | **string**| Search radius unit, allowed values are (feet, meter, kilometers and miles) | [optional] 
 **historicSpeed** | **string**| Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) | [optional] 
 **maxCandidates** | **string**| max candidates to be returned default is 1 | [optional] 

### Return type

[**IntersectionResponse**](IntersectionResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getintersectionbylocation"></a>
# **GetIntersectionByLocation**
> IntersectionResponse GetIntersectionByLocation (string longitude, string latitude, string roadClass = null, string driveTime = null, string driveTimeUnit = null, string searchRadius = null, string searchRadiusUnit = null, string historicSpeed = null, string maxCandidates = null)

Nearest Intersection By Location

This service accepts latitude/longitude as input and returns the Nearest Intersection.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetIntersectionByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new StreetsServiceApi();
            var longitude = longitude_example;  // string | Longitude of the location.
            var latitude = latitude_example;  // string | Latitude of the location.
            var roadClass = roadClass_example;  // string | Filters roads with specified class, allowed values are (Major, Motorways, Other and All), default is All (optional) 
            var driveTime = driveTime_example;  // string | Returns Intersection in specified drive time (optional) 
            var driveTimeUnit = driveTimeUnit_example;  // string | Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes (optional) 
            var searchRadius = searchRadius_example;  // string | Search radius within which user wants to search, default is 50 miles (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Search radius unit, allowed values are (feet, meter, kilometers and miles) (optional) 
            var historicSpeed = historicSpeed_example;  // string | Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) (optional) 
            var maxCandidates = maxCandidates_example;  // string | max candidates to be returned default is 1 (optional) 

            try
            {
                // Nearest Intersection By Location
                IntersectionResponse result = apiInstance.GetIntersectionByLocation(longitude, latitude, roadClass, driveTime, driveTimeUnit, searchRadius, searchRadiusUnit, historicSpeed, maxCandidates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetIntersectionByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **longitude** | **string**| Longitude of the location. | 
 **latitude** | **string**| Latitude of the location. | 
 **roadClass** | **string**| Filters roads with specified class, allowed values are (Major, Motorways, Other and All), default is All | [optional] 
 **driveTime** | **string**| Returns Intersection in specified drive time | [optional] 
 **driveTimeUnit** | **string**| Drive time unit, allowed values are (hours, minutes, seconds and milliseconds), default is minutes | [optional] 
 **searchRadius** | **string**| Search radius within which user wants to search, default is 50 miles | [optional] 
 **searchRadiusUnit** | **string**| Search radius unit, allowed values are (feet, meter, kilometers and miles) | [optional] 
 **historicSpeed** | **string**| Traffic flow in peak time, allowed values are (AMPEAK,PMPEAK,OFFPEAK,NIGHT) | [optional] 
 **maxCandidates** | **string**| max candidates to be returned default is 1 | [optional] 

### Return type

[**IntersectionResponse**](IntersectionResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getnearestspeedlimit"></a>
# **GetNearestSpeedLimit**
> SpeedLimit GetNearestSpeedLimit (string path)

Nearest Speedlimit

This service accepts point coordinates of a path as input and returns the posted speed limit of the road segment on which this path will snap.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetNearestSpeedLimitExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new StreetsServiceApi();
            var path = path_example;  // string | Accepts multiple points which will be snapped to the nearest road segment. Longitude and Latitude will be comma separated (longitude,latitude) and Point Coordinates will be separated by semi-colon(;)

            try
            {
                // Nearest Speedlimit
                SpeedLimit result = apiInstance.GetNearestSpeedLimit(path);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StreetsServiceApi.GetNearestSpeedLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Accepts multiple points which will be snapped to the nearest road segment. Longitude and Latitude will be comma separated (longitude,latitude) and Point Coordinates will be separated by semi-colon(;) | 

### Return type

[**SpeedLimit**](SpeedLimit.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

