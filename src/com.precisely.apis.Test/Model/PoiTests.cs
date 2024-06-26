/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    ///  Class for testing Poi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PoiTests
    {
        // TODO uncomment below to declare an instance variable for Poi
        //private Poi instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Poi
            //instance = new Poi();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Poi
        /// </summary>
        [Test]
        public void PoiInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Poi
            //Assert.IsInstanceOf(typeof(Poi), instance);
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'PoiId'
        /// </summary>
        [Test]
        public void PoiIdTest()
        {
            // TODO unit test for the property 'PoiId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Pbkey'
        /// </summary>
        [Test]
        public void PbkeyTest()
        {
            // TODO unit test for the property 'Pbkey'
        }
        /// <summary>
        /// Test the property 'ParentPbkey'
        /// </summary>
        [Test]
        public void ParentPbkeyTest()
        {
            // TODO unit test for the property 'ParentPbkey'
        }
        /// <summary>
        /// Test the property 'GeocodeConfidence'
        /// </summary>
        [Test]
        public void GeocodeConfidenceTest()
        {
            // TODO unit test for the property 'GeocodeConfidence'
        }
        /// <summary>
        /// Test the property 'BrandName'
        /// </summary>
        [Test]
        public void BrandNameTest()
        {
            // TODO unit test for the property 'BrandName'
        }
        /// <summary>
        /// Test the property 'TradeName'
        /// </summary>
        [Test]
        public void TradeNameTest()
        {
            // TODO unit test for the property 'TradeName'
        }
        /// <summary>
        /// Test the property 'FranchiseName'
        /// </summary>
        [Test]
        public void FranchiseNameTest()
        {
            // TODO unit test for the property 'FranchiseName'
        }
        /// <summary>
        /// Test the property 'Open24Hours'
        /// </summary>
        [Test]
        public void Open24HoursTest()
        {
            // TODO unit test for the property 'Open24Hours'
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
        /// Test the property 'BusinessId'
        /// </summary>
        [Test]
        public void BusinessIdTest()
        {
            // TODO unit test for the property 'BusinessId'
        }
        /// <summary>
        /// Test the property 'RelevanceScore'
        /// </summary>
        [Test]
        public void RelevanceScoreTest()
        {
            // TODO unit test for the property 'RelevanceScore'
        }
        /// <summary>
        /// Test the property 'ContactDetails'
        /// </summary>
        [Test]
        public void ContactDetailsTest()
        {
            // TODO unit test for the property 'ContactDetails'
        }
        /// <summary>
        /// Test the property 'PoiClassification'
        /// </summary>
        [Test]
        public void PoiClassificationTest()
        {
            // TODO unit test for the property 'PoiClassification'
        }
        /// <summary>
        /// Test the property 'SalesVolume'
        /// </summary>
        [Test]
        public void SalesVolumeTest()
        {
            // TODO unit test for the property 'SalesVolume'
        }
        /// <summary>
        /// Test the property 'EmployeeCount'
        /// </summary>
        [Test]
        public void EmployeeCountTest()
        {
            // TODO unit test for the property 'EmployeeCount'
        }
        /// <summary>
        /// Test the property 'YearStart'
        /// </summary>
        [Test]
        public void YearStartTest()
        {
            // TODO unit test for the property 'YearStart'
        }
        /// <summary>
        /// Test the property 'GoodsAgentCode'
        /// </summary>
        [Test]
        public void GoodsAgentCodeTest()
        {
            // TODO unit test for the property 'GoodsAgentCode'
        }
        /// <summary>
        /// Test the property 'GoodsAgentCodeDescription'
        /// </summary>
        [Test]
        public void GoodsAgentCodeDescriptionTest()
        {
            // TODO unit test for the property 'GoodsAgentCodeDescription'
        }
        /// <summary>
        /// Test the property 'LegalStatusCode'
        /// </summary>
        [Test]
        public void LegalStatusCodeTest()
        {
            // TODO unit test for the property 'LegalStatusCode'
        }
        /// <summary>
        /// Test the property 'OrganizationStatusCode'
        /// </summary>
        [Test]
        public void OrganizationStatusCodeTest()
        {
            // TODO unit test for the property 'OrganizationStatusCode'
        }
        /// <summary>
        /// Test the property 'OrganizationStatusCodeDescription'
        /// </summary>
        [Test]
        public void OrganizationStatusCodeDescriptionTest()
        {
            // TODO unit test for the property 'OrganizationStatusCodeDescription'
        }
        /// <summary>
        /// Test the property 'SubsidaryIndicator'
        /// </summary>
        [Test]
        public void SubsidaryIndicatorTest()
        {
            // TODO unit test for the property 'SubsidaryIndicator'
        }
        /// <summary>
        /// Test the property 'SubsidaryIndicatorDescription'
        /// </summary>
        [Test]
        public void SubsidaryIndicatorDescriptionTest()
        {
            // TODO unit test for the property 'SubsidaryIndicatorDescription'
        }
        /// <summary>
        /// Test the property 'ParentBusiness'
        /// </summary>
        [Test]
        public void ParentBusinessTest()
        {
            // TODO unit test for the property 'ParentBusiness'
        }
        /// <summary>
        /// Test the property 'DomesticUltimateBusiness'
        /// </summary>
        [Test]
        public void DomesticUltimateBusinessTest()
        {
            // TODO unit test for the property 'DomesticUltimateBusiness'
        }
        /// <summary>
        /// Test the property 'GlobalUltimateIndicator'
        /// </summary>
        [Test]
        public void GlobalUltimateIndicatorTest()
        {
            // TODO unit test for the property 'GlobalUltimateIndicator'
        }
        /// <summary>
        /// Test the property 'GlobalUltimateBusiness'
        /// </summary>
        [Test]
        public void GlobalUltimateBusinessTest()
        {
            // TODO unit test for the property 'GlobalUltimateBusiness'
        }
        /// <summary>
        /// Test the property 'FamilyMembers'
        /// </summary>
        [Test]
        public void FamilyMembersTest()
        {
            // TODO unit test for the property 'FamilyMembers'
        }
        /// <summary>
        /// Test the property 'HierarchyCode'
        /// </summary>
        [Test]
        public void HierarchyCodeTest()
        {
            // TODO unit test for the property 'HierarchyCode'
        }
        /// <summary>
        /// Test the property 'TickerSymbol'
        /// </summary>
        [Test]
        public void TickerSymbolTest()
        {
            // TODO unit test for the property 'TickerSymbol'
        }
        /// <summary>
        /// Test the property 'ExchangeName'
        /// </summary>
        [Test]
        public void ExchangeNameTest()
        {
            // TODO unit test for the property 'ExchangeName'
        }
        /// <summary>
        /// Test the property 'CeoName'
        /// </summary>
        [Test]
        public void CeoNameTest()
        {
            // TODO unit test for the property 'CeoName'
        }
        /// <summary>
        /// Test the property 'CeoTitle'
        /// </summary>
        [Test]
        public void CeoTitleTest()
        {
            // TODO unit test for the property 'CeoTitle'
        }
        /// <summary>
        /// Test the property 'Geometry'
        /// </summary>
        [Test]
        public void GeometryTest()
        {
            // TODO unit test for the property 'Geometry'
        }

    }

}
