/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.6.0
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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using com.precisely.apis.Client;
using com.precisely.apis.Api;
using com.precisely.apis.Model;

namespace com.precisely.apis.Test
{
    /// <summary>
    ///  Class for testing GeocodeServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GeocodeServiceApiTests
    {
        private GeocodeServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GeocodeServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeocodeServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' GeocodeServiceApi
            Assert.IsInstanceOf(typeof(GeocodeServiceApi), instance, "instance is a GeocodeServiceApi");
        }

        
        /// <summary>
        /// Test Geocode
        /// </summary>
        [Test]
        public void GeocodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //string country = null;
            //string placeName = null;
            //string mainAddress = null;
            //string lastLine = null;
            //string areaName1 = null;
            //string areaName2 = null;
            //string areaName3 = null;
            //string areaName4 = null;
            //int? postalCode = null;
            //string matchMode = null;
            //bool? fallbackGeo = null;
            //bool? fallbackPostal = null;
            //int? maxCands = null;
            //int? streetOffset = null;
            //string streetOffsetUnits = null;
            //int? cornerOffset = null;
            //string cornerOffsetUnits = null;
            //var response = instance.Geocode(datapackBundle, country, placeName, mainAddress, lastLine, areaName1, areaName2, areaName3, areaName4, postalCode, matchMode, fallbackGeo, fallbackPostal, maxCands, streetOffset, streetOffsetUnits, cornerOffset, cornerOffsetUnits);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
        /// <summary>
        /// Test GeocodeBatch
        /// </summary>
        [Test]
        public void GeocodeBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GeocodeRequest body = null;
            //string datapackBundle = null;
            //var response = instance.GeocodeBatch(body, datapackBundle);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test GetCapabilities
        /// </summary>
        [Test]
        public void GetCapabilitiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //string operation = null;
            //string country = null;
            //var response = instance.GetCapabilities(datapackBundle, operation, country);
            //Assert.IsInstanceOf<GeocodeCapabilitiesResponse> (response, "response is GeocodeCapabilitiesResponse");
        }
        
        /// <summary>
        /// Test GetDictionaries
        /// </summary>
        [Test]
        public void GetDictionariesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //string country = null;
            //var response = instance.GetDictionaries(datapackBundle, country);
            //Assert.IsInstanceOf<ConfiguredDictionaryResponse> (response, "response is ConfiguredDictionaryResponse");
        }
        
        /// <summary>
        /// Test GetPreciselyID
        /// </summary>
        [Test]
        public void GetPreciselyIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //var response = instance.GetPreciselyID(address, country);
            //Assert.IsInstanceOf<PBKeyResponse> (response, "response is PBKeyResponse");
        }
        
        /// <summary>
        /// Test GetPreciselyIDs
        /// </summary>
        [Test]
        public void GetPreciselyIDsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PBKeyAddressRequest body = null;
            //var response = instance.GetPreciselyIDs(body);
            //Assert.IsInstanceOf<PBKeyResponseList> (response, "response is PBKeyResponseList");
        }
        
        /// <summary>
        /// Test KeyLookup
        /// </summary>
        [Test]
        public void KeyLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string type = null;
            //string country = null;
            //var response = instance.KeyLookup(key, type, country);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
        /// <summary>
        /// Test KeyLookupBatch
        /// </summary>
        [Test]
        public void KeyLookupBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KeyLookupRequest body = null;
            //var response = instance.KeyLookupBatch(body);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test ReverseGeocodBatch
        /// </summary>
        [Test]
        public void ReverseGeocodBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //ReverseGeocodeRequest body = null;
            //var response = instance.ReverseGeocodBatch(datapackBundle, body);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test ReverseGeocode
        /// </summary>
        [Test]
        public void ReverseGeocodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //decimal? x = null;
            //decimal? y = null;
            //string country = null;
            //string coordSysName = null;
            //int? distance = null;
            //string distanceUnits = null;
            //var response = instance.ReverseGeocode(datapackBundle, x, y, country, coordSysName, distance, distanceUnits);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
    }

}
