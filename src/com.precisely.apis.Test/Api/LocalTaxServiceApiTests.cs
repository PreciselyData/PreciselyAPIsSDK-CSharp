/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    ///  Class for testing LocalTaxServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LocalTaxServiceApiTests
    {
        private LocalTaxServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LocalTaxServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LocalTaxServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' LocalTaxServiceApi
            Assert.IsInstanceOf(typeof(LocalTaxServiceApi), instance, "instance is a LocalTaxServiceApi");
        }

        
        /// <summary>
        /// Test GetBatchTaxByAddress
        /// </summary>
        [Test]
        public void GetBatchTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxAddressRequest taxAddressRequest = null;
            //var response = instance.GetBatchTaxByAddress(taxRateTypeIdtaxAddressRequest);
            //Assert.IsInstanceOf<TaxResponses> (response, "response is TaxResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxByLocation
        /// </summary>
        [Test]
        public void GetBatchTaxByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxLocationRequest taxLocationRequest = null;
            //var response = instance.GetBatchTaxByLocation(taxRateTypeIdtaxLocationRequest);
            //Assert.IsInstanceOf<TaxResponses> (response, "response is TaxResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxRateByAddress
        /// </summary>
        [Test]
        public void GetBatchTaxRateByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxRateAddressRequest taxRateAddressRequest = null;
            //var response = instance.GetBatchTaxRateByAddress(taxRateTypeIdtaxRateAddressRequest);
            //Assert.IsInstanceOf<TaxResponses> (response, "response is TaxResponses");
        }
        
        /// <summary>
        /// Test GetBatchTaxRateByLocation
        /// </summary>
        [Test]
        public void GetBatchTaxRateByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //TaxRateLocationRequest taxRateLocationRequest = null;
            //var response = instance.GetBatchTaxRateByLocation(taxRateTypeIdtaxRateLocationRequest);
            //Assert.IsInstanceOf<TaxResponses> (response, "response is TaxResponses");
        }
        
        /// <summary>
        /// Test GetIPDTaxByAddress
        /// </summary>
        [Test]
        public void GetIPDTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //string returnLatLongFields = null;
            //string latLongFormat = null;
            //var response = instance.GetIPDTaxByAddress(addressreturnLatLongFieldslatLongFormat);
            //Assert.IsInstanceOf<TaxDistrictResponse> (response, "response is TaxDistrictResponse");
        }
        
        /// <summary>
        /// Test GetIPDTaxByAddressBatch
        /// </summary>
        [Test]
        public void GetIPDTaxByAddressBatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //IPDTaxByAddressBatchRequest iPDTaxByAddressBatchRequest = null;
            //var response = instance.GetIPDTaxByAddressBatch(iPDTaxByAddressBatchRequest);
            //Assert.IsInstanceOf<TaxDistrictResponseList> (response, "response is TaxDistrictResponseList");
        }
        
        /// <summary>
        /// Test GetSpecificTaxByAddress
        /// </summary>
        [Test]
        public void GetSpecificTaxByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string address = null;
            //string purchaseAmount = null;
            //var response = instance.GetSpecificTaxByAddress(taxRateTypeIdaddresspurchaseAmount);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxByLocation
        /// </summary>
        [Test]
        public void GetSpecificTaxByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string latitude = null;
            //string longitude = null;
            //string purchaseAmount = null;
            //var response = instance.GetSpecificTaxByLocation(taxRateTypeIdlatitudelongitudepurchaseAmount);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxRateByAddress
        /// </summary>
        [Test]
        public void GetSpecificTaxRateByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string address = null;
            //var response = instance.GetSpecificTaxRateByAddress(taxRateTypeIdaddress);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
        /// <summary>
        /// Test GetSpecificTaxRateByLocation
        /// </summary>
        [Test]
        public void GetSpecificTaxRateByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taxRateTypeId = null;
            //string latitude = null;
            //string longitude = null;
            //var response = instance.GetSpecificTaxRateByLocation(taxRateTypeIdlatitudelongitude);
            //Assert.IsInstanceOf<TaxRateResponse> (response, "response is TaxRateResponse");
        }
        
    }

}
