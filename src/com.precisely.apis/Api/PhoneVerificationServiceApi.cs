/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 10.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using com.precisely.apis.Client;
using com.precisely.apis.Model;

namespace com.precisely.apis.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPhoneVerificationServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Phone verification.
        /// </summary>
        /// <remarks>
        /// This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>PhoneVerification</returns>
        PhoneVerification PhoneVerification (string phoneNumber, string includeNetworkInfo = null);

        /// <summary>
        /// Phone verification.
        /// </summary>
        /// <remarks>
        /// This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>ApiResponse of PhoneVerification</returns>
        ApiResponse<PhoneVerification> PhoneVerificationWithHttpInfo (string phoneNumber, string includeNetworkInfo = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Phone verification.
        /// </summary>
        /// <remarks>
        /// This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>Task of PhoneVerification</returns>
        System.Threading.Tasks.Task<PhoneVerification> PhoneVerificationAsync (string phoneNumber, string includeNetworkInfo = null);

        /// <summary>
        /// Phone verification.
        /// </summary>
        /// <remarks>
        /// This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>Task of ApiResponse (PhoneVerification)</returns>
        System.Threading.Tasks.Task<ApiResponse<PhoneVerification>> PhoneVerificationAsyncWithHttpInfo (string phoneNumber, string includeNetworkInfo = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PhoneVerificationServiceApi : IPhoneVerificationServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PhoneVerificationServiceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = com.precisely.apis.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerificationServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PhoneVerificationServiceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
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
        public Configuration Configuration {get; set;}

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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Phone verification. This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>PhoneVerification</returns>
        public PhoneVerification PhoneVerification (string phoneNumber, string includeNetworkInfo = null)
        {
             ApiResponse<PhoneVerification> localVarResponse = PhoneVerificationWithHttpInfo(phoneNumber, includeNetworkInfo);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Phone verification. This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>ApiResponse of PhoneVerification</returns>
        public ApiResponse< PhoneVerification > PhoneVerificationWithHttpInfo (string phoneNumber, string includeNetworkInfo = null)
        {
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationServiceApi->PhoneVerification");

            var localVarPath = "/phoneverification/v1/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (includeNetworkInfo != null) localVarQueryParams.Add("includeNetworkInfo", Configuration.ApiClient.ParameterToString(includeNetworkInfo)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneVerification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneVerification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PhoneVerification) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneVerification)));
            
        }

        /// <summary>
        /// Phone verification. This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>Task of PhoneVerification</returns>
        public async System.Threading.Tasks.Task<PhoneVerification> PhoneVerificationAsync (string phoneNumber, string includeNetworkInfo = null)
        {
             ApiResponse<PhoneVerification> localVarResponse = await PhoneVerificationAsyncWithHttpInfo(phoneNumber, includeNetworkInfo);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Phone verification. This service accepts a phone number as input and returns details distinguishing landline and wireless numbers and also checks if a wireless number can be located.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="phoneNumber">E.164 formatted phone number. Accepts digits only. Country Code (1) optional for USA &amp; CAN.</param>
        /// <param name="includeNetworkInfo">Y or N (default is Y) – if it is N, then network/carrier details will not be added in the response. (optional)</param>
        /// <returns>Task of ApiResponse (PhoneVerification)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PhoneVerification>> PhoneVerificationAsyncWithHttpInfo (string phoneNumber, string includeNetworkInfo = null)
        {
            // verify the required parameter 'phoneNumber' is set
            if (phoneNumber == null)
                throw new ApiException(400, "Missing required parameter 'phoneNumber' when calling PhoneVerificationServiceApi->PhoneVerification");

            var localVarPath = "/phoneverification/v1/phoneverification";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "application/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (phoneNumber != null) localVarQueryParams.Add("phoneNumber", Configuration.ApiClient.ParameterToString(phoneNumber)); // query parameter
            if (includeNetworkInfo != null) localVarQueryParams.Add("includeNetworkInfo", Configuration.ApiClient.ParameterToString(includeNetworkInfo)); // query parameter

            // authentication (oAuth2Password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
                    else if (!String.IsNullOrEmpty(Configuration.OAuthApiKey) && !String.IsNullOrEmpty(Configuration.OAuthSecret))
                    {
                    Configuration.ApiClient.GenerateAndSetAccessToken(Configuration.OAuthApiKey,Configuration.OAuthSecret);
                    localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
                    }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PhoneVerification", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PhoneVerification>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PhoneVerification) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PhoneVerification)));
            
        }

    }
}
