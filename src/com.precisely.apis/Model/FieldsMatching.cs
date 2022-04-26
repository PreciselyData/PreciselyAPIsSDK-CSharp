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
    /// FieldsMatching
    /// </summary>
    [DataContract]
    public partial class FieldsMatching :  IEquatable<FieldsMatching>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsMatching" /> class.
        /// </summary>
        /// <param name="matchOnAddressNumber">matchOnAddressNumber.</param>
        /// <param name="matchOnPostCode1">matchOnPostCode1.</param>
        /// <param name="matchOnPostCode2">matchOnPostCode2.</param>
        /// <param name="matchOnAreaName1">matchOnAreaName1.</param>
        /// <param name="matchOnAreaName2">matchOnAreaName2.</param>
        /// <param name="matchOnAreaName3">matchOnAreaName3.</param>
        /// <param name="matchOnAreaName4">matchOnAreaName4.</param>
        /// <param name="matchOnAllStreetFields">matchOnAllStreetFields.</param>
        /// <param name="matchOnStreetName">matchOnStreetName.</param>
        /// <param name="matchOnStreetType">matchOnStreetType.</param>
        /// <param name="matchOnStreetDirectional">matchOnStreetDirectional.</param>
        /// <param name="matchOnPlaceName">matchOnPlaceName.</param>
        /// <param name="matchOnInputFields">matchOnInputFields.</param>
        public FieldsMatching(bool matchOnAddressNumber = default(bool), bool matchOnPostCode1 = default(bool), bool matchOnPostCode2 = default(bool), bool matchOnAreaName1 = default(bool), bool matchOnAreaName2 = default(bool), bool matchOnAreaName3 = default(bool), bool matchOnAreaName4 = default(bool), bool matchOnAllStreetFields = default(bool), bool matchOnStreetName = default(bool), bool matchOnStreetType = default(bool), bool matchOnStreetDirectional = default(bool), bool matchOnPlaceName = default(bool), bool matchOnInputFields = default(bool))
        {
            this.MatchOnAddressNumber = matchOnAddressNumber;
            this.MatchOnPostCode1 = matchOnPostCode1;
            this.MatchOnPostCode2 = matchOnPostCode2;
            this.MatchOnAreaName1 = matchOnAreaName1;
            this.MatchOnAreaName2 = matchOnAreaName2;
            this.MatchOnAreaName3 = matchOnAreaName3;
            this.MatchOnAreaName4 = matchOnAreaName4;
            this.MatchOnAllStreetFields = matchOnAllStreetFields;
            this.MatchOnStreetName = matchOnStreetName;
            this.MatchOnStreetType = matchOnStreetType;
            this.MatchOnStreetDirectional = matchOnStreetDirectional;
            this.MatchOnPlaceName = matchOnPlaceName;
            this.MatchOnInputFields = matchOnInputFields;
        }

        /// <summary>
        /// Gets or Sets MatchOnAddressNumber
        /// </summary>
        [DataMember(Name="matchOnAddressNumber", EmitDefaultValue=false)]
        public bool MatchOnAddressNumber { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnPostCode1
        /// </summary>
        [DataMember(Name="matchOnPostCode1", EmitDefaultValue=false)]
        public bool MatchOnPostCode1 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnPostCode2
        /// </summary>
        [DataMember(Name="matchOnPostCode2", EmitDefaultValue=false)]
        public bool MatchOnPostCode2 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnAreaName1
        /// </summary>
        [DataMember(Name="matchOnAreaName1", EmitDefaultValue=false)]
        public bool MatchOnAreaName1 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnAreaName2
        /// </summary>
        [DataMember(Name="matchOnAreaName2", EmitDefaultValue=false)]
        public bool MatchOnAreaName2 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnAreaName3
        /// </summary>
        [DataMember(Name="matchOnAreaName3", EmitDefaultValue=false)]
        public bool MatchOnAreaName3 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnAreaName4
        /// </summary>
        [DataMember(Name="matchOnAreaName4", EmitDefaultValue=false)]
        public bool MatchOnAreaName4 { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnAllStreetFields
        /// </summary>
        [DataMember(Name="matchOnAllStreetFields", EmitDefaultValue=false)]
        public bool MatchOnAllStreetFields { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnStreetName
        /// </summary>
        [DataMember(Name="matchOnStreetName", EmitDefaultValue=false)]
        public bool MatchOnStreetName { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnStreetType
        /// </summary>
        [DataMember(Name="matchOnStreetType", EmitDefaultValue=false)]
        public bool MatchOnStreetType { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnStreetDirectional
        /// </summary>
        [DataMember(Name="matchOnStreetDirectional", EmitDefaultValue=false)]
        public bool MatchOnStreetDirectional { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnPlaceName
        /// </summary>
        [DataMember(Name="matchOnPlaceName", EmitDefaultValue=false)]
        public bool MatchOnPlaceName { get; set; }

        /// <summary>
        /// Gets or Sets MatchOnInputFields
        /// </summary>
        [DataMember(Name="matchOnInputFields", EmitDefaultValue=false)]
        public bool MatchOnInputFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldsMatching {\n");
            sb.Append("  MatchOnAddressNumber: ").Append(MatchOnAddressNumber).Append("\n");
            sb.Append("  MatchOnPostCode1: ").Append(MatchOnPostCode1).Append("\n");
            sb.Append("  MatchOnPostCode2: ").Append(MatchOnPostCode2).Append("\n");
            sb.Append("  MatchOnAreaName1: ").Append(MatchOnAreaName1).Append("\n");
            sb.Append("  MatchOnAreaName2: ").Append(MatchOnAreaName2).Append("\n");
            sb.Append("  MatchOnAreaName3: ").Append(MatchOnAreaName3).Append("\n");
            sb.Append("  MatchOnAreaName4: ").Append(MatchOnAreaName4).Append("\n");
            sb.Append("  MatchOnAllStreetFields: ").Append(MatchOnAllStreetFields).Append("\n");
            sb.Append("  MatchOnStreetName: ").Append(MatchOnStreetName).Append("\n");
            sb.Append("  MatchOnStreetType: ").Append(MatchOnStreetType).Append("\n");
            sb.Append("  MatchOnStreetDirectional: ").Append(MatchOnStreetDirectional).Append("\n");
            sb.Append("  MatchOnPlaceName: ").Append(MatchOnPlaceName).Append("\n");
            sb.Append("  MatchOnInputFields: ").Append(MatchOnInputFields).Append("\n");
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
            return this.Equals(input as FieldsMatching);
        }

        /// <summary>
        /// Returns true if FieldsMatching instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldsMatching to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldsMatching input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MatchOnAddressNumber == input.MatchOnAddressNumber ||
                    (this.MatchOnAddressNumber != null &&
                    this.MatchOnAddressNumber.Equals(input.MatchOnAddressNumber))
                ) && 
                (
                    this.MatchOnPostCode1 == input.MatchOnPostCode1 ||
                    (this.MatchOnPostCode1 != null &&
                    this.MatchOnPostCode1.Equals(input.MatchOnPostCode1))
                ) && 
                (
                    this.MatchOnPostCode2 == input.MatchOnPostCode2 ||
                    (this.MatchOnPostCode2 != null &&
                    this.MatchOnPostCode2.Equals(input.MatchOnPostCode2))
                ) && 
                (
                    this.MatchOnAreaName1 == input.MatchOnAreaName1 ||
                    (this.MatchOnAreaName1 != null &&
                    this.MatchOnAreaName1.Equals(input.MatchOnAreaName1))
                ) && 
                (
                    this.MatchOnAreaName2 == input.MatchOnAreaName2 ||
                    (this.MatchOnAreaName2 != null &&
                    this.MatchOnAreaName2.Equals(input.MatchOnAreaName2))
                ) && 
                (
                    this.MatchOnAreaName3 == input.MatchOnAreaName3 ||
                    (this.MatchOnAreaName3 != null &&
                    this.MatchOnAreaName3.Equals(input.MatchOnAreaName3))
                ) && 
                (
                    this.MatchOnAreaName4 == input.MatchOnAreaName4 ||
                    (this.MatchOnAreaName4 != null &&
                    this.MatchOnAreaName4.Equals(input.MatchOnAreaName4))
                ) && 
                (
                    this.MatchOnAllStreetFields == input.MatchOnAllStreetFields ||
                    (this.MatchOnAllStreetFields != null &&
                    this.MatchOnAllStreetFields.Equals(input.MatchOnAllStreetFields))
                ) && 
                (
                    this.MatchOnStreetName == input.MatchOnStreetName ||
                    (this.MatchOnStreetName != null &&
                    this.MatchOnStreetName.Equals(input.MatchOnStreetName))
                ) && 
                (
                    this.MatchOnStreetType == input.MatchOnStreetType ||
                    (this.MatchOnStreetType != null &&
                    this.MatchOnStreetType.Equals(input.MatchOnStreetType))
                ) && 
                (
                    this.MatchOnStreetDirectional == input.MatchOnStreetDirectional ||
                    (this.MatchOnStreetDirectional != null &&
                    this.MatchOnStreetDirectional.Equals(input.MatchOnStreetDirectional))
                ) && 
                (
                    this.MatchOnPlaceName == input.MatchOnPlaceName ||
                    (this.MatchOnPlaceName != null &&
                    this.MatchOnPlaceName.Equals(input.MatchOnPlaceName))
                ) && 
                (
                    this.MatchOnInputFields == input.MatchOnInputFields ||
                    (this.MatchOnInputFields != null &&
                    this.MatchOnInputFields.Equals(input.MatchOnInputFields))
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
                if (this.MatchOnAddressNumber != null)
                    hashCode = hashCode * 59 + this.MatchOnAddressNumber.GetHashCode();
                if (this.MatchOnPostCode1 != null)
                    hashCode = hashCode * 59 + this.MatchOnPostCode1.GetHashCode();
                if (this.MatchOnPostCode2 != null)
                    hashCode = hashCode * 59 + this.MatchOnPostCode2.GetHashCode();
                if (this.MatchOnAreaName1 != null)
                    hashCode = hashCode * 59 + this.MatchOnAreaName1.GetHashCode();
                if (this.MatchOnAreaName2 != null)
                    hashCode = hashCode * 59 + this.MatchOnAreaName2.GetHashCode();
                if (this.MatchOnAreaName3 != null)
                    hashCode = hashCode * 59 + this.MatchOnAreaName3.GetHashCode();
                if (this.MatchOnAreaName4 != null)
                    hashCode = hashCode * 59 + this.MatchOnAreaName4.GetHashCode();
                if (this.MatchOnAllStreetFields != null)
                    hashCode = hashCode * 59 + this.MatchOnAllStreetFields.GetHashCode();
                if (this.MatchOnStreetName != null)
                    hashCode = hashCode * 59 + this.MatchOnStreetName.GetHashCode();
                if (this.MatchOnStreetType != null)
                    hashCode = hashCode * 59 + this.MatchOnStreetType.GetHashCode();
                if (this.MatchOnStreetDirectional != null)
                    hashCode = hashCode * 59 + this.MatchOnStreetDirectional.GetHashCode();
                if (this.MatchOnPlaceName != null)
                    hashCode = hashCode * 59 + this.MatchOnPlaceName.GetHashCode();
                if (this.MatchOnInputFields != null)
                    hashCode = hashCode * 59 + this.MatchOnInputFields.GetHashCode();
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
