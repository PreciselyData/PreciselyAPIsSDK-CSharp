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
    /// RisksBoundaries
    /// </summary>
    [DataContract]
    public partial class RisksBoundaries :  IEquatable<RisksBoundaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RisksBoundaries" /> class.
        /// </summary>
        /// <param name="boundary">boundary.</param>
        public RisksBoundaries(List<CrimeBoundary> boundary = default(List<CrimeBoundary>))
        {
            this.Boundary = boundary;
        }

        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name="boundary", EmitDefaultValue=false)]
        public List<CrimeBoundary> Boundary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RisksBoundaries {\n");
            sb.Append("  Boundary: ").Append(Boundary).Append("\n");
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
            return this.Equals(input as RisksBoundaries);
        }

        /// <summary>
        /// Returns true if RisksBoundaries instances are equal
        /// </summary>
        /// <param name="input">Instance of RisksBoundaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RisksBoundaries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Boundary == input.Boundary ||
                    this.Boundary != null &&
                    input.Boundary != null &&
                    this.Boundary.SequenceEqual(input.Boundary)
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
                if (this.Boundary != null)
                    hashCode = hashCode * 59 + this.Boundary.GetHashCode();
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
