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
    /// CandidateRangeUnit
    /// </summary>
    [DataContract]
    public partial class CandidateRangeUnit :  IEquatable<CandidateRangeUnit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CandidateRangeUnit" /> class.
        /// </summary>
        /// <param name="placeName">placeName.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="highUnitValue">highUnitValue.</param>
        /// <param name="lowUnitValue">lowUnitValue.</param>
        /// <param name="customValues">customValues.</param>
        public CandidateRangeUnit(string placeName = default(string), string unitType = default(string), string highUnitValue = default(string), string lowUnitValue = default(string), Dictionary<string, Object> customValues = default(Dictionary<string, Object>))
        {
            this.PlaceName = placeName;
            this.UnitType = unitType;
            this.HighUnitValue = highUnitValue;
            this.LowUnitValue = lowUnitValue;
            this.CustomValues = customValues;
        }

        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public string UnitType { get; set; }

        /// <summary>
        /// Gets or Sets HighUnitValue
        /// </summary>
        [DataMember(Name="highUnitValue", EmitDefaultValue=false)]
        public string HighUnitValue { get; set; }

        /// <summary>
        /// Gets or Sets LowUnitValue
        /// </summary>
        [DataMember(Name="lowUnitValue", EmitDefaultValue=false)]
        public string LowUnitValue { get; set; }

        /// <summary>
        /// Gets or Sets CustomValues
        /// </summary>
        [DataMember(Name="customValues", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CandidateRangeUnit {\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  HighUnitValue: ").Append(HighUnitValue).Append("\n");
            sb.Append("  LowUnitValue: ").Append(LowUnitValue).Append("\n");
            sb.Append("  CustomValues: ").Append(CustomValues).Append("\n");
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
            return this.Equals(input as CandidateRangeUnit);
        }

        /// <summary>
        /// Returns true if CandidateRangeUnit instances are equal
        /// </summary>
        /// <param name="input">Instance of CandidateRangeUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandidateRangeUnit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlaceName == input.PlaceName ||
                    (this.PlaceName != null &&
                    this.PlaceName.Equals(input.PlaceName))
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
                ) && 
                (
                    this.HighUnitValue == input.HighUnitValue ||
                    (this.HighUnitValue != null &&
                    this.HighUnitValue.Equals(input.HighUnitValue))
                ) && 
                (
                    this.LowUnitValue == input.LowUnitValue ||
                    (this.LowUnitValue != null &&
                    this.LowUnitValue.Equals(input.LowUnitValue))
                ) && 
                (
                    this.CustomValues == input.CustomValues ||
                    this.CustomValues != null &&
                    input.CustomValues != null &&
                    this.CustomValues.SequenceEqual(input.CustomValues)
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
                if (this.PlaceName != null)
                    hashCode = hashCode * 59 + this.PlaceName.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.HighUnitValue != null)
                    hashCode = hashCode * 59 + this.HighUnitValue.GetHashCode();
                if (this.LowUnitValue != null)
                    hashCode = hashCode * 59 + this.LowUnitValue.GetHashCode();
                if (this.CustomValues != null)
                    hashCode = hashCode * 59 + this.CustomValues.GetHashCode();
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
