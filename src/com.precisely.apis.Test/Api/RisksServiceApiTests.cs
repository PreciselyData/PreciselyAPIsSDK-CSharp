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
    ///  Class for testing RisksServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RisksServiceApiTests
    {
        private RisksServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RisksServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RisksServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' RisksServiceApi
            Assert.IsInstanceOf(typeof(RisksServiceApi), instance, "instance is a RisksServiceApi");
        }

        
        /// <summary>
        /// Test GetCrimeRiskByAddress
        /// </summary>
        [Test]
        public void GetCrimeRiskByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string type = null;
            //string includeGeometry = null;
            //var response = instance.GetCrimeRiskByAddress(address, type, includeGeometry);
            //Assert.IsInstanceOf<CrimeRiskResponse> (response, "response is CrimeRiskResponse");
        }
        
        /// <summary>
        /// Test GetCrimeRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetCrimeRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CrimeRiskByAddressRequest body = null;
            //var response = instance.GetCrimeRiskByAddressBatch(body);
            //Assert.IsInstanceOf<CrimeRiskResponseList> (response, "response is CrimeRiskResponseList");
        }
        
        /// <summary>
        /// Test GetCrimeRiskByLocation
        /// </summary>
        [Test]
        public void GetCrimeRiskByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string type = null;
            //string includeGeometry = null;
            //var response = instance.GetCrimeRiskByLocation(longitude, latitude, type, includeGeometry);
            //Assert.IsInstanceOf<CrimeRiskLocationResponse> (response, "response is CrimeRiskLocationResponse");
        }
        
        /// <summary>
        /// Test GetCrimeRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetCrimeRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CrimeRiskByLocationRequest body = null;
            //var response = instance.GetCrimeRiskByLocationBatch(body);
            //Assert.IsInstanceOf<CrimeRiskLocationResponseList> (response, "response is CrimeRiskLocationResponseList");
        }
        
        /// <summary>
        /// Test GetDistanceToFloodHazardByAddress
        /// </summary>
        [Test]
        public void GetDistanceToFloodHazardByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string maxCandidates = null;
            //string waterBodyType = null;
            //string searchDistance = null;
            //string searchDistanceUnit = null;
            //var response = instance.GetDistanceToFloodHazardByAddress(address, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
            //Assert.IsInstanceOf<WaterBodyResponse> (response, "response is WaterBodyResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToFloodHazardByAddressBatch
        /// </summary>
        [Test]
        public void GetDistanceToFloodHazardByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistanceToFloodHazardAddressRequest body = null;
            //var response = instance.GetDistanceToFloodHazardByAddressBatch(body);
            //Assert.IsInstanceOf<DistanceToFloodHazardResponse> (response, "response is DistanceToFloodHazardResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToFloodHazardByLocation
        /// </summary>
        [Test]
        public void GetDistanceToFloodHazardByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string maxCandidates = null;
            //string waterBodyType = null;
            //string searchDistance = null;
            //string searchDistanceUnit = null;
            //var response = instance.GetDistanceToFloodHazardByLocation(longitude, latitude, maxCandidates, waterBodyType, searchDistance, searchDistanceUnit);
            //Assert.IsInstanceOf<WaterBodyLocationResponse> (response, "response is WaterBodyLocationResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToFloodHazardByLocationBatch
        /// </summary>
        [Test]
        public void GetDistanceToFloodHazardByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistanceToFloodHazardLocationRequest body = null;
            //var response = instance.GetDistanceToFloodHazardByLocationBatch(body);
            //Assert.IsInstanceOf<DistanceToFloodHazardLocationResponse> (response, "response is DistanceToFloodHazardLocationResponse");
        }
        
        /// <summary>
        /// Test GetEarthquakeHistory
        /// </summary>
        [Test]
        public void GetEarthquakeHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postCode = null;
            //string startDate = null;
            //string endDate = null;
            //string minMagnitude = null;
            //string maxMagnitude = null;
            //string maxCandidates = null;
            //var response = instance.GetEarthquakeHistory(postCode, startDate, endDate, minMagnitude, maxMagnitude, maxCandidates);
            //Assert.IsInstanceOf<EarthquakeHistory> (response, "response is EarthquakeHistory");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByAddress
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string richterValue = null;
            //string includeGeometry = null;
            //var response = instance.GetEarthquakeRiskByAddress(address, richterValue, includeGeometry);
            //Assert.IsInstanceOf<EarthquakeRiskResponse> (response, "response is EarthquakeRiskResponse");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EarthquakeRiskByAddressRequest body = null;
            //var response = instance.GetEarthquakeRiskByAddressBatch(body);
            //Assert.IsInstanceOf<EarthquakeRiskResponseList> (response, "response is EarthquakeRiskResponseList");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByLocation
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string richterValue = null;
            //string includeGeometry = null;
            //var response = instance.GetEarthquakeRiskByLocation(longitude, latitude, richterValue, includeGeometry);
            //Assert.IsInstanceOf<EarthquakeRiskLocationResponse> (response, "response is EarthquakeRiskLocationResponse");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EarthquakeRiskByLocationRequest body = null;
            //var response = instance.GetEarthquakeRiskByLocationBatch(body);
            //Assert.IsInstanceOf<EarthquakeRiskLocationResponseList> (response, "response is EarthquakeRiskLocationResponseList");
        }
        
        /// <summary>
        /// Test GetFireHistory
        /// </summary>
        [Test]
        public void GetFireHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postCode = null;
            //string startDate = null;
            //string endDate = null;
            //string maxCandidates = null;
            //var response = instance.GetFireHistory(postCode, startDate, endDate, maxCandidates);
            //Assert.IsInstanceOf<FireHistory> (response, "response is FireHistory");
        }
        
        /// <summary>
        /// Test GetFireRiskByAddress
        /// </summary>
        [Test]
        public void GetFireRiskByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //var response = instance.GetFireRiskByAddress(address);
            //Assert.IsInstanceOf<FireRiskResponse> (response, "response is FireRiskResponse");
        }
        
        /// <summary>
        /// Test GetFireRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetFireRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FireRiskByAddressRequest body = null;
            //var response = instance.GetFireRiskByAddressBatch(body);
            //Assert.IsInstanceOf<FireRiskResponseList> (response, "response is FireRiskResponseList");
        }
        
        /// <summary>
        /// Test GetFireRiskByLocation
        /// </summary>
        [Test]
        public void GetFireRiskByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetFireRiskByLocation(longitude, latitude);
            //Assert.IsInstanceOf<FireRiskLocationResponse> (response, "response is FireRiskLocationResponse");
        }
        
        /// <summary>
        /// Test GetFireRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetFireRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FireRiskByLocationRequest body = null;
            //var response = instance.GetFireRiskByLocationBatch(body);
            //Assert.IsInstanceOf<FireRiskLocationResponseList> (response, "response is FireRiskLocationResponseList");
        }
        
        /// <summary>
        /// Test GetFireStationByAddress
        /// </summary>
        [Test]
        public void GetFireStationByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string maxCandidates = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string sortBy = null;
            //string historicTrafficTimeBucket = null;
            //var response = instance.GetFireStationByAddress(address, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
            //Assert.IsInstanceOf<FireStations> (response, "response is FireStations");
        }
        
        /// <summary>
        /// Test GetFireStationByLocation
        /// </summary>
        [Test]
        public void GetFireStationByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string maxCandidates = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string sortBy = null;
            //string historicTrafficTimeBucket = null;
            //var response = instance.GetFireStationByLocation(longitude, latitude, maxCandidates, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, sortBy, historicTrafficTimeBucket);
            //Assert.IsInstanceOf<FireStationsLocation> (response, "response is FireStationsLocation");
        }
        
        /// <summary>
        /// Test GetFloodRiskByAddress
        /// </summary>
        [Test]
        public void GetFloodRiskByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string includeZoneDesc = null;
            //string includeGeometry = null;
            //var response = instance.GetFloodRiskByAddress(address, includeZoneDesc, includeGeometry);
            //Assert.IsInstanceOf<FloodRiskResponse> (response, "response is FloodRiskResponse");
        }
        
        /// <summary>
        /// Test GetFloodRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetFloodRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FloodRiskByAddressRequest body = null;
            //var response = instance.GetFloodRiskByAddressBatch(body);
            //Assert.IsInstanceOf<FloodRiskResponseList> (response, "response is FloodRiskResponseList");
        }
        
        /// <summary>
        /// Test GetFloodRiskByLocation
        /// </summary>
        [Test]
        public void GetFloodRiskByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string includeZoneDesc = null;
            //string includeGeometry = null;
            //var response = instance.GetFloodRiskByLocation(longitude, latitude, includeZoneDesc, includeGeometry);
            //Assert.IsInstanceOf<FloodRiskLocationResponse> (response, "response is FloodRiskLocationResponse");
        }
        
        /// <summary>
        /// Test GetFloodRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetFloodRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FloodRiskByLocationRequest body = null;
            //var response = instance.GetFloodRiskByLocationBatch(body);
            //Assert.IsInstanceOf<FloodRiskLocationResponseList> (response, "response is FloodRiskLocationResponseList");
        }
        
    }

}
