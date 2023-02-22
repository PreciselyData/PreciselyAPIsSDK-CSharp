/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 14.0.0
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
    ///  Class for testing TimeZoneServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TimeZoneServiceApiTests
    {
        private TimeZoneServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TimeZoneServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TimeZoneServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' TimeZoneServiceApi
            Assert.IsInstanceOf(typeof(TimeZoneServiceApi), instance, "instance is a TimeZoneServiceApi");
        }

        
        /// <summary>
        /// Test GetBatchTimezoneByLocation
        /// </summary>
        [Test]
        public void GetBatchTimezoneByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimezoneLocationRequest timezoneLocationRequest = null;
            //var response = instance.GetBatchTimezoneByLocation(timezoneLocationRequest);
            //Assert.IsInstanceOf<TimezoneResponseList> (response, "response is TimezoneResponseList");
        }
        
        /// <summary>
        /// Test GetTimezoneByAddress
        /// </summary>
        [Test]
        public void GetTimezoneByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timestamp = null;
            //string address = null;
            //string matchMode = null;
            //string country = null;
            //var response = instance.GetTimezoneByAddress(timestampaddressmatchModecountry);
            //Assert.IsInstanceOf<TimezoneResponse> (response, "response is TimezoneResponse");
        }
        
        /// <summary>
        /// Test GetTimezoneByAddressBatch
        /// </summary>
        [Test]
        public void GetTimezoneByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimezoneAddressRequest timezoneAddressRequest = null;
            //var response = instance.GetTimezoneByAddressBatch(timezoneAddressRequest);
            //Assert.IsInstanceOf<TimezoneResponseList> (response, "response is TimezoneResponseList");
        }
        
        /// <summary>
        /// Test GetTimezoneByLocation
        /// </summary>
        [Test]
        public void GetTimezoneByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string timestamp = null;
            //string longitude = null;
            //string latitude = null;
            //var response = instance.GetTimezoneByLocation(timestamplongitudelatitude);
            //Assert.IsInstanceOf<TimezoneResponse> (response, "response is TimezoneResponse");
        }
        
    }

}
