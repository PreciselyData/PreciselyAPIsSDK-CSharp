/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// ZonesAddress
    /// </summary>
    [DataContract]
    public partial class ZonesAddress :  IEquatable<ZonesAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZonesAddress" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="streetSide">streetSide.</param>
        /// <param name="businessName">businessName.</param>
        /// <param name="addressLine1">addressLine1.</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressLine3">addressLine3.</param>
        /// <param name="city">city.</param>
        /// <param name="stateProvince">stateProvince.</param>
        /// <param name="county">county.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="status">status.</param>
        /// <param name="urbanizationName">urbanizationName.</param>
        /// <param name="formattedAddress">formattedAddress.</param>
        /// <param name="mainAddressLine">mainAddressLine.</param>
        /// <param name="addressLastLine">addressLastLine.</param>
        /// <param name="placeName">placeName.</param>
        /// <param name="areaName1">areaName1.</param>
        /// <param name="areaName2">areaName2.</param>
        /// <param name="areaName3">areaName3.</param>
        /// <param name="areaName4">areaName4.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="postCodeExt">postCodeExt.</param>
        /// <param name="country">country.</param>
        /// <param name="addressNumber">addressNumber.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="unitValue">unitValue.</param>
        public ZonesAddress(string objectId = default(string), string displayName = default(string), string streetSide = default(string), string businessName = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string city = default(string), string stateProvince = default(string), string county = default(string), string postalCode = default(string), string latitude = default(string), string longitude = default(string), string status = default(string), string urbanizationName = default(string), string formattedAddress = default(string), string mainAddressLine = default(string), string addressLastLine = default(string), string placeName = default(string), string areaName1 = default(string), string areaName2 = default(string), string areaName3 = default(string), string areaName4 = default(string), string postCode = default(string), string postCodeExt = default(string), string country = default(string), string addressNumber = default(string), string streetName = default(string), string unitType = default(string), string unitValue = default(string))
        {
            this.ObjectId = objectId;
            this.DisplayName = displayName;
            this.StreetSide = streetSide;
            this.BusinessName = businessName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.City = city;
            this.StateProvince = stateProvince;
            this.County = county;
            this.PostalCode = postalCode;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Status = status;
            this.UrbanizationName = urbanizationName;
            this.FormattedAddress = formattedAddress;
            this.MainAddressLine = mainAddressLine;
            this.AddressLastLine = addressLastLine;
            this.PlaceName = placeName;
            this.AreaName1 = areaName1;
            this.AreaName2 = areaName2;
            this.AreaName3 = areaName3;
            this.AreaName4 = areaName4;
            this.PostCode = postCode;
            this.PostCodeExt = postCodeExt;
            this.Country = country;
            this.AddressNumber = addressNumber;
            this.StreetName = streetName;
            this.UnitType = unitType;
            this.UnitValue = unitValue;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets StreetSide
        /// </summary>
        [DataMember(Name="streetSide", EmitDefaultValue=false)]
        public string StreetSide { get; set; }

        /// <summary>
        /// Gets or Sets BusinessName
        /// </summary>
        [DataMember(Name="businessName", EmitDefaultValue=false)]
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        [DataMember(Name="addressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        [DataMember(Name="addressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine3
        /// </summary>
        [DataMember(Name="addressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        [DataMember(Name="stateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public string County { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets UrbanizationName
        /// </summary>
        [DataMember(Name="urbanizationName", EmitDefaultValue=false)]
        public string UrbanizationName { get; set; }

        /// <summary>
        /// Gets or Sets FormattedAddress
        /// </summary>
        [DataMember(Name="formattedAddress", EmitDefaultValue=false)]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// Gets or Sets MainAddressLine
        /// </summary>
        [DataMember(Name="mainAddressLine", EmitDefaultValue=false)]
        public string MainAddressLine { get; set; }

        /// <summary>
        /// Gets or Sets AddressLastLine
        /// </summary>
        [DataMember(Name="addressLastLine", EmitDefaultValue=false)]
        public string AddressLastLine { get; set; }

        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or Sets AreaName1
        /// </summary>
        [DataMember(Name="areaName1", EmitDefaultValue=false)]
        public string AreaName1 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName2
        /// </summary>
        [DataMember(Name="areaName2", EmitDefaultValue=false)]
        public string AreaName2 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName3
        /// </summary>
        [DataMember(Name="areaName3", EmitDefaultValue=false)]
        public string AreaName3 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName4
        /// </summary>
        [DataMember(Name="areaName4", EmitDefaultValue=false)]
        public string AreaName4 { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets PostCodeExt
        /// </summary>
        [DataMember(Name="postCodeExt", EmitDefaultValue=false)]
        public string PostCodeExt { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets AddressNumber
        /// </summary>
        [DataMember(Name="addressNumber", EmitDefaultValue=false)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public string UnitType { get; set; }

        /// <summary>
        /// Gets or Sets UnitValue
        /// </summary>
        [DataMember(Name="unitValue", EmitDefaultValue=false)]
        public string UnitValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZonesAddress {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  StreetSide: ").Append(StreetSide).Append("\n");
            sb.Append("  BusinessName: ").Append(BusinessName).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UrbanizationName: ").Append(UrbanizationName).Append("\n");
            sb.Append("  FormattedAddress: ").Append(FormattedAddress).Append("\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  AddressLastLine: ").Append(AddressLastLine).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName2: ").Append(AreaName2).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  PostCodeExt: ").Append(PostCodeExt).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ZonesAddress);
        }

        /// <summary>
        /// Returns true if ZonesAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of ZonesAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZonesAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.StreetSide == input.StreetSide ||
                    (this.StreetSide != null &&
                    this.StreetSide.Equals(input.StreetSide))
                ) && 
                (
                    this.BusinessName == input.BusinessName ||
                    (this.BusinessName != null &&
                    this.BusinessName.Equals(input.BusinessName))
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UrbanizationName == input.UrbanizationName ||
                    (this.UrbanizationName != null &&
                    this.UrbanizationName.Equals(input.UrbanizationName))
                ) && 
                (
                    this.FormattedAddress == input.FormattedAddress ||
                    (this.FormattedAddress != null &&
                    this.FormattedAddress.Equals(input.FormattedAddress))
                ) && 
                (
                    this.MainAddressLine == input.MainAddressLine ||
                    (this.MainAddressLine != null &&
                    this.MainAddressLine.Equals(input.MainAddressLine))
                ) && 
                (
                    this.AddressLastLine == input.AddressLastLine ||
                    (this.AddressLastLine != null &&
                    this.AddressLastLine.Equals(input.AddressLastLine))
                ) && 
                (
                    this.PlaceName == input.PlaceName ||
                    (this.PlaceName != null &&
                    this.PlaceName.Equals(input.PlaceName))
                ) && 
                (
                    this.AreaName1 == input.AreaName1 ||
                    (this.AreaName1 != null &&
                    this.AreaName1.Equals(input.AreaName1))
                ) && 
                (
                    this.AreaName2 == input.AreaName2 ||
                    (this.AreaName2 != null &&
                    this.AreaName2.Equals(input.AreaName2))
                ) && 
                (
                    this.AreaName3 == input.AreaName3 ||
                    (this.AreaName3 != null &&
                    this.AreaName3.Equals(input.AreaName3))
                ) && 
                (
                    this.AreaName4 == input.AreaName4 ||
                    (this.AreaName4 != null &&
                    this.AreaName4.Equals(input.AreaName4))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.PostCodeExt == input.PostCodeExt ||
                    (this.PostCodeExt != null &&
                    this.PostCodeExt.Equals(input.PostCodeExt))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AddressNumber == input.AddressNumber ||
                    (this.AddressNumber != null &&
                    this.AddressNumber.Equals(input.AddressNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
                ) && 
                (
                    this.UnitValue == input.UnitValue ||
                    (this.UnitValue != null &&
                    this.UnitValue.Equals(input.UnitValue))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.StreetSide != null)
                    hashCode = hashCode * 59 + this.StreetSide.GetHashCode();
                if (this.BusinessName != null)
                    hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UrbanizationName != null)
                    hashCode = hashCode * 59 + this.UrbanizationName.GetHashCode();
                if (this.FormattedAddress != null)
                    hashCode = hashCode * 59 + this.FormattedAddress.GetHashCode();
                if (this.MainAddressLine != null)
                    hashCode = hashCode * 59 + this.MainAddressLine.GetHashCode();
                if (this.AddressLastLine != null)
                    hashCode = hashCode * 59 + this.AddressLastLine.GetHashCode();
                if (this.PlaceName != null)
                    hashCode = hashCode * 59 + this.PlaceName.GetHashCode();
                if (this.AreaName1 != null)
                    hashCode = hashCode * 59 + this.AreaName1.GetHashCode();
                if (this.AreaName2 != null)
                    hashCode = hashCode * 59 + this.AreaName2.GetHashCode();
                if (this.AreaName3 != null)
                    hashCode = hashCode * 59 + this.AreaName3.GetHashCode();
                if (this.AreaName4 != null)
                    hashCode = hashCode * 59 + this.AreaName4.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.PostCodeExt != null)
                    hashCode = hashCode * 59 + this.PostCodeExt.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressNumber != null)
                    hashCode = hashCode * 59 + this.AddressNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.UnitValue != null)
                    hashCode = hashCode * 59 + this.UnitValue.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
