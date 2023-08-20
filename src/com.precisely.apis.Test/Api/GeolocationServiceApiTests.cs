/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.3
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
    ///  Class for testing GeolocationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GeolocationServiceApiTests
    {
        private GeolocationServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GeolocationServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeolocationServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' GeolocationServiceApi
            Assert.IsInstanceOf(typeof(GeolocationServiceApi), instance, "instance is a GeolocationServiceApi");
        }

        
        /// <summary>
        /// Test GetLocationByIPAddress
        /// </summary>
        [Test]
        public void GetLocationByIPAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string ipAddress = null;
            //var response = instance.GetLocationByIPAddress(ipAddress);
            //Assert.IsInstanceOf<GeoLocationIpAddr> (response, "response is GeoLocationIpAddr");
        }
        
        /// <summary>
        /// Test GetLocationByWiFiAccessPoint
        /// </summary>
        [Test]
        public void GetLocationByWiFiAccessPointTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string mac = null;
            //string ssid = null;
            //string rsid = null;
            //string speed = null;
            //string accessPoint = null;
            //var response = instance.GetLocationByWiFiAccessPoint(macssidrsidspeedaccessPoint);
            //Assert.IsInstanceOf<GeoLocationAccessPoint> (response, "response is GeoLocationAccessPoint");
        }
        
    }

}
