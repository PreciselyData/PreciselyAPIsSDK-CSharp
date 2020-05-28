# com.precisely.apis.Api.ZonesServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBasicBoundaryByAddress**](ZonesServiceApi.md#getbasicboundarybyaddress) | **GET** /zones/v1/basicboundary/byaddress | Gets Basic Boundary by Address
[**GetBasicBoundaryByLocation**](ZonesServiceApi.md#getbasicboundarybylocation) | **GET** /zones/v1/basicboundary/bylocation | Gets Basic Boundary by Location
[**GetPOIBoundaryByAddress**](ZonesServiceApi.md#getpoiboundarybyaddress) | **GET** /zones/v1/poiboundary/byaddress | Get Point of Interests Boundary by Address
[**GetPOIBoundaryByAddressBatch**](ZonesServiceApi.md#getpoiboundarybyaddressbatch) | **POST** /zones/v1/poiboundary/byaddress | Batch method for getting Point of Interests Boundary by Address
[**GetPOIBoundaryByLocation**](ZonesServiceApi.md#getpoiboundarybylocation) | **GET** /zones/v1/poiboundary/bylocation | Get Point of Interests Boundary by Location
[**GetPOIBoundaryByLocationBatch**](ZonesServiceApi.md#getpoiboundarybylocationbatch) | **POST** /zones/v1/poiboundary/bylocation | Batch method for getting Point of Interests Boundary by Location
[**GetTravelBoundaryByDistance**](ZonesServiceApi.md#gettravelboundarybydistance) | **GET** /zones/v1/travelboundary/bydistance | Gets travel Boundary by Distance
[**GetTravelBoundaryByTime**](ZonesServiceApi.md#gettravelboundarybytime) | **GET** /zones/v1/travelboundary/bytime | Gets travel Boundary by Time


<a name="getbasicboundarybyaddress"></a>
# **GetBasicBoundaryByAddress**
> BasicBoundaryAddress GetBasicBoundaryByAddress (string address, string distance, string country = null, string distanceUnit = null, string resolution = null, string responseSrs = null)

Gets Basic Boundary by Address

Gets Basic Boundary by Address

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBasicBoundaryByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var address = address_example;  // string | Address around which Basic Boundary is requested
            var distance = distance_example;  // string | This is width of the buffer (in a complete circular buffer, it would be radius of the buffer). This has to be a positive number.
            var country = country_example;  // string | Three digit ISO country code (optional)  (default to USA)
            var distanceUnit = distanceUnit_example;  // string | Longitude around which Basic Boundary is requested (optional)  (default to feet)
            var resolution = resolution_example;  // string | This is resolution of the buffer. Curves generated in buffer are approximated by line segments and it is measured in segments per circle. The higher the resolution, the smoother the curves of the buffer but more points would be required in the boundary geometry. Number greater than 0 and in multiple of 4. If not in 4, then it is approximated to nearest multiple of 4. (optional) 
            var responseSrs = responseSrs_example;  // string | The spatial reference system to express the response in. By default, it would be epsg:4326 (optional)  (default to epsg:4326)

            try
            {
                // Gets Basic Boundary by Address
                BasicBoundaryAddress result = apiInstance.GetBasicBoundaryByAddress(address, distance, country, distanceUnit, resolution, responseSrs);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetBasicBoundaryByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address around which Basic Boundary is requested | 
 **distance** | **string**| This is width of the buffer (in a complete circular buffer, it would be radius of the buffer). This has to be a positive number. | 
 **country** | **string**| Three digit ISO country code | [optional] [default to USA]
 **distanceUnit** | **string**| Longitude around which Basic Boundary is requested | [optional] [default to feet]
 **resolution** | **string**| This is resolution of the buffer. Curves generated in buffer are approximated by line segments and it is measured in segments per circle. The higher the resolution, the smoother the curves of the buffer but more points would be required in the boundary geometry. Number greater than 0 and in multiple of 4. If not in 4, then it is approximated to nearest multiple of 4. | [optional] 
 **responseSrs** | **string**| The spatial reference system to express the response in. By default, it would be epsg:4326 | [optional] [default to epsg:4326]

### Return type

[**BasicBoundaryAddress**](BasicBoundaryAddress.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbasicboundarybylocation"></a>
# **GetBasicBoundaryByLocation**
> BasicBoundary GetBasicBoundaryByLocation (string latitude, string longitude, string distance, string distanceUnit = null, string resolution = null, string responseSrs = null, string srsName = null)

Gets Basic Boundary by Location

Gets Basic Boundary by Location

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetBasicBoundaryByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var latitude = latitude_example;  // string | Latitude around which Basic Boundary is requested
            var longitude = longitude_example;  // string | Longitude around which Basic Boundary is requested
            var distance = distance_example;  // string | This is width of the buffer (in a complete circular buffer, it would be radius of the buffer). This has to be a positive number.
            var distanceUnit = distanceUnit_example;  // string | Longitude around which Basic Boundary is requested (optional)  (default to feet)
            var resolution = resolution_example;  // string | This is resolution of the buffer. Curves generated in buffer are approximated by line segments and it is measured in segments per circle. The higher the resolution, the smoother the curves of the buffer but more points would be required in the boundary geometry. Number greater than 0 and in multiple of 4. If not in 4, then it is approximated to nearest multiple of 4. (optional) 
            var responseSrs = responseSrs_example;  // string | The spatial reference system to express the response in. By default, it would be epsg:4326 (optional)  (default to epsg:4326)
            var srsName = srsName_example;  // string | The spatial reference system for input. By default, it would be epsg:4326 (optional)  (default to epsg:4326)

            try
            {
                // Gets Basic Boundary by Location
                BasicBoundary result = apiInstance.GetBasicBoundaryByLocation(latitude, longitude, distance, distanceUnit, resolution, responseSrs, srsName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetBasicBoundaryByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **string**| Latitude around which Basic Boundary is requested | 
 **longitude** | **string**| Longitude around which Basic Boundary is requested | 
 **distance** | **string**| This is width of the buffer (in a complete circular buffer, it would be radius of the buffer). This has to be a positive number. | 
 **distanceUnit** | **string**| Longitude around which Basic Boundary is requested | [optional] [default to feet]
 **resolution** | **string**| This is resolution of the buffer. Curves generated in buffer are approximated by line segments and it is measured in segments per circle. The higher the resolution, the smoother the curves of the buffer but more points would be required in the boundary geometry. Number greater than 0 and in multiple of 4. If not in 4, then it is approximated to nearest multiple of 4. | [optional] 
 **responseSrs** | **string**| The spatial reference system to express the response in. By default, it would be epsg:4326 | [optional] [default to epsg:4326]
 **srsName** | **string**| The spatial reference system for input. By default, it would be epsg:4326 | [optional] [default to epsg:4326]

### Return type

[**BasicBoundary**](BasicBoundary.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoiboundarybyaddress"></a>
# **GetPOIBoundaryByAddress**
> PoiBoundary GetPOIBoundaryByAddress (string address, string categoryCode = null, string sicCode = null, string naicsCode = null)

Get Point of Interests Boundary by Address

Gets Point of Interests Boundary by Address

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIBoundaryByAddressExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var address = address_example;  // string | Address around which POI Boundary is requested
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. (optional) 
            var sicCode = sicCode_example;  // string | Specify starting digits or full sic code to filter the response (optional) 
            var naicsCode = naicsCode_example;  // string | Will accept naicsCode to filter POIs in results. Max 10 allowed. (optional) 

            try
            {
                // Get Point of Interests Boundary by Address
                PoiBoundary result = apiInstance.GetPOIBoundaryByAddress(address, categoryCode, sicCode, naicsCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetPOIBoundaryByAddress: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **address** | **string**| Address around which POI Boundary is requested | 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes. | [optional] 
 **sicCode** | **string**| Specify starting digits or full sic code to filter the response | [optional] 
 **naicsCode** | **string**| Will accept naicsCode to filter POIs in results. Max 10 allowed. | [optional] 

### Return type

[**PoiBoundary**](PoiBoundary.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoiboundarybyaddressbatch"></a>
# **GetPOIBoundaryByAddressBatch**
> POIBoundaryResponse GetPOIBoundaryByAddressBatch (POIBoundaryAddressRequest body = null)

Batch method for getting Point of Interests Boundary by Address

Batch method for getting Point of Interests Boundary by Address

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIBoundaryByAddressBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var body = new POIBoundaryAddressRequest(); // POIBoundaryAddressRequest |  (optional) 

            try
            {
                // Batch method for getting Point of Interests Boundary by Address
                POIBoundaryResponse result = apiInstance.GetPOIBoundaryByAddressBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetPOIBoundaryByAddressBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**POIBoundaryAddressRequest**](POIBoundaryAddressRequest.md)|  | [optional] 

### Return type

[**POIBoundaryResponse**](POIBoundaryResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoiboundarybylocation"></a>
# **GetPOIBoundaryByLocation**
> PoiBoundary GetPOIBoundaryByLocation (string latitude, string longitude, string categoryCode = null, string sicCode = null, string naicsCode = null)

Get Point of Interests Boundary by Location

Get Point of Interests Boundary by Location

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIBoundaryByLocationExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var latitude = latitude_example;  // string | Latitude around which POI Boundary is requested
            var longitude = longitude_example;  // string | Longitude around which POI Boundary is requested
            var categoryCode = categoryCode_example;  // string | Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes (optional) 
            var sicCode = sicCode_example;  // string | Specify starting digits or full sic code to filter the response (optional) 
            var naicsCode = naicsCode_example;  // string | Will accept naicsCode to filter POIs in results. Max 10 allowed. (optional) 

            try
            {
                // Get Point of Interests Boundary by Location
                PoiBoundary result = apiInstance.GetPOIBoundaryByLocation(latitude, longitude, categoryCode, sicCode, naicsCode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetPOIBoundaryByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **string**| Latitude around which POI Boundary is requested | 
 **longitude** | **string**| Longitude around which POI Boundary is requested | 
 **categoryCode** | **string**| Specific Category/Categories Codes for the desired POIs. Accepts a mix of 4 digit (Top Category), 6 digit (Second-Level Category) and 11 digit (Low-Level Category) Category Codes | [optional] 
 **sicCode** | **string**| Specify starting digits or full sic code to filter the response | [optional] 
 **naicsCode** | **string**| Will accept naicsCode to filter POIs in results. Max 10 allowed. | [optional] 

### Return type

[**PoiBoundary**](PoiBoundary.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoiboundarybylocationbatch"></a>
# **GetPOIBoundaryByLocationBatch**
> POIBoundaryResponse GetPOIBoundaryByLocationBatch (POIBoundaryLocationRequest body = null)

Batch method for getting Point of Interests Boundary by Location

Batch method for getting Point of Interests Boundary by Location

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPOIBoundaryByLocationBatchExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var body = new POIBoundaryLocationRequest(); // POIBoundaryLocationRequest |  (optional) 

            try
            {
                // Batch method for getting Point of Interests Boundary by Location
                POIBoundaryResponse result = apiInstance.GetPOIBoundaryByLocationBatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetPOIBoundaryByLocationBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**POIBoundaryLocationRequest**](POIBoundaryLocationRequest.md)|  | [optional] 

### Return type

[**POIBoundaryResponse**](POIBoundaryResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettravelboundarybydistance"></a>
# **GetTravelBoundaryByDistance**
> TravelBoundaries GetTravelBoundaryByDistance (string costs, string point = null, string address = null, string costUnit = null, string db = null, string country = null, string maxOffroadDistance = null, string maxOffroadDistanceUnit = null, string destinationSrs = null, string majorRoads = null, string returnHoles = null, string returnIslands = null, string simplificationFactor = null, string bandingStyle = null, string historicTrafficTimeBucket = null, string defaultAmbientSpeed = null, string ambientSpeedUnit = null)

Gets travel Boundary by Distance

Returns the travel boundary based on travel distance.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTravelBoundaryByDistanceExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var costs = costs_example;  // string | Travel distance(s)
            var point = point_example;  // string | Starting point from where the travel boundary is calculated. Point in 'Lat,Long,coordsys' format (optional) 
            var address = address_example;  // string | Starting address from where the travel boundary is calculated. (optional) 
            var costUnit = costUnit_example;  // string | Travel distance such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional)  (default to m)
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | Three digit ISO country code. (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance to allow travel off the road network. (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional) 
            var destinationSrs = destinationSrs_example;  // string | Desired coordinate system of the travel boundary. (optional) 
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in the calculation or just major roads. (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired distance. (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Whether to return islands, which are small areas outside the main boundary that can be reached within the desired distance. (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Style of banding to be used in the result. (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var defaultAmbientSpeed = defaultAmbientSpeed_example;  // string | The speed to travel when going off a network road to find the travel boundary (for all road types). (optional) 
            var ambientSpeedUnit = ambientSpeedUnit_example;  // string | The unit of measure to use to calculate the ambient speed. (optional)  (default to MPH)

            try
            {
                // Gets travel Boundary by Distance
                TravelBoundaries result = apiInstance.GetTravelBoundaryByDistance(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket, defaultAmbientSpeed, ambientSpeedUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetTravelBoundaryByDistance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **costs** | **string**| Travel distance(s) | 
 **point** | **string**| Starting point from where the travel boundary is calculated. Point in &#39;Lat,Long,coordsys&#39; format | [optional] 
 **address** | **string**| Starting address from where the travel boundary is calculated. | [optional] 
 **costUnit** | **string**| Travel distance such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] [default to m]
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| Three digit ISO country code. | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance to allow travel off the road network. | [optional] 
 **maxOffroadDistanceUnit** | **string**| MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] 
 **destinationSrs** | **string**| Desired coordinate system of the travel boundary. | [optional] 
 **majorRoads** | **string**| Whether to include all roads in the calculation or just major roads. | [optional] [default to false]
 **returnHoles** | **string**| Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired distance. | [optional] [default to false]
 **returnIslands** | **string**| Whether to return islands, which are small areas outside the main boundary that can be reached within the desired distance. | [optional] [default to false]
 **simplificationFactor** | **string**| Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. | [optional] [default to 0.5]
 **bandingStyle** | **string**| Style of banding to be used in the result. | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **defaultAmbientSpeed** | **string**| The speed to travel when going off a network road to find the travel boundary (for all road types). | [optional] 
 **ambientSpeedUnit** | **string**| The unit of measure to use to calculate the ambient speed. | [optional] [default to MPH]

### Return type

[**TravelBoundaries**](TravelBoundaries.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettravelboundarybytime"></a>
# **GetTravelBoundaryByTime**
> TravelBoundaries GetTravelBoundaryByTime (string costs, string point = null, string address = null, string costUnit = null, string db = null, string country = null, string maxOffroadDistance = null, string maxOffroadDistanceUnit = null, string destinationSrs = null, string majorRoads = null, string returnHoles = null, string returnIslands = null, string simplificationFactor = null, string bandingStyle = null, string historicTrafficTimeBucket = null, string defaultAmbientSpeed = null, string ambientSpeedUnit = null)

Gets travel Boundary by Time

Travel boundary based on travel time.

### Example
```csharp
using System;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetTravelBoundaryByTimeExample
    {
        public void main()
        {
            
            // Configure OAuth2 API_KEY and SECRET for authorization: oAuth2Password
            Configuration.Default.OAuthApiKey = "API_KEY";
            Configuration.Default.OAuthSecret = "SECRET";

            var apiInstance = new ZonesServiceApi();
            var costs = costs_example;  // string | Travel time used to calculate the travel boundary.
            var point = point_example;  // string | Starting point from where the travel boundary is calculated. Point in Lat,Long,coordsys format (optional) 
            var address = address_example;  // string | Starting address from where the travel boundary is calculated. (optional) 
            var costUnit = costUnit_example;  // string | Travel time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). (optional)  (default to min)
            var db = db_example;  // string | Mode of commute. (optional)  (default to driving)
            var country = country_example;  // string | 3 character ISO code or country name. (optional)  (default to USA)
            var maxOffroadDistance = maxOffroadDistance_example;  // string | Maximum distance to allow travel off the road network. (optional) 
            var maxOffroadDistanceUnit = maxOffroadDistanceUnit_example;  // string | MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). (optional) 
            var destinationSrs = destinationSrs_example;  // string | Desired coordinate system of the travel boundary. (optional) 
            var majorRoads = majorRoads_example;  // string | Whether to include all roads in the calculation or just major roads. (optional)  (default to false)
            var returnHoles = returnHoles_example;  // string | Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired time. (optional)  (default to false)
            var returnIslands = returnIslands_example;  // string | Whether to return islands, which are small areas outside the main boundary that can be reached within the desired time. (optional)  (default to false)
            var simplificationFactor = simplificationFactor_example;  // string | Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. (optional)  (default to 0.5)
            var bandingStyle = bandingStyle_example;  // string | Style of banding to be used in the result. (optional)  (default to Donut)
            var historicTrafficTimeBucket = historicTrafficTimeBucket_example;  // string | Whether routing calculation uses the historic traffic speeds. (optional)  (default to None)
            var defaultAmbientSpeed = defaultAmbientSpeed_example;  // string | The speed to travel when going off a network road to find the travel boundary (for all road types). (optional) 
            var ambientSpeedUnit = ambientSpeedUnit_example;  // string | The unit of measure to use to calculate the ambient speed. (optional)  (default to MPH)

            try
            {
                // Gets travel Boundary by Time
                TravelBoundaries result = apiInstance.GetTravelBoundaryByTime(costs, point, address, costUnit, db, country, maxOffroadDistance, maxOffroadDistanceUnit, destinationSrs, majorRoads, returnHoles, returnIslands, simplificationFactor, bandingStyle, historicTrafficTimeBucket, defaultAmbientSpeed, ambientSpeedUnit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ZonesServiceApi.GetTravelBoundaryByTime: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **costs** | **string**| Travel time used to calculate the travel boundary. | 
 **point** | **string**| Starting point from where the travel boundary is calculated. Point in Lat,Long,coordsys format | [optional] 
 **address** | **string**| Starting address from where the travel boundary is calculated. | [optional] 
 **costUnit** | **string**| Travel time unit such as min(Minute), h(Hour), s(Second) or msec(Millisecond). | [optional] [default to min]
 **db** | **string**| Mode of commute. | [optional] [default to driving]
 **country** | **string**| 3 character ISO code or country name. | [optional] [default to USA]
 **maxOffroadDistance** | **string**| Maximum distance to allow travel off the road network. | [optional] 
 **maxOffroadDistanceUnit** | **string**| MaxOffroad Distance Unit such as ft(Foot), km(Kilometer), mi(Mile), m(Meter) or yd(Yard). | [optional] 
 **destinationSrs** | **string**| Desired coordinate system of the travel boundary. | [optional] 
 **majorRoads** | **string**| Whether to include all roads in the calculation or just major roads. | [optional] [default to false]
 **returnHoles** | **string**| Whether to return holes, which are areas within the larger boundary that cannot be reached within the desired time. | [optional] [default to false]
 **returnIslands** | **string**| Whether to return islands, which are small areas outside the main boundary that can be reached within the desired time. | [optional] [default to false]
 **simplificationFactor** | **string**| Number between 0.0 and 1.0 where 0.0 is very simple and 1.0 means the most complex. | [optional] [default to 0.5]
 **bandingStyle** | **string**| Style of banding to be used in the result. | [optional] [default to Donut]
 **historicTrafficTimeBucket** | **string**| Whether routing calculation uses the historic traffic speeds. | [optional] [default to None]
 **defaultAmbientSpeed** | **string**| The speed to travel when going off a network road to find the travel boundary (for all road types). | [optional] 
 **ambientSpeedUnit** | **string**| The unit of measure to use to calculate the ambient speed. | [optional] [default to MPH]

### Return type

[**TravelBoundaries**](TravelBoundaries.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

