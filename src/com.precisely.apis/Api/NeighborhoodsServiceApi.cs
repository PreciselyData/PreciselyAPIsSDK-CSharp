/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.8.0
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
    public interface INeighborhoodsServiceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>PlaceByLocations</returns>
        PlaceByLocations GetPlaceByLocation (string longitude, string latitude, string levelHint = null);

        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>ApiResponse of PlaceByLocations</returns>
        ApiResponse<PlaceByLocations> GetPlaceByLocationWithHttpInfo (string longitude, string latitude, string levelHint = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>Task of PlaceByLocations</returns>
        System.Threading.Tasks.Task<PlaceByLocations> GetPlaceByLocationAsync (string longitude, string latitude, string levelHint = null);

        /// <summary>
        /// Place By Location.
        /// </summary>
        /// <remarks>
        /// Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </remarks>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>Task of ApiResponse (PlaceByLocations)</returns>
        System.Threading.Tasks.Task<ApiResponse<PlaceByLocations>> GetPlaceByLocationAsyncWithHttpInfo (string longitude, string latitude, string levelHint = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NeighborhoodsServiceApi : INeighborhoodsServiceApi
    {
        private com.precisely.apis.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NeighborhoodsServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NeighborhoodsServiceApi(String basePath)
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
        /// Initializes a new instance of the <see cref="NeighborhoodsServiceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NeighborhoodsServiceApi(Configuration configuration = null)
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
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>PlaceByLocations</returns>
        public PlaceByLocations GetPlaceByLocation (string longitude, string latitude, string levelHint = null)
        {
             ApiResponse<PlaceByLocations> localVarResponse = GetPlaceByLocationWithHttpInfo(longitude, latitude, levelHint);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>ApiResponse of PlaceByLocations</returns>
        public ApiResponse< PlaceByLocations > GetPlaceByLocationWithHttpInfo (string longitude, string latitude, string levelHint = null)
        {
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling NeighborhoodsServiceApi->GetPlaceByLocation");
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling NeighborhoodsServiceApi->GetPlaceByLocation");

            var localVarPath = "/neighborhoods/v1/place/bylocation";
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
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (levelHint != null) localVarQueryParams.Add("levelHint", Configuration.ApiClient.ParameterToString(levelHint)); // query parameter

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
                Exception exception = ExceptionFactory("GetPlaceByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlaceByLocations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PlaceByLocations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlaceByLocations)));
            
        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>Task of PlaceByLocations</returns>
        public async System.Threading.Tasks.Task<PlaceByLocations> GetPlaceByLocationAsync (string longitude, string latitude, string levelHint = null)
        {
             ApiResponse<PlaceByLocations> localVarResponse = await GetPlaceByLocationAsyncWithHttpInfo(longitude, latitude, levelHint);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Place By Location. Identifies and retrieves the nearest neighborhood around a specific location. This Places service accepts latitude &amp; longitude as input and returns a place name.
        /// </summary>
        /// <exception cref="com.precisely.apis.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="longitude">Longitude of the location.</param>
        /// <param name="latitude">Latitude of the location.</param>
        /// <param name="levelHint">Numeric code of geographic hierarchy level which is classified at six levels.Allowed values 1,2,3,4,5,6 (optional)</param>
        /// <returns>Task of ApiResponse (PlaceByLocations)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PlaceByLocations>> GetPlaceByLocationAsyncWithHttpInfo (string longitude, string latitude, string levelHint = null)
        {
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling NeighborhoodsServiceApi->GetPlaceByLocation");
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling NeighborhoodsServiceApi->GetPlaceByLocation");

            var localVarPath = "/neighborhoods/v1/place/bylocation";
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
                "application/xml", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (longitude != null) localVarQueryParams.Add("longitude", Configuration.ApiClient.ParameterToString(longitude)); // query parameter
            if (latitude != null) localVarQueryParams.Add("latitude", Configuration.ApiClient.ParameterToString(latitude)); // query parameter
            if (levelHint != null) localVarQueryParams.Add("levelHint", Configuration.ApiClient.ParameterToString(levelHint)); // query parameter

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
                Exception exception = ExceptionFactory("GetPlaceByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PlaceByLocations>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x1 => x1.Name, x1 => x1.Value.ToString()),
                (PlaceByLocations) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PlaceByLocations)));
            
        }

    }
}
