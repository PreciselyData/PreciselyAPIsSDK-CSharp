/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// FormattedTaxAddress
    /// </summary>
    [DataContract]
    public partial class FormattedTaxAddress :  IEquatable<FormattedTaxAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormattedTaxAddress" /> class.
        /// </summary>
        /// <param name="mainAddressLine">mainAddressLine.</param>
        /// <param name="addressNumber">addressNumber.</param>
        /// <param name="streetPreDirection">streetPreDirection.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="streetType">streetType.</param>
        /// <param name="streetPostDirection">streetPostDirection.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="unitValue">unitValue.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="postCode1">postCode1.</param>
        /// <param name="postCode2">postCode2.</param>
        public FormattedTaxAddress(string mainAddressLine = default(string), string addressNumber = default(string), string streetPreDirection = default(string), string streetName = default(string), string streetType = default(string), string streetPostDirection = default(string), string unitType = default(string), string unitValue = default(string), string city = default(string), string state = default(string), string postCode1 = default(string), string postCode2 = default(string))
        {
            this.MainAddressLine = mainAddressLine;
            this.AddressNumber = addressNumber;
            this.StreetPreDirection = streetPreDirection;
            this.StreetName = streetName;
            this.StreetType = streetType;
            this.StreetPostDirection = streetPostDirection;
            this.UnitType = unitType;
            this.UnitValue = unitValue;
            this.City = city;
            this.State = state;
            this.PostCode1 = postCode1;
            this.PostCode2 = postCode2;
        }

        /// <summary>
        /// Gets or Sets MainAddressLine
        /// </summary>
        [DataMember(Name="mainAddressLine", EmitDefaultValue=false)]
        public string MainAddressLine { get; set; }

        /// <summary>
        /// Gets or Sets AddressNumber
        /// </summary>
        [DataMember(Name="addressNumber", EmitDefaultValue=false)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetPreDirection
        /// </summary>
        [DataMember(Name="streetPreDirection", EmitDefaultValue=false)]
        public string StreetPreDirection { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets StreetType
        /// </summary>
        [DataMember(Name="streetType", EmitDefaultValue=false)]
        public string StreetType { get; set; }

        /// <summary>
        /// Gets or Sets StreetPostDirection
        /// </summary>
        [DataMember(Name="streetPostDirection", EmitDefaultValue=false)]
        public string StreetPostDirection { get; set; }

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
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PostCode1
        /// </summary>
        [DataMember(Name="postCode1", EmitDefaultValue=false)]
        public string PostCode1 { get; set; }

        /// <summary>
        /// Gets or Sets PostCode2
        /// </summary>
        [DataMember(Name="postCode2", EmitDefaultValue=false)]
        public string PostCode2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormattedTaxAddress {\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetPreDirection: ").Append(StreetPreDirection).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  StreetType: ").Append(StreetType).Append("\n");
            sb.Append("  StreetPostDirection: ").Append(StreetPostDirection).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PostCode1: ").Append(PostCode1).Append("\n");
            sb.Append("  PostCode2: ").Append(PostCode2).Append("\n");
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
            return this.Equals(input as FormattedTaxAddress);
        }

        /// <summary>
        /// Returns true if FormattedTaxAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of FormattedTaxAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormattedTaxAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MainAddressLine == input.MainAddressLine ||
                    (this.MainAddressLine != null &&
                    this.MainAddressLine.Equals(input.MainAddressLine))
                ) && 
                (
                    this.AddressNumber == input.AddressNumber ||
                    (this.AddressNumber != null &&
                    this.AddressNumber.Equals(input.AddressNumber))
                ) && 
                (
                    this.StreetPreDirection == input.StreetPreDirection ||
                    (this.StreetPreDirection != null &&
                    this.StreetPreDirection.Equals(input.StreetPreDirection))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.StreetType == input.StreetType ||
                    (this.StreetType != null &&
                    this.StreetType.Equals(input.StreetType))
                ) && 
                (
                    this.StreetPostDirection == input.StreetPostDirection ||
                    (this.StreetPostDirection != null &&
                    this.StreetPostDirection.Equals(input.StreetPostDirection))
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
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PostCode1 == input.PostCode1 ||
                    (this.PostCode1 != null &&
                    this.PostCode1.Equals(input.PostCode1))
                ) && 
                (
                    this.PostCode2 == input.PostCode2 ||
                    (this.PostCode2 != null &&
                    this.PostCode2.Equals(input.PostCode2))
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
                if (this.MainAddressLine != null)
                    hashCode = hashCode * 59 + this.MainAddressLine.GetHashCode();
                if (this.AddressNumber != null)
                    hashCode = hashCode * 59 + this.AddressNumber.GetHashCode();
                if (this.StreetPreDirection != null)
                    hashCode = hashCode * 59 + this.StreetPreDirection.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.StreetType != null)
                    hashCode = hashCode * 59 + this.StreetType.GetHashCode();
                if (this.StreetPostDirection != null)
                    hashCode = hashCode * 59 + this.StreetPostDirection.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.UnitValue != null)
                    hashCode = hashCode * 59 + this.UnitValue.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PostCode1 != null)
                    hashCode = hashCode * 59 + this.PostCode1.GetHashCode();
                if (this.PostCode2 != null)
                    hashCode = hashCode * 59 + this.PostCode2.GetHashCode();
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
