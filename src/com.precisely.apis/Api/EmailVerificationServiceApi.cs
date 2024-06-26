/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    public interface IEmailVerificationServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// ValidateEmailAddress
        /// </summary>
        /// <remarks>
        /// Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <returns>ValidateEmailAddressAPIResponse</returns>
        ValidateEmailAddressAPIResponse ValidateEmailAddress (ValidateEmailAddressAPIRequest inputEmailAddress);

        /// <summary>
        /// ValidateEmailAddress
        /// </summary>
        /// <remarks>
        /// Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <returns>ApiResponse of ValidateEmailAddressAPIResponse</returns>
        ApiResponse<ValidateEmailAddressAPIResponse> ValidateEmailAddressWithHttpInfo (ValidateEmailAddressAPIRequest inputEmailAddress);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// ValidateEmailAddress
        /// </summary>
        /// <remarks>
        /// Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ValidateEmailAddressAPIResponse</returns>
        System.Threading.Tasks.Task<ValidateEmailAddressAPIResponse> ValidateEmailAddressAsync (ValidateEmailAddressAPIRequest inputEmailAddress, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// ValidateEmailAddress
        /// </summary>
        /// <remarks>
        /// Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ValidateEmailAddressAPIResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ValidateEmailAddressAPIResponse>> ValidateEmailAddressWithHttpInfoAsync (ValidateEmailAddressAPIRequest inputEmailAddress, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class EmailVerificationServiceApi : IEmailVerificationServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailVerificationServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public EmailVerificationServiceApi(String basePath)
        {
            this.Configuration = new com.precisely.apis.Client.Configuration { BasePath = basePath };

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailVerificationServiceApi"/> class
        /// </summary>
        /// <returns></returns>
        public EmailVerificationServiceApi()
        {
            this.Configuration = com.precisely.apis.Client.Configuration.Default;

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailVerificationServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public EmailVerificationServiceApi(com.precisely.apis.Client.Configuration configuration = null)
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
        /// ValidateEmailAddress Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <returns>ValidateEmailAddressAPIResponse</returns>
        public ValidateEmailAddressAPIResponse ValidateEmailAddress (ValidateEmailAddressAPIRequest inputEmailAddress)
        {
             ApiResponse<ValidateEmailAddressAPIResponse> localVarResponse = ValidateEmailAddressWithHttpInfo(inputEmailAddress);
             return localVarResponse.Data;
        }

        /// <summary>
        /// ValidateEmailAddress Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <returns>ApiResponse of ValidateEmailAddressAPIResponse</returns>
        public ApiResponse<ValidateEmailAddressAPIResponse> ValidateEmailAddressWithHttpInfo (ValidateEmailAddressAPIRequest inputEmailAddress)
        {
            // verify the required parameter 'inputEmailAddress' is set
            if (inputEmailAddress == null)
                throw new ApiException(400, "Missing required parameter 'inputEmailAddress' when calling EmailVerificationServiceApi->ValidateEmailAddress");

            var localVarPath = "/emailverification/v1/validateemailaddress/results.json";
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

            if (inputEmailAddress != null && inputEmailAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputEmailAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputEmailAddress; // byte array
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
                Exception exception = ExceptionFactory("ValidateEmailAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<ValidateEmailAddressAPIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (ValidateEmailAddressAPIResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidateEmailAddressAPIResponse)));
            
            
        }

        /// <summary>
        /// ValidateEmailAddress Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ValidateEmailAddressAPIResponse</returns>
        public async System.Threading.Tasks.Task<ValidateEmailAddressAPIResponse> ValidateEmailAddressAsync (ValidateEmailAddressAPIRequest inputEmailAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<ValidateEmailAddressAPIResponse> localVarResponse = await ValidateEmailAddressWithHttpInfoAsync(inputEmailAddress, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// ValidateEmailAddress Confirm that your customer’s mailing address exists and that mail and packages can be delivered to it.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputEmailAddress"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (ValidateEmailAddressAPIResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ValidateEmailAddressAPIResponse>> ValidateEmailAddressWithHttpInfoAsync (ValidateEmailAddressAPIRequest inputEmailAddress, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'inputEmailAddress' is set
            if (inputEmailAddress == null)
                throw new ApiException(400, "Missing required parameter 'inputEmailAddress' when calling EmailVerificationServiceApi->ValidateEmailAddress");

            var localVarPath = "/emailverification/v1/validateemailaddress/results.json";
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

            if (inputEmailAddress != null && inputEmailAddress.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(inputEmailAddress); // http body (model) parameter
            }
            else
            {
                localVarPostBody = inputEmailAddress; // byte array
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
                Exception exception = ExceptionFactory("ValidateEmailAddress", localVarResponse);
                if (exception != null) throw exception;
            }

           return new ApiResponse<ValidateEmailAddressAPIResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (ValidateEmailAddressAPIResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ValidateEmailAddressAPIResponse)));
            
        }

    }
}