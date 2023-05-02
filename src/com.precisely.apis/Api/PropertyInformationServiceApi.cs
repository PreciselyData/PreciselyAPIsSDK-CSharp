/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace com.precisely.apis.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPropertyInformationServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// PropertyV2 Attributes By Address.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <returns>PropertyInfoResponse</returns>
        PropertyInfoResponse GetPropertyAttributesByAddress (string address = default(string), string attributes = default(string));

        /// <summary>
        /// PropertyV2 Attributes By Address.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <returns>ApiResponse of PropertyInfoResponse</returns>
        ApiResponse<PropertyInfoResponse> GetPropertyAttributesByAddressWithHttpInfo (string address = default(string), string attributes = default(string));
        /// <summary>
        /// PropertyV2 Attributes By Address Batch.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <returns>PropertyInfoResponses</returns>
        PropertyInfoResponses GetPropertyAttributesByAddressBatch (PropertyInfoAddressRequest propertyInfoAddressRequest);

        /// <summary>
        /// PropertyV2 Attributes By Address Batch.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <returns>ApiResponse of PropertyInfoResponses</returns>
        ApiResponse<PropertyInfoResponses> GetPropertyAttributesByAddressBatchWithHttpInfo (PropertyInfoAddressRequest propertyInfoAddressRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// PropertyV2 Attributes By Address.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PropertyInfoResponse</returns>
        System.Threading.Tasks.Task<PropertyInfoResponse> GetPropertyAttributesByAddressAsync (string address = default(string), string attributes = default(string), CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// PropertyV2 Attributes By Address.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PropertyInfoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyInfoResponse>> GetPropertyAttributesByAddressWithHttpInfoAsync (string address = default(string), string attributes = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// PropertyV2 Attributes By Address Batch.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PropertyInfoResponses</returns>
        System.Threading.Tasks.Task<PropertyInfoResponses> GetPropertyAttributesByAddressBatchAsync (PropertyInfoAddressRequest propertyInfoAddressRequest, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// PropertyV2 Attributes By Address Batch.
        /// </summary>
        /// <remarks>
        /// GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PropertyInfoResponses)</returns>
        System.Threading.Tasks.Task<ApiResponse<PropertyInfoResponses>> GetPropertyAttributesByAddressBatchWithHttpInfoAsync (PropertyInfoAddressRequest propertyInfoAddressRequest, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PropertyInformationServiceApi : IPropertyInformationServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInformationServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PropertyInformationServiceApi(String basePath)
        {
            this.Configuration = new com.precisely.apis.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInformationServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public PropertyInformationServiceApi()
        {
            this.Configuration = com.precisely.apis.Client.Configuration.Default;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInformationServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PropertyInformationServiceApi(com.precisely.apis.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = com.precisely.apis.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.precisely.apis.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.precisely.apis.Client.ExceptionFactory ExceptionFactory
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

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// PropertyV2 Attributes By Address. GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <returns>PropertyInfoResponse</returns>
        public PropertyInfoResponse GetPropertyAttributesByAddress (string address = default(string), string attributes = default(string))
        {
             ApiResponse<PropertyInfoResponse> localVarResponse = GetPropertyAttributesByAddressWithHttpInfo(address, attributes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PropertyV2 Attributes By Address. GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <returns>ApiResponse of PropertyInfoResponse</returns>
        public ApiResponse<PropertyInfoResponse> GetPropertyAttributesByAddressWithHttpInfo (string address = default(string), string attributes = default(string))
        {

            var localVarPath = "/property/v2/attributes/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
            if (attributes != null) localVarQueryParams.Add("attributes", Configuration.ApiClient.ParameterToString(attributes)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPropertyAttributesByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<PropertyInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PropertyInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyInfoResponse)));
            
            
        }

        /// <summary>
        /// PropertyV2 Attributes By Address. GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PropertyInfoResponse</returns>
        public async System.Threading.Tasks.Task<PropertyInfoResponse> GetPropertyAttributesByAddressAsync (string address = default(string), string attributes = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PropertyInfoResponse> localVarResponse = await GetPropertyAttributesByAddressWithHttpInfoAsync(address, attributes, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PropertyV2 Attributes By Address. GetPropertyAttributesbyAddress Endpoint will take address as an input and will return key property attributes in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="address">free form address text (optional)</param>
        /// <param name="attributes">Case-insensitive comma separated values of property attributes. Response will contain only the input attributes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PropertyInfoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyInfoResponse>> GetPropertyAttributesByAddressWithHttpInfoAsync (string address = default(string), string attributes = default(string), CancellationToken cancellationToken = default(CancellationToken))
        {

            var localVarPath = "/property/v2/attributes/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

           if (address != null) localVarQueryParams.Add("address", Configuration.ApiClient.ParameterToString(address)); // query parameter
           if (attributes != null) localVarQueryParams.Add("attributes", Configuration.ApiClient.ParameterToString(attributes)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPropertyAttributesByAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<PropertyInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PropertyInfoResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyInfoResponse)));
            
        }

        /// <summary>
        /// PropertyV2 Attributes By Address Batch. GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <returns>PropertyInfoResponses</returns>
        public PropertyInfoResponses GetPropertyAttributesByAddressBatch (PropertyInfoAddressRequest propertyInfoAddressRequest)
        {
             ApiResponse<PropertyInfoResponses> localVarResponse = GetPropertyAttributesByAddressBatchWithHttpInfo(propertyInfoAddressRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// PropertyV2 Attributes By Address Batch. GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <returns>ApiResponse of PropertyInfoResponses</returns>
        public ApiResponse<PropertyInfoResponses> GetPropertyAttributesByAddressBatchWithHttpInfo (PropertyInfoAddressRequest propertyInfoAddressRequest)
        {
            // verify the required parameter 'propertyInfoAddressRequest' is set
            if (propertyInfoAddressRequest == null)
                throw new ApiException(400, "Missing required parameter 'propertyInfoAddressRequest' when calling PropertyInformationServiceApi->GetPropertyAttributesByAddressBatch");

            var localVarPath = "/property/v2/attributes/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (propertyInfoAddressRequest != null && propertyInfoAddressRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(propertyInfoAddressRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = propertyInfoAddressRequest; // byte array
            }

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPropertyAttributesByAddressBatch", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<PropertyInfoResponses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PropertyInfoResponses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyInfoResponses)));
            
            
        }

        /// <summary>
        /// PropertyV2 Attributes By Address Batch. GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of PropertyInfoResponses</returns>
        public async System.Threading.Tasks.Task<PropertyInfoResponses> GetPropertyAttributesByAddressBatchAsync (PropertyInfoAddressRequest propertyInfoAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<PropertyInfoResponses> localVarResponse = await GetPropertyAttributesByAddressBatchWithHttpInfoAsync(propertyInfoAddressRequest, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// PropertyV2 Attributes By Address Batch. GetPropertyAttributesbyAddressBatch Endpoint will take the list of addresses as an input and will return key property attributes for the given addresses in response. Optionally user will have the option to filter the attributes and will pay for only returned attributes.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="propertyInfoAddressRequest"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (PropertyInfoResponses)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PropertyInfoResponses>> GetPropertyAttributesByAddressBatchWithHttpInfoAsync (PropertyInfoAddressRequest propertyInfoAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'propertyInfoAddressRequest' is set
            if (propertyInfoAddressRequest == null)
                throw new ApiException(400, "Missing required parameter 'propertyInfoAddressRequest' when calling PropertyInformationServiceApi->GetPropertyAttributesByAddressBatch");

            var localVarPath = "/property/v2/attributes/byaddress";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "application/xml"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (propertyInfoAddressRequest != null && propertyInfoAddressRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(propertyInfoAddressRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = propertyInfoAddressRequest; // byte array
            }

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPropertyAttributesByAddressBatch", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<PropertyInfoResponses>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PropertyInfoResponses) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PropertyInfoResponses)));
            
        }

    }
}