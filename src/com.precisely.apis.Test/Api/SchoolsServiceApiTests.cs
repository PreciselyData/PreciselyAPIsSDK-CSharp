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
    ///  Class for testing SchoolsServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SchoolsServiceApiTests
    {
        private SchoolsServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SchoolsServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SchoolsServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' SchoolsServiceApi
            Assert.IsInstanceOf(typeof(SchoolsServiceApi), instance, "instance is a SchoolsServiceApi");
        }

        
        /// <summary>
        /// Test GetSchoolsByAddress
        /// </summary>
        [Test]
        public void GetSchoolsByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string edLevel = null;
            //string schoolType = null;
            //string schoolSubType = null;
            //string gender = null;
            //string assignedSchoolsOnly = null;
            //string districtSchoolsOnly = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string travelTime = null;
            //string travelTimeUnit = null;
            //string travelDistance = null;
            //string travelDistanceUnit = null;
            //string travelMode = null;
            //string maxCandidates = null;
            //var response = instance.GetSchoolsByAddress(addressedLevelschoolTypeschoolSubTypegenderassignedSchoolsOnlydistrictSchoolsOnlysearchRadiussearchRadiusUnittravelTimetravelTimeUnittravelDistancetravelDistanceUnittravelModemaxCandidates);
            //Assert.IsInstanceOf<SchoolsNearByResponse> (response, "response is SchoolsNearByResponse");
        }
        
    }

}
