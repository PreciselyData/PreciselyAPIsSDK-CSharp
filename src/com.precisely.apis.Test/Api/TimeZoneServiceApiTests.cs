/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.5.0
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
        /// Test GetBatchTimezoneByAddress
        /// </summary>
        [Test]
        public void GetBatchTimezoneByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimezoneAddressRequest body = null;
            //var response = instance.GetBatchTimezoneByAddress(body);
            //Assert.IsInstanceOf<TimezoneResponse> (response, "response is TimezoneResponse");
        }
        
        /// <summary>
        /// Test GetBatchTimezoneByLocation
        /// </summary>
        [Test]
        public void GetBatchTimezoneByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TimezoneLocationRequest body = null;
            //var response = instance.GetBatchTimezoneByLocation(body);
            //Assert.IsInstanceOf<TimezoneLocationResponse> (response, "response is TimezoneLocationResponse");
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
            //var response = instance.GetTimezoneByAddress(timestamp, address, matchMode, country);
            //Assert.IsInstanceOf<Timezone> (response, "response is Timezone");
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
            //var response = instance.GetTimezoneByLocation(timestamp, longitude, latitude);
            //Assert.IsInstanceOf<TimezoneLocation> (response, "response is TimezoneLocation");
        }
        
    }

}
