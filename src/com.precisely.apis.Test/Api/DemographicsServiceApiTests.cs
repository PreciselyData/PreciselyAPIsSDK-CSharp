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
    ///  Class for testing DemographicsServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DemographicsServiceApiTests
    {
        private DemographicsServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DemographicsServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DemographicsServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' DemographicsServiceApi
            Assert.IsInstanceOf(typeof(DemographicsServiceApi), instance, "instance is a DemographicsServiceApi");
        }

        
        /// <summary>
        /// Test GetDemographicsAdvanced
        /// </summary>
        [Test]
        public void GetDemographicsAdvancedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DemographicsAdvancedRequest demographicsAdvancedRequest = null;
            //var response = instance.GetDemographicsAdvanced(demographicsAdvancedRequest);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsBasic
        /// </summary>
        [Test]
        public void GetDemographicsBasicTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string longitude = null;
            //string latitude = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string country = null;
            //string profile = null;
            //string filter = null;
            //string includeGeometry = null;
            //var response = instance.GetDemographicsBasic(addresslongitudelatitudesearchRadiussearchRadiusUnittravelTimetravelTimeUnittravelDistancetravelDistanceUnittravelModecountryprofilefilterincludeGeometry);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByAddress
        /// </summary>
        [Test]
        public void GetDemographicsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string profile = null;
            //string filter = null;
            //string valueFormat = null;
            //string variableLevel = null;
            //var response = instance.GetDemographicsByAddress(addresscountryprofilefiltervalueFormatvariableLevel);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByBoundaryIds
        /// </summary>
        [Test]
        public void GetDemographicsByBoundaryIdsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string boundaryIds = null;
            //string profile = null;
            //string filter = null;
            //string valueFormat = null;
            //string variableLevel = null;
            //var response = instance.GetDemographicsByBoundaryIds(boundaryIdsprofilefiltervalueFormatvariableLevel);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByLocation
        /// </summary>
        [Test]
        public void GetDemographicsByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string profile = null;
            //string filter = null;
            //string valueFormat = null;
            //string variableLevel = null;
            //var response = instance.GetDemographicsByLocation(longitudelatitudeprofilefiltervalueFormatvariableLevel);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetSegmentationByAddress
        /// </summary>
        [Test]
        public void GetSegmentationByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //var response = instance.GetSegmentationByAddress(addresscountry);
            //Assert.IsInstanceOf<Segmentation> (response, "response is Segmentation");
        }
        
        /// <summary>
        /// Test GetSegmentationByLocation
        /// </summary>
        [Test]
        public void GetSegmentationByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetSegmentationByLocation(longitudelatitude);
            //Assert.IsInstanceOf<Segmentation> (response, "response is Segmentation");
        }
        
    }

}
