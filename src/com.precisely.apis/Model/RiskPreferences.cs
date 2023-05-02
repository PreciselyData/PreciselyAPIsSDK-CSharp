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
    /// RiskPreferences
    /// </summary>
    [DataContract]
    public partial class RiskPreferences :  IEquatable<RiskPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskPreferences" /> class.
        /// </summary>
        /// <param name="includeGeometry">includeGeometry.</param>
        /// <param name="includeZoneDesc">includeZoneDesc.</param>
        /// <param name="richterValue">richterValue.</param>
        public RiskPreferences(string includeGeometry = default(string), string includeZoneDesc = default(string), string richterValue = default(string))
        {
            this.IncludeGeometry = includeGeometry;
            this.IncludeZoneDesc = includeZoneDesc;
            this.RichterValue = richterValue;
        }

        /// <summary>
        /// Gets or Sets IncludeGeometry
        /// </summary>
        [DataMember(Name="includeGeometry", EmitDefaultValue=false)]
        public string IncludeGeometry { get; set; }

        /// <summary>
        /// Gets or Sets IncludeZoneDesc
        /// </summary>
        [DataMember(Name="includeZoneDesc", EmitDefaultValue=false)]
        public string IncludeZoneDesc { get; set; }

        /// <summary>
        /// Gets or Sets RichterValue
        /// </summary>
        [DataMember(Name="richterValue", EmitDefaultValue=false)]
        public string RichterValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskPreferences {\n");
            sb.Append("  IncludeGeometry: ").Append(IncludeGeometry).Append("\n");
            sb.Append("  IncludeZoneDesc: ").Append(IncludeZoneDesc).Append("\n");
            sb.Append("  RichterValue: ").Append(RichterValue).Append("\n");
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
            return this.Equals(input as RiskPreferences);
        }

        /// <summary>
        /// Returns true if RiskPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of RiskPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncludeGeometry == input.IncludeGeometry ||
                    (this.IncludeGeometry != null &&
                    this.IncludeGeometry.Equals(input.IncludeGeometry))
                ) && 
                (
                    this.IncludeZoneDesc == input.IncludeZoneDesc ||
                    (this.IncludeZoneDesc != null &&
                    this.IncludeZoneDesc.Equals(input.IncludeZoneDesc))
                ) && 
                (
                    this.RichterValue == input.RichterValue ||
                    (this.RichterValue != null &&
                    this.RichterValue.Equals(input.RichterValue))
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
                if (this.IncludeGeometry != null)
                    hashCode = hashCode * 59 + this.IncludeGeometry.GetHashCode();
                if (this.IncludeZoneDesc != null)
                    hashCode = hashCode * 59 + this.IncludeZoneDesc.GetHashCode();
                if (this.RichterValue != null)
                    hashCode = hashCode * 59 + this.RichterValue.GetHashCode();
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
