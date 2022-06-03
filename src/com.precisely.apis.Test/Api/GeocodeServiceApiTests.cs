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
    ///  Class for testing GeocodeServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GeocodeServiceApiTests
    {
        private GeocodeServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GeocodeServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeocodeServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' GeocodeServiceApi
            Assert.IsInstanceOf(typeof(GeocodeServiceApi), instance, "instance is a GeocodeServiceApi");
        }

        
        /// <summary>
        /// Test Geocode
        /// </summary>
        [Test]
        public void GeocodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //string country = null;
            //string mainAddress = null;
            //string matchMode = null;
            //string fallbackGeo = null;
            //string fallbackPostal = null;
            //string maxCands = null;
            //string streetOffset = null;
            //string streetOffsetUnits = null;
            //string cornerOffset = null;
            //string cornerOffsetUnits = null;
            //string removeAccentMarks = null;
            //var response = instance.Geocode(datapackBundlecountrymainAddressmatchModefallbackGeofallbackPostalmaxCandsstreetOffsetstreetOffsetUnitscornerOffsetcornerOffsetUnitsremoveAccentMarks);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
        /// <summary>
        /// Test GeocodeBatch
        /// </summary>
        [Test]
        public void GeocodeBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //GeocodeRequest geocodeRequest = null;
            //var response = instance.GeocodeBatch(datapackBundlegeocodeRequest);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test GetPBKey
        /// </summary>
        [Test]
        public void GetPBKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string country = null;
            //var response = instance.GetPBKey(addresscountry);
            //Assert.IsInstanceOf<PBKeyResponse> (response, "response is PBKeyResponse");
        }
        
        /// <summary>
        /// Test GetPBKeys
        /// </summary>
        [Test]
        public void GetPBKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PBKeyAddressRequest pBKeyAddressRequest = null;
            //var response = instance.GetPBKeys(pBKeyAddressRequest);
            //Assert.IsInstanceOf<PBKeyResponseList> (response, "response is PBKeyResponseList");
        }
        
        /// <summary>
        /// Test KeyLookup
        /// </summary>
        [Test]
        public void KeyLookupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string key = null;
            //string type = null;
            //string country = null;
            //var response = instance.KeyLookup(keytypecountry);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
        /// <summary>
        /// Test KeyLookupBatch
        /// </summary>
        [Test]
        public void KeyLookupBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //KeyLookupRequest keyLookupRequest = null;
            //var response = instance.KeyLookupBatch(keyLookupRequest);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test ReverseGeocodBatch
        /// </summary>
        [Test]
        public void ReverseGeocodBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //ReverseGeocodeRequest reverseGeocodeRequest = null;
            //var response = instance.ReverseGeocodBatch(datapackBundlereverseGeocodeRequest);
            //Assert.IsInstanceOf<GeocodeServiceResponseList> (response, "response is GeocodeServiceResponseList");
        }
        
        /// <summary>
        /// Test ReverseGeocode
        /// </summary>
        [Test]
        public void ReverseGeocodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string datapackBundle = null;
            //string x = null;
            //string y = null;
            //string country = null;
            //string coordSysName = null;
            //string distance = null;
            //string distanceUnits = null;
            //var response = instance.ReverseGeocode(datapackBundlexycountrycoordSysNamedistancedistanceUnits);
            //Assert.IsInstanceOf<GeocodeServiceResponse> (response, "response is GeocodeServiceResponse");
        }
        
    }

}
