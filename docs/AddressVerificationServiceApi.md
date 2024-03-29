# com.precisely.apis.Api.AddressVerificationServiceApi

All URIs are relative to *https://api.precisely.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCityStateProvince**](AddressVerificationServiceApi.md#getcitystateprovince) | **POST** /addressverification/v1/getcitystateprovince/results.json | GetCityStateProvince
[**GetPostalCodes**](AddressVerificationServiceApi.md#getpostalcodes) | **POST** /addressverification/v1/getpostalcodes/results.json | GetPostalCodes
[**ValidateMailingAddress**](AddressVerificationServiceApi.md#validatemailingaddress) | **POST** /addressverification/v1/validatemailingaddress/results.json | ValidateMailingAddress
[**ValidateMailingAddressPremium**](AddressVerificationServiceApi.md#validatemailingaddresspremium) | **POST** /addressverification/v1/validatemailingaddresspremium/results.json | ValidateMailingAddressPremium
[**ValidateMailingAddressPro**](AddressVerificationServiceApi.md#validatemailingaddresspro) | **POST** /addressverification/v1/validatemailingaddresspro/results.json | ValidateMailingAddressPro
[**ValidateMailingAddressUSCAN**](AddressVerificationServiceApi.md#validatemailingaddressuscan) | **POST** /addressverification/v1/validatemailingaddressuscan/results.json | ValidateMailingAddressUSCAN



## GetCityStateProvince

> GetCityStateProvinceAPIResponse GetCityStateProvince (GetCityStateProvinceAPIRequest inputAddress)

GetCityStateProvince

GetCityStateProvince returns a city and state/province for a given input postal code for U.S. and Canadian addresses.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetCityStateProvinceExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new GetCityStateProvinceAPIRequest(); // GetCityStateProvinceAPIRequest | 

            try
            {
                // GetCityStateProvince
                GetCityStateProvinceAPIResponse result = apiInstance.GetCityStateProvince(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.GetCityStateProvince: " + e.Message );
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
 **inputAddress** | [**GetCityStateProvinceAPIRequest**](GetCityStateProvinceAPIRequest.md)|  | 

### Return type

[**GetCityStateProvinceAPIResponse**](GetCityStateProvinceAPIResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## GetPostalCodes

> GetPostalCodesAPIResponse GetPostalCodes (GetPostalCodesAPIRequest inputAddress)

GetPostalCodes

GetPostalCodes takes a city and state as input for U.S. addresses and returns the postal codes for that city.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class GetPostalCodesExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new GetPostalCodesAPIRequest(); // GetPostalCodesAPIRequest | 

            try
            {
                // GetPostalCodes
                GetPostalCodesAPIResponse result = apiInstance.GetPostalCodes(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.GetPostalCodes: " + e.Message );
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
 **inputAddress** | [**GetPostalCodesAPIRequest**](GetPostalCodesAPIRequest.md)|  | 

### Return type

[**GetPostalCodesAPIResponse**](GetPostalCodesAPIResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## ValidateMailingAddress

> ValidateMailingAddressResponse ValidateMailingAddress (ValidateMailingAddressRequest inputAddress)

ValidateMailingAddress

ValidateMailingAddress analyses and compares the input addresses against the known address databases around the world to output a standardized detail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateMailingAddressExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new ValidateMailingAddressRequest(); // ValidateMailingAddressRequest | 

            try
            {
                // ValidateMailingAddress
                ValidateMailingAddressResponse result = apiInstance.ValidateMailingAddress(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.ValidateMailingAddress: " + e.Message );
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
 **inputAddress** | [**ValidateMailingAddressRequest**](ValidateMailingAddressRequest.md)|  | 

### Return type

[**ValidateMailingAddressResponse**](ValidateMailingAddressResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## ValidateMailingAddressPremium

> ValidateMailingAddressPremiumResponse ValidateMailingAddressPremium (ValidateMailingAddressPremiumRequest inputAddress)

ValidateMailingAddressPremium

ValidateMailing AddressPremium expands on the ValidateMailingAddressPro service by adding premium address data sources to get the best address validation result possible.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateMailingAddressPremiumExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new ValidateMailingAddressPremiumRequest(); // ValidateMailingAddressPremiumRequest | 

            try
            {
                // ValidateMailingAddressPremium
                ValidateMailingAddressPremiumResponse result = apiInstance.ValidateMailingAddressPremium(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.ValidateMailingAddressPremium: " + e.Message );
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
 **inputAddress** | [**ValidateMailingAddressPremiumRequest**](ValidateMailingAddressPremiumRequest.md)|  | 

### Return type

[**ValidateMailingAddressPremiumResponse**](ValidateMailingAddressPremiumResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## ValidateMailingAddressPro

> ValidateMailingAddressProResponse ValidateMailingAddressPro (ValidateMailingAddressProRequest inputAddress)

ValidateMailingAddressPro

ValidateMailingAddressPro builds upon the ValidateMailingAddress service by using additional address databases so it can provide enhanced detail.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateMailingAddressProExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new ValidateMailingAddressProRequest(); // ValidateMailingAddressProRequest | 

            try
            {
                // ValidateMailingAddressPro
                ValidateMailingAddressProResponse result = apiInstance.ValidateMailingAddressPro(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.ValidateMailingAddressPro: " + e.Message );
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
 **inputAddress** | [**ValidateMailingAddressProRequest**](ValidateMailingAddressProRequest.md)|  | 

### Return type

[**ValidateMailingAddressProResponse**](ValidateMailingAddressProResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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


## ValidateMailingAddressUSCAN

> ValidateMailingAddressUSCANAPIResponse ValidateMailingAddressUSCAN (ValidateMailingAddressUSCANAPIRequest inputAddress)

ValidateMailingAddressUSCAN

ValidateMailingAddressUSCAN analyses and compares the input addresses against the known address databases around the world to output a standardized detail for US and CANADAIt gives RDI and DPV also along with other US/CAN specific functionalities.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.precisely.apis.Api;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace Example
{
    public class ValidateMailingAddressUSCANExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.precisely.com";
            // Configure OAuth2 access token for authorization: oAuth2Password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AddressVerificationServiceApi(Configuration.Default);
            var inputAddress = new ValidateMailingAddressUSCANAPIRequest(); // ValidateMailingAddressUSCANAPIRequest | 

            try
            {
                // ValidateMailingAddressUSCAN
                ValidateMailingAddressUSCANAPIResponse result = apiInstance.ValidateMailingAddressUSCAN(inputAddress);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AddressVerificationServiceApi.ValidateMailingAddressUSCAN: " + e.Message );
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
 **inputAddress** | [**ValidateMailingAddressUSCANAPIRequest**](ValidateMailingAddressUSCANAPIRequest.md)|  | 

### Return type

[**ValidateMailingAddressUSCANAPIResponse**](ValidateMailingAddressUSCANAPIResponse.md)

### Authorization

[oAuth2Password](../README.md#oAuth2Password)

### HTTP request headers

- **Content-Type**: application/json
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

