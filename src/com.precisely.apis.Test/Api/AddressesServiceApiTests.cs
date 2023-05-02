/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.0
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
    ///  Class for testing AddressesServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressesServiceApiTests
    {
        private AddressesServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressesServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressesServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AddressesServiceApi
            Assert.IsInstanceOf(typeof(AddressesServiceApi), instance, "instance is a AddressesServiceApi");
        }

        
        /// <summary>
        /// Test GetAddressesCountByBoundaryName
        /// </summary>
        [Test]
        public void GetAddressesCountByBoundaryNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string areaName1 = null;
            //string areaName2 = null;
            //string areaName3 = null;
            //string areaName4 = null;
            //string postCode = null;
            //var response = instance.GetAddressesCountByBoundaryName(countryareaName1areaName2areaName3areaName4postCode);
            //Assert.IsInstanceOf<AddressesCount> (response, "response is AddressesCount");
        }
        
        /// <summary>
        /// Test GetAddressesCountbyBoundary
        /// </summary>
        [Test]
        public void GetAddressesCountbyBoundaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressesByBoundaryRequest addressesByBoundaryRequest = null;
            //var response = instance.GetAddressesCountbyBoundary(addressesByBoundaryRequest);
            //Assert.IsInstanceOf<AddressesCount> (response, "response is AddressesCount");
        }
        
        /// <summary>
        /// Test GetAddressesbyBoundary
        /// </summary>
        [Test]
        public void GetAddressesbyBoundaryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AddressesByBoundaryRequest addressesByBoundaryRequest = null;
            //var response = instance.GetAddressesbyBoundary(addressesByBoundaryRequest);
            //Assert.IsInstanceOf<AddressesResponse> (response, "response is AddressesResponse");
        }
        
        /// <summary>
        /// Test GetAddressesbyBoundaryName
        /// </summary>
        [Test]
        public void GetAddressesbyBoundaryNameTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string country = null;
            //string areaName1 = null;
            //string areaName2 = null;
            //string areaName3 = null;
            //string areaName4 = null;
            //string postCode = null;
            //string maxCandidates = null;
            //string page = null;
            //var response = instance.GetAddressesbyBoundaryName(countryareaName1areaName2areaName3areaName4postCodemaxCandidatespage);
            //Assert.IsInstanceOf<AddressesResponse> (response, "response is AddressesResponse");
        }
        
    }

}
