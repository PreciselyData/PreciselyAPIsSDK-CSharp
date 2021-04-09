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
    ///  Class for testing PlacesServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PlacesServiceApiTests
    {
        private PlacesServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PlacesServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PlacesServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' PlacesServiceApi
            Assert.IsInstanceOf(typeof(PlacesServiceApi), instance, "instance is a PlacesServiceApi");
        }

        
        /// <summary>
        /// Test GetCategoryCodeMetadata
        /// </summary>
        [Test]
        public void GetCategoryCodeMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string categoryCode = null;
            //string level = null;
            //var response = instance.GetCategoryCodeMetadata(categoryCode, level);
            //Assert.IsInstanceOf<GeoEnrichMetadataResponse> (response, "response is GeoEnrichMetadataResponse");
        }
        
        /// <summary>
        /// Test GetPOIById
        /// </summary>
        [Test]
        public void GetPOIByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetPOIById(id);
            //Assert.IsInstanceOf<POIPlaces> (response, "response is POIPlaces");
        }
        
        /// <summary>
        /// Test GetPOIsByAddress
        /// </summary>
        [Test]
        public void GetPOIsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByAddress(address, country, name, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, matchMode, specificMatchOn);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByArea
        /// </summary>
        [Test]
        public void GetPOIsByAreaTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string areaName3 = null;
            //string postcode1 = null;
            //string postcode2 = null;
            //string name = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByArea(country, areaName3, postcode1, postcode2, name, type, categoryCode, sicCode, maxCandidates, fuzzyOnName, page, matchMode, specificMatchOn);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
        /// <summary>
        /// Test GetPOIsByBoundary
        /// </summary>
        [Test]
        public void GetPOIsByBoundaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //POIByGeometryRequest body = null;
            //var response = instance.GetPOIsByBoundary(accept, contentType, body);
            //Assert.IsInstanceOf<Pois> (response, "response is Pois");
        }
        
        /// <summary>
        /// Test GetPOIsByLocation
        /// </summary>
        [Test]
        public void GetPOIsByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string searchText = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string sortBy = null;
            //string fuzzyOnName = null;
            //string page = null;
            //string searchOnNameOnly = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.GetPOIsByLocation(longitude, latitude, searchText, type, categoryCode, sicCode, maxCandidates, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, sortBy, fuzzyOnName, page, searchOnNameOnly, matchMode, specificMatchOn);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
        /// <summary>
        /// Test GetPOIsCount
        /// </summary>
        [Test]
        public void GetPOIsCountTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string contentType = null;
            //PoiCountRequest body = null;
            //var response = instance.GetPOIsCount(contentType, body);
            //Assert.IsInstanceOf<PoiCount> (response, "response is PoiCount");
        }
        
        /// <summary>
        /// Test GetSICMetadata
        /// </summary>
        [Test]
        public void GetSICMetadataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sicCode = null;
            //string level = null;
            //var response = instance.GetSICMetadata(sicCode, level);
            //Assert.IsInstanceOf<GeoEnrichMetadataResponse> (response, "response is GeoEnrichMetadataResponse");
        }
        
        /// <summary>
        /// Test PoisAutocomplete
        /// </summary>
        [Test]
        public void PoisAutocompleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string searchText = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string country = null;
            //string areaName1 = null;
            //string areaName3 = null;
            //string postcode1 = null;
            //string postcode2 = null;
            //string ipAddress = null;
            //string autoDetectLocation = null;
            //string type = null;
            //string categoryCode = null;
            //string sicCode = null;
            //string maxCandidates = null;
            //string sortBy = null;
            //string searchOnNameOnly = null;
            //string matchMode = null;
            //string specificMatchOn = null;
            //var response = instance.PoisAutocomplete(longitude, latitude, searchText, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, country, areaName1, areaName3, postcode1, postcode2, ipAddress, autoDetectLocation, type, categoryCode, sicCode, maxCandidates, sortBy, searchOnNameOnly, matchMode, specificMatchOn);
            //Assert.IsInstanceOf<GeoEnrichResponse> (response, "response is GeoEnrichResponse");
        }
        
    }

}
