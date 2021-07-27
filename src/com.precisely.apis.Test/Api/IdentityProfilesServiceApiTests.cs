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
    ///  Class for testing IdentityProfilesServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IdentityProfilesServiceApiTests
    {
        private IdentityProfilesServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new IdentityProfilesServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IdentityProfilesServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' IdentityProfilesServiceApi
            Assert.IsInstanceOf(typeof(IdentityProfilesServiceApi), instance, "instance is a IdentityProfilesServiceApi");
        }

        
        /// <summary>
        /// Test GetIdentityByAddress
        /// </summary>
        [Test]
        public void GetIdentityByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string confidence = null;
            //string maxCandidates = null;
            //string theme = null;
            //string filter = null;
            //var response = instance.GetIdentityByAddress(address, confidence, maxCandidates, theme, filter);
            //Assert.IsInstanceOf<IdentityResponse> (response, "response is IdentityResponse");
        }
        
        /// <summary>
        /// Test GetIdentityByEmail
        /// </summary>
        [Test]
        public void GetIdentityByEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string email = null;
            //string confidence = null;
            //string theme = null;
            //string filter = null;
            //var response = instance.GetIdentityByEmail(email, confidence, theme, filter);
            //Assert.IsInstanceOf<Identity> (response, "response is Identity");
        }
        
        /// <summary>
        /// Test GetIdentityByTwitter
        /// </summary>
        [Test]
        public void GetIdentityByTwitterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string twitter = null;
            //string confidence = null;
            //string theme = null;
            //string filter = null;
            //var response = instance.GetIdentityByTwitter(twitter, confidence, theme, filter);
            //Assert.IsInstanceOf<Identity> (response, "response is Identity");
        }
        
    }

}
