/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.2
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
            //DemographicsAdvancedRequest body = null;
            //var response = instance.GetDemographicsAdvanced(body);
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
            //var response = instance.GetDemographicsBasic(address, longitude, latitude, searchRadius, searchRadiusUnit, travelTime, travelTimeUnit, travelDistance, travelDistanceUnit, travelMode, country, profile, filter, includeGeometry);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByAddressV2
        /// </summary>
        [Test]
        public void GetDemographicsByAddressV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //string profile = null;
            //string filter = null;
            //string valueFormat = null;
            //string variableLevel = null;
            //var response = instance.GetDemographicsByAddressV2(address, country, profile, filter, valueFormat, variableLevel);
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
            //var response = instance.GetDemographicsByBoundaryIds(boundaryIds, profile, filter, valueFormat, variableLevel);
            //Assert.IsInstanceOf<Demographics> (response, "response is Demographics");
        }
        
        /// <summary>
        /// Test GetDemographicsByLocationV2
        /// </summary>
        [Test]
        public void GetDemographicsByLocationV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string profile = null;
            //string filter = null;
            //string valueFormat = null;
            //string variableLevel = null;
            //var response = instance.GetDemographicsByLocationV2(longitude, latitude, profile, filter, valueFormat, variableLevel);
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
            //var response = instance.GetSegmentationByAddress(address, country);
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
            //var response = instance.GetSegmentationByLocation(longitude, latitude);
            //Assert.IsInstanceOf<Segmentation> (response, "response is Segmentation");
        }
        
    }

}
