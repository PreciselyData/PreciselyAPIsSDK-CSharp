/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 14.0.0
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
    ///  Class for testing RoutingServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RoutingServiceApiTests
    {
        private RoutingServiceApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RoutingServiceApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RoutingServiceApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // test 'IsInstanceOfType' RoutingServiceApi
            Assert.IsInstanceOf(typeof(RoutingServiceApi), instance, "instance is a RoutingServiceApi");
        }

        
        /// <summary>
        /// Test GetRouteByAddress
        /// </summary>
        [Test]
        public void GetRouteByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startAddress = null;
            //string endAddress = null;
            //string db = null;
            //string country = null;
            //string intermediateAddresses = null;
            //string returnIntermediatePoints = null;
            //string oip = null;
            //string destinationSrs = null;
            //string optimizeBy = null;
            //string returnDistance = null;
            //string distanceUnit = null;
            //string returnTime = null;
            //string timeUnit = null;
            //string language = null;
            //string directionsStyle = null;
            //string segmentGeometryStyle = null;
            //string primaryNameOnly = null;
            //string majorRoads = null;
            //string historicTrafficTimeBucket = null;
            //string returnDirectionGeometry = null;
            //string useCvr = null;
            //string looseningBarrierRestrictions = null;
            //string vehicleType = null;
            //string weight = null;
            //string weightUnit = null;
            //string height = null;
            //string heightUnit = null;
            //string length = null;
            //string lengthUnit = null;
            //string width = null;
            //string widthUnit = null;
            //var response = instance.GetRouteByAddress(startAddressendAddressdbcountryintermediateAddressesreturnIntermediatePointsoipdestinationSrsoptimizeByreturnDistancedistanceUnitreturnTimetimeUnitlanguagedirectionsStylesegmentGeometryStyleprimaryNameOnlymajorRoadshistoricTrafficTimeBucketreturnDirectionGeometryuseCvrlooseningBarrierRestrictionsvehicleTypeweightweightUnitheightheightUnitlengthlengthUnitwidthwidthUnit);
            //Assert.IsInstanceOf<RouteResponse> (response, "response is RouteResponse");
        }
        
        /// <summary>
        /// Test GetRouteByLocation
        /// </summary>
        [Test]
        public void GetRouteByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startPoint = null;
            //string endPoint = null;
            //string db = null;
            //string intermediatePoints = null;
            //string returnIntermediatePoints = null;
            //string oip = null;
            //string destinationSrs = null;
            //string optimizeBy = null;
            //string returnDistance = null;
            //string distanceUnit = null;
            //string returnTime = null;
            //string timeUnit = null;
            //string language = null;
            //string directionsStyle = null;
            //string segmentGeometryStyle = null;
            //string primaryNameOnly = null;
            //string majorRoads = null;
            //string historicTrafficTimeBucket = null;
            //string returnDirectionGeometry = null;
            //string useCvr = null;
            //string looseningBarrierRestrictions = null;
            //string vehicleType = null;
            //string weight = null;
            //string weightUnit = null;
            //string height = null;
            //string heightUnit = null;
            //string length = null;
            //string lengthUnit = null;
            //string width = null;
            //string widthUnit = null;
            //var response = instance.GetRouteByLocation(startPointendPointdbintermediatePointsreturnIntermediatePointsoipdestinationSrsoptimizeByreturnDistancedistanceUnitreturnTimetimeUnitlanguagedirectionsStylesegmentGeometryStyleprimaryNameOnlymajorRoadshistoricTrafficTimeBucketreturnDirectionGeometryuseCvrlooseningBarrierRestrictionsvehicleTypeweightweightUnitheightheightUnitlengthlengthUnitwidthwidthUnit);
            //Assert.IsInstanceOf<RouteResponse> (response, "response is RouteResponse");
        }
        
        /// <summary>
        /// Test GetTravelCostMatrixByAddress
        /// </summary>
        [Test]
        public void GetTravelCostMatrixByAddressTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startAddresses = null;
            //string endAddresses = null;
            //string country = null;
            //string db = null;
            //string optimizeBy = null;
            //string returnDistance = null;
            //string destinationSrs = null;
            //string distanceUnit = null;
            //string returnTime = null;
            //string timeUnit = null;
            //string majorRoads = null;
            //string returnOptimalRoutesOnly = null;
            //string historicTrafficTimeBucket = null;
            //string useCvr = null;
            //string looseningBarrierRestrictions = null;
            //string vehicleType = null;
            //string weight = null;
            //string weightUnit = null;
            //string height = null;
            //string heightUnit = null;
            //string length = null;
            //string lengthUnit = null;
            //string width = null;
            //string widthUnit = null;
            //var response = instance.GetTravelCostMatrixByAddress(startAddressesendAddressescountrydboptimizeByreturnDistancedestinationSrsdistanceUnitreturnTimetimeUnitmajorRoadsreturnOptimalRoutesOnlyhistoricTrafficTimeBucketuseCvrlooseningBarrierRestrictionsvehicleTypeweightweightUnitheightheightUnitlengthlengthUnitwidthwidthUnit);
            //Assert.IsInstanceOf<TravelCostMatrixResponse> (response, "response is TravelCostMatrixResponse");
        }
        
        /// <summary>
        /// Test GetTravelCostMatrixByLocation
        /// </summary>
        [Test]
        public void GetTravelCostMatrixByLocationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string startPoints = null;
            //string endPoints = null;
            //string db = null;
            //string optimizeBy = null;
            //string returnDistance = null;
            //string destinationSrs = null;
            //string distanceUnit = null;
            //string returnTime = null;
            //string timeUnit = null;
            //string majorRoads = null;
            //string returnOptimalRoutesOnly = null;
            //string historicTrafficTimeBucket = null;
            //string useCvr = null;
            //string looseningBarrierRestrictions = null;
            //string vehicleType = null;
            //string weight = null;
            //string weightUnit = null;
            //string height = null;
            //string heightUnit = null;
            //string length = null;
            //string lengthUnit = null;
            //string width = null;
            //string widthUnit = null;
            //var response = instance.GetTravelCostMatrixByLocation(startPointsendPointsdboptimizeByreturnDistancedestinationSrsdistanceUnitreturnTimetimeUnitmajorRoadsreturnOptimalRoutesOnlyhistoricTrafficTimeBucketuseCvrlooseningBarrierRestrictionsvehicleTypeweightweightUnitheightheightUnitlengthlengthUnitwidthwidthUnit);
            //Assert.IsInstanceOf<TravelCostMatrixResponse> (response, "response is TravelCostMatrixResponse");
        }
        
    }

}
