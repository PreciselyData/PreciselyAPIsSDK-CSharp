/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
            //var response = instance.GetCrimeRiskByAddress(addresstypeincludeGeometry);
            //Assert.IsInstanceOf<CrimeRiskResponse> (response, "response is CrimeRiskResponse");
        }
        
        /// <summary>
        /// Test GetCrimeRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetCrimeRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CrimeRiskByAddressBatchRequest crimeRiskByAddressBatchRequest = null;
            //var response = instance.GetCrimeRiskByAddressBatch(crimeRiskByAddressBatchRequest);
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
            //var response = instance.GetCrimeRiskByLocation(longitudelatitudetypeincludeGeometry);
            //Assert.IsInstanceOf<CrimeRiskResponse> (response, "response is CrimeRiskResponse");
        }
        
        /// <summary>
        /// Test GetCrimeRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetCrimeRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CrimeRiskByLocationBatchRequest crimeRiskByLocationBatchRequest = null;
            //var response = instance.GetCrimeRiskByLocationBatch(crimeRiskByLocationBatchRequest);
            //Assert.IsInstanceOf<CrimeRiskResponseList> (response, "response is CrimeRiskResponseList");
        }
        
        /// <summary>
        /// Test GetDistanceToCoastByAddress
        /// </summary>
        [Test]
        public void GetDistanceToCoastByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string maxCandidates = null;
            //string waterBodyType = null;
            //string searchDistance = null;
            //string searchDistanceUnit = null;
            //var response = instance.GetDistanceToCoastByAddress(addressmaxCandidateswaterBodyTypesearchDistancesearchDistanceUnit);
            //Assert.IsInstanceOf<WaterBodyResponse> (response, "response is WaterBodyResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToCoastByAddressBatch
        /// </summary>
        [Test]
        public void GetDistanceToCoastByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistanceToFloodHazardAddressRequest distanceToFloodHazardAddressRequest = null;
            //var response = instance.GetDistanceToCoastByAddressBatch(distanceToFloodHazardAddressRequest);
            //Assert.IsInstanceOf<DistanceToFloodHazardResponse> (response, "response is DistanceToFloodHazardResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToCoastByLocation
        /// </summary>
        [Test]
        public void GetDistanceToCoastByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string maxCandidates = null;
            //string waterBodyType = null;
            //string searchDistance = null;
            //string searchDistanceUnit = null;
            //var response = instance.GetDistanceToCoastByLocation(longitudelatitudemaxCandidateswaterBodyTypesearchDistancesearchDistanceUnit);
            //Assert.IsInstanceOf<WaterBodyResponse> (response, "response is WaterBodyResponse");
        }
        
        /// <summary>
        /// Test GetDistanceToCoastByLocationBatch
        /// </summary>
        [Test]
        public void GetDistanceToCoastByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DistanceToFloodHazardLocationRequest distanceToFloodHazardLocationRequest = null;
            //var response = instance.GetDistanceToCoastByLocationBatch(distanceToFloodHazardLocationRequest);
            //Assert.IsInstanceOf<DistanceToFloodHazardResponse> (response, "response is DistanceToFloodHazardResponse");
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
            //var response = instance.GetEarthquakeHistory(postCodestartDateendDateminMagnitudemaxMagnitudemaxCandidates);
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
            //var response = instance.GetEarthquakeRiskByAddress(addressrichterValueincludeGeometry);
            //Assert.IsInstanceOf<EarthquakeRiskResponse> (response, "response is EarthquakeRiskResponse");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EarthquakeRiskByAddressRequest earthquakeRiskByAddressRequest = null;
            //var response = instance.GetEarthquakeRiskByAddressBatch(earthquakeRiskByAddressRequest);
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
            //var response = instance.GetEarthquakeRiskByLocation(longitudelatituderichterValueincludeGeometry);
            //Assert.IsInstanceOf<EarthquakeRiskResponse> (response, "response is EarthquakeRiskResponse");
        }
        
        /// <summary>
        /// Test GetEarthquakeRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetEarthquakeRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //EarthquakeRiskByLocationRequest earthquakeRiskByLocationRequest = null;
            //var response = instance.GetEarthquakeRiskByLocationBatch(earthquakeRiskByLocationRequest);
            //Assert.IsInstanceOf<EarthquakeRiskResponseList> (response, "response is EarthquakeRiskResponseList");
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
            //var response = instance.GetFireHistory(postCodestartDateendDatemaxCandidates);
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
            //string includeGeometry = null;
            //var response = instance.GetFireRiskByAddress(addressincludeGeometry);
            //Assert.IsInstanceOf<FireRiskResponse> (response, "response is FireRiskResponse");
        }
        
        /// <summary>
        /// Test GetFireRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetFireRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FireRiskByAddressRequest fireRiskByAddressRequest = null;
            //var response = instance.GetFireRiskByAddressBatch(fireRiskByAddressRequest);
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
            //string includeGeometry = null;
            //var response = instance.GetFireRiskByLocation(longitudelatitudeincludeGeometry);
            //Assert.IsInstanceOf<FireRiskResponse> (response, "response is FireRiskResponse");
        }
        
        /// <summary>
        /// Test GetFireRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetFireRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FireRiskByLocationRequest fireRiskByLocationRequest = null;
            //var response = instance.GetFireRiskByLocationBatch(fireRiskByLocationRequest);
            //Assert.IsInstanceOf<FireRiskResponseList> (response, "response is FireRiskResponseList");
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
            //var response = instance.GetFireStationByAddress(addressmaxCandidatestravelTimetravelTimeUnittravelDistancetravelDistanceUnitsortByhistoricTrafficTimeBucket);
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
            //var response = instance.GetFireStationByLocation(longitudelatitudemaxCandidatestravelTimetravelTimeUnittravelDistancetravelDistanceUnitsortByhistoricTrafficTimeBucket);
            //Assert.IsInstanceOf<FireStations> (response, "response is FireStations");
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
            //var response = instance.GetFloodRiskByAddress(addressincludeZoneDescincludeGeometry);
            //Assert.IsInstanceOf<FloodRiskResponse> (response, "response is FloodRiskResponse");
        }
        
        /// <summary>
        /// Test GetFloodRiskByAddressBatch
        /// </summary>
        [Test]
        public void GetFloodRiskByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FloodRiskByAddressRequest floodRiskByAddressRequest = null;
            //var response = instance.GetFloodRiskByAddressBatch(floodRiskByAddressRequest);
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
            //var response = instance.GetFloodRiskByLocation(longitudelatitudeincludeZoneDescincludeGeometry);
            //Assert.IsInstanceOf<FloodRiskResponse> (response, "response is FloodRiskResponse");
        }
        
        /// <summary>
        /// Test GetFloodRiskByLocationBatch
        /// </summary>
        [Test]
        public void GetFloodRiskByLocationBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FloodRiskByLocationRequest floodRiskByLocationRequest = null;
            //var response = instance.GetFloodRiskByLocationBatch(floodRiskByLocationRequest);
            //Assert.IsInstanceOf<FloodRiskResponseList> (response, "response is FloodRiskResponseList");
        }
        
    }

}
