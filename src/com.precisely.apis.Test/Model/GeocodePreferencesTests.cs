/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.precisely.apis.Api;
using com.precisely.apis.Model;
using com.precisely.apis.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.precisely.apis.Test
{
    /// <summary>
    ///  Class for testing GeocodePreferences
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class GeocodePreferencesTests
    {
        // TODO uncomment below to declare an instance variable for GeocodePreferences
        //private GeocodePreferences instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of GeocodePreferences
            //instance = new GeocodePreferences();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeocodePreferences
        /// </summary>
        [Test]
        public void GeocodePreferencesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" GeocodePreferences
            //Assert.IsInstanceOf(typeof(GeocodePreferences), instance);
        }


        /// <summary>
        /// Test the property 'ReturnAllCandidateInfo'
        /// </summary>
        [Test]
        public void ReturnAllCandidateInfoTest()
        {
            // TODO unit test for the property 'ReturnAllCandidateInfo'
        }
        /// <summary>
        /// Test the property 'FallbackToGeographic'
        /// </summary>
        [Test]
        public void FallbackToGeographicTest()
        {
            // TODO unit test for the property 'FallbackToGeographic'
        }
        /// <summary>
        /// Test the property 'FallbackToPostal'
        /// </summary>
        [Test]
        public void FallbackToPostalTest()
        {
            // TODO unit test for the property 'FallbackToPostal'
        }
        /// <summary>
        /// Test the property 'MaxReturnedCandidates'
        /// </summary>
        [Test]
        public void MaxReturnedCandidatesTest()
        {
            // TODO unit test for the property 'MaxReturnedCandidates'
        }
        /// <summary>
        /// Test the property 'Distance'
        /// </summary>
        [Test]
        public void DistanceTest()
        {
            // TODO unit test for the property 'Distance'
        }
        /// <summary>
        /// Test the property 'StreetOffset'
        /// </summary>
        [Test]
        public void StreetOffsetTest()
        {
            // TODO unit test for the property 'StreetOffset'
        }
        /// <summary>
        /// Test the property 'CornerOffset'
        /// </summary>
        [Test]
        public void CornerOffsetTest()
        {
            // TODO unit test for the property 'CornerOffset'
        }
        /// <summary>
        /// Test the property 'MatchMode'
        /// </summary>
        [Test]
        public void MatchModeTest()
        {
            // TODO unit test for the property 'MatchMode'
        }
        /// <summary>
        /// Test the property 'ClientLocale'
        /// </summary>
        [Test]
        public void ClientLocaleTest()
        {
            // TODO unit test for the property 'ClientLocale'
        }
        /// <summary>
        /// Test the property 'ClientCoordSysName'
        /// </summary>
        [Test]
        public void ClientCoordSysNameTest()
        {
            // TODO unit test for the property 'ClientCoordSysName'
        }
        /// <summary>
        /// Test the property 'DistanceUnits'
        /// </summary>
        [Test]
        public void DistanceUnitsTest()
        {
            // TODO unit test for the property 'DistanceUnits'
        }
        /// <summary>
        /// Test the property 'StreetOffsetUnits'
        /// </summary>
        [Test]
        public void StreetOffsetUnitsTest()
        {
            // TODO unit test for the property 'StreetOffsetUnits'
        }
        /// <summary>
        /// Test the property 'CornerOffsetUnits'
        /// </summary>
        [Test]
        public void CornerOffsetUnitsTest()
        {
            // TODO unit test for the property 'CornerOffsetUnits'
        }
        /// <summary>
        /// Test the property 'MustMatchFields'
        /// </summary>
        [Test]
        public void MustMatchFieldsTest()
        {
            // TODO unit test for the property 'MustMatchFields'
        }
        /// <summary>
        /// Test the property 'ReturnFieldsDescriptor'
        /// </summary>
        [Test]
        public void ReturnFieldsDescriptorTest()
        {
            // TODO unit test for the property 'ReturnFieldsDescriptor'
        }
        /// <summary>
        /// Test the property 'OutputRecordType'
        /// </summary>
        [Test]
        public void OutputRecordTypeTest()
        {
            // TODO unit test for the property 'OutputRecordType'
        }
        /// <summary>
        /// Test the property 'CustomPreferences'
        /// </summary>
        [Test]
        public void CustomPreferencesTest()
        {
            // TODO unit test for the property 'CustomPreferences'
        }
        /// <summary>
        /// Test the property 'PreferredDictionaryOrders'
        /// </summary>
        [Test]
        public void PreferredDictionaryOrdersTest()
        {
            // TODO unit test for the property 'PreferredDictionaryOrders'
        }
        /// <summary>
        /// Test the property 'OutputCasing'
        /// </summary>
        [Test]
        public void OutputCasingTest()
        {
            // TODO unit test for the property 'OutputCasing'
        }
        /// <summary>
        /// Test the property 'LatLongOffset'
        /// </summary>
        [Test]
        public void LatLongOffsetTest()
        {
            // TODO unit test for the property 'LatLongOffset'
        }
        /// <summary>
        /// Test the property 'Squeeze'
        /// </summary>
        [Test]
        public void SqueezeTest()
        {
            // TODO unit test for the property 'Squeeze'
        }
        /// <summary>
        /// Test the property 'ReturnLatLongFields'
        /// </summary>
        [Test]
        public void ReturnLatLongFieldsTest()
        {
            // TODO unit test for the property 'ReturnLatLongFields'
        }
        /// <summary>
        /// Test the property 'UseGeoTaxAuxiliaryFile'
        /// </summary>
        [Test]
        public void UseGeoTaxAuxiliaryFileTest()
        {
            // TODO unit test for the property 'UseGeoTaxAuxiliaryFile'
        }
        /// <summary>
        /// Test the property 'LatLongFormat'
        /// </summary>
        [Test]
        public void LatLongFormatTest()
        {
            // TODO unit test for the property 'LatLongFormat'
        }
        /// <summary>
        /// Test the property 'DefaultBufferWidth'
        /// </summary>
        [Test]
        public void DefaultBufferWidthTest()
        {
            // TODO unit test for the property 'DefaultBufferWidth'
        }
        /// <summary>
        /// Test the property 'ReturnCensusFields'
        /// </summary>
        [Test]
        public void ReturnCensusFieldsTest()
        {
            // TODO unit test for the property 'ReturnCensusFields'
        }

    }

}
