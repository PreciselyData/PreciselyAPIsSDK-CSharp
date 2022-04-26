/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.3
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
    ///  Class for testing NeighborhoodsServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NeighborhoodsServiceApiTests
    {
        private NeighborhoodsServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new NeighborhoodsServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NeighborhoodsServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' NeighborhoodsServiceApi
            Assert.IsInstanceOf(typeof(NeighborhoodsServiceApi), instance, "instance is a NeighborhoodsServiceApi");
        }

        
        /// <summary>
        /// Test GetPlaceByLocation
        /// </summary>
        [Test]
        public void GetPlaceByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string longitude = null;
            //string latitude = null;
            //string levelHint = null;
            //var response = instance.GetPlaceByLocation(longitudelatitudelevelHint);
            //Assert.IsInstanceOf<NeighborhoodsResponse> (response, "response is NeighborhoodsResponse");
        }
        
    }

}
