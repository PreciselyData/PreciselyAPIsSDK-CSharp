# com.precisely.apis.Api.AddressAutocompleteEnterpriseServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListLocations**](AddressAutocompleteEnterpriseServiceApi.md#listlocations) | **GET** /typeahead/v1/list/locations | 
[**ListSelect**](AddressAutocompleteEnterpriseServiceApi.md#listselect) | **GET** /typeahead/v1/list/select | 



## ListLocations

> TypeaheadLocations ListLocations (string searchText, string transactionId, string latitude = null, string longitude = null, string searchRadius = null, string searchRadiusUnit = null, string maxCandidates = null, string country = null, string matchOnAddressNumber = null, string autoDetectLocation = null, string ipAddress = null, string areaName1 = null, string areaName3 = null, string postCode = null, string returnAdminAreasOnly = null, string includeRangesDetails = null, string searchType = null, string searchOnAddressNumber = null, string searchOnUnitInfo = null, string searchOnPOBox = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ListLocationsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressAutocompleteEnterpriseServiceApi(Configuration.Default);
            var searchText = searchText_example;  // string | The input to be searched.
            var transactionId = transactionId_example;  // string | transactionId.
            var latitude = latitude_example;  // string | Latitude of the location. We need to make sure that either Lat/Lng or Country is provided to API (optional) 
            var longitude = longitude_example;  // string | Longitude of the location. We need to make sure that either Lat/Lng or Country is provided to API (optional) 
            var searchRadius = searchRadius_example;  // string | Radius range within which search is performed. (optional) 
            var searchRadiusUnit = searchRadiusUnit_example;  // string | Radius unit such as Feet, Kilometers, Miles or Meters. (optional) 
            var maxCandidates = maxCandidates_example;  // string | Maximum number of POIs that can be retrieved. (optional) 
            var country = country_example;  // string | Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API (optional) 
            var matchOnAddressNumber = matchOnAddressNumber_example;  // string | Option so that we force api to match on address number (optional) 
            var autoDetectLocation = autoDetectLocation_example;  // string | Option to allow API to detect origin of API request automatically (optional) 
            var ipAddress = ipAddress_example;  // string |  (optional) 
            var areaName1 = areaName1_example;  // string | State province of the input to be searched (optional) 
            var areaName3 = areaName3_example;  // string | City of the input to be searched (optional) 
            var postCode = postCode_example;  // string | Postal Code of the input to be searched (optional) 
            var returnAdminAreasOnly = returnAdminAreasOnly_example;  // string | if value set 'Y' then it will only do a matching on postcode or areaName1, areaName2, areaName3 and areaName4 fields in the data (optional) 
            var includeRangesDetails = includeRangesDetails_example;  // string | if value set 'Y' then display all unit info of ranges, if value set 'N' then don't show ranges (optional) 
            var searchType = searchType_example;  // string | Preference to control search type of interactive requests. (optional) 
            var searchOnAddressNumber = searchOnAddressNumber_example;  // string | Preference to search on address number. (optional) 
            var searchOnUnitInfo = searchOnUnitInfo_example;  // string | Preference to search on unit info. (optional) 
            var searchOnPOBox = searchOnPOBox_example;  // string | Specifies whether to enable search for matching on PO Box. (optional) 

            try
            {
                TypeaheadLocations result = apiInstance.ListLocations(searchText, transactionId, latitude, longitude, searchRadius, searchRadiusUnit, maxCandidates, country, matchOnAddressNumber, autoDetectLocation, ipAddress, areaName1, areaName3, postCode, returnAdminAreasOnly, includeRangesDetails, searchType, searchOnAddressNumber, searchOnUnitInfo, searchOnPOBox);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressAutocompleteEnterpriseServiceApi.ListLocations: " + e.Message );
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
 **searchText** | **string**| The input to be searched. | 
 **transactionId** | **string**| transactionId. | 
 **latitude** | **string**| Latitude of the location. We need to make sure that either Lat/Lng or Country is provided to API | [optional] 
 **longitude** | **string**| Longitude of the location. We need to make sure that either Lat/Lng or Country is provided to API | [optional] 
 **searchRadius** | **string**| Radius range within which search is performed. | [optional] 
 **searchRadiusUnit** | **string**| Radius unit such as Feet, Kilometers, Miles or Meters. | [optional] 
 **maxCandidates** | **string**| Maximum number of POIs that can be retrieved. | [optional] 
 **country** | **string**| Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API | [optional] 
 **matchOnAddressNumber** | **string**| Option so that we force api to match on address number | [optional] 
 **autoDetectLocation** | **string**| Option to allow API to detect origin of API request automatically | [optional] 
 **ipAddress** | **string**|  | [optional] 
 **areaName1** | **string**| State province of the input to be searched | [optional] 
 **areaName3** | **string**| City of the input to be searched | [optional] 
 **postCode** | **string**| Postal Code of the input to be searched | [optional] 
 **returnAdminAreasOnly** | **string**| if value set &#39;Y&#39; then it will only do a matching on postcode or areaName1, areaName2, areaName3 and areaName4 fields in the data | [optional] 
 **includeRangesDetails** | **string**| if value set &#39;Y&#39; then display all unit info of ranges, if value set &#39;N&#39; then don&#39;t show ranges | [optional] 
 **searchType** | **string**| Preference to control search type of interactive requests. | [optional] 
 **searchOnAddressNumber** | **string**| Preference to search on address number. | [optional] 
 **searchOnUnitInfo** | **string**| Preference to search on unit info. | [optional] 
 **searchOnPOBox** | **string**| Specifies whether to enable search for matching on PO Box. | [optional] 

### Return type

[**TypeaheadLocations**](TypeaheadLocations.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListSelect

> Object ListSelect (string selectedAddress, string transactionId, string country = null)



### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ListSelectExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressAutocompleteEnterpriseServiceApi(Configuration.Default);
            var selectedAddress = selectedAddress_example;  // string | Selected Address to be searched.
            var transactionId = transactionId_example;  // string | transactionId.
            var country = country_example;  // string | Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API (optional) 

            try
            {
                Object result = apiInstance.ListSelect(selectedAddress, transactionId, country);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressAutocompleteEnterpriseServiceApi.ListSelect: " + e.Message );
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
 **selectedAddress** | **string**| Selected Address to be searched. | 
 **transactionId** | **string**| transactionId. | 
 **country** | **string**| Country ISO code. We need to make sure that either Lat/Lng or Country is provided to API | [optional] 

### Return type

**Object**

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

