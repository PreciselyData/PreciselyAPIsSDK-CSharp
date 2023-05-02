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
    ///  Class for testing AddressAutocompleteServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AddressAutocompleteServiceApiTests
    {
        private AddressAutocompleteServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressAutocompleteServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AddressAutocompleteServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' AddressAutocompleteServiceApi
            Assert.IsInstanceOf(typeof(AddressAutocompleteServiceApi), instance, "instance is a AddressAutocompleteServiceApi");
        }

        
        /// <summary>
        /// Test SearchV2
        /// </summary>
        [Test]
        public void SearchV2Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string searchText = null;
            //string latitude = null;
            //string longitude = null;
            //string searchRadius = null;
            //string searchRadiusUnit = null;
            //string maxCandidates = null;
            //string country = null;
            //string matchOnAddressNumber = null;
            //string autoDetectLocation = null;
            //string ipAddress = null;
            //string areaName1 = null;
            //string areaName3 = null;
            //string postCode = null;
            //string returnAdminAreasOnly = null;
            //string includeRangesDetails = null;
            //string searchType = null;
            //string searchOnAddressNumber = null;
            //var response = instance.SearchV2(searchTextlatitudelongitudesearchRadiussearchRadiusUnitmaxCandidatescountrymatchOnAddressNumberautoDetectLocationipAddressareaName1areaName3postCodereturnAdminAreasOnlyincludeRangesDetailssearchTypesearchOnAddressNumber);
            //Assert.IsInstanceOf<TypeaheadLocations> (response, "response is TypeaheadLocations");
        }
        
    }

}
