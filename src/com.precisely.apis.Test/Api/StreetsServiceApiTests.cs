/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
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
    ///  Class for testing StreetsServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class StreetsServiceApiTests
    {
        private StreetsServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StreetsServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StreetsServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' StreetsServiceApi
            Assert.IsInstanceOf(typeof(StreetsServiceApi), instance, "instance is a StreetsServiceApi");
        }

        
        /// <summary>
        /// Test GetIntersectionByAddress
        /// </summary>
        [Test]
        public void GetIntersectionByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string roadClass = null;
            //string driveTime = null;
            //string driveTimeUnit = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string historicSpeed = null;
            //string maxCandidates = null;
            //var response = instance.GetIntersectionByAddress(addressroadClassdriveTimedriveTimeUnitsearchRadiussearchRadiusUnithistoricSpeedmaxCandidates);
            //Assert.IsInstanceOf<IntersectionResponse> (response, "response is IntersectionResponse");
        }
        
        /// <summary>
        /// Test GetIntersectionByLocation
        /// </summary>
        [Test]
        public void GetIntersectionByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string roadClass = null;
            //string driveTime = null;
            //string driveTimeUnit = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string historicSpeed = null;
            //string maxCandidates = null;
            //var response = instance.GetIntersectionByLocation(longitudelatituderoadClassdriveTimedriveTimeUnitsearchRadiussearchRadiusUnithistoricSpeedmaxCandidates);
            //Assert.IsInstanceOf<IntersectionResponse> (response, "response is IntersectionResponse");
        }
        
        /// <summary>
        /// Test GetNearestSpeedLimit
        /// </summary>
        [Test]
        public void GetNearestSpeedLimitTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string path = null;
            //var response = instance.GetNearestSpeedLimit(path);
            //Assert.IsInstanceOf<SpeedLimit> (response, "response is SpeedLimit");
        }
        
    }

}
