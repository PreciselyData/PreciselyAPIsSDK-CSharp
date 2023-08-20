/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.3
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
    /// POIBoundaryResponse
    /// </summary>
    [DataContract]
    public partial class POIBoundaryResponse :  IEquatable<POIBoundaryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIBoundaryResponse" /> class.
        /// </summary>
        /// <param name="poiBoundary">poiBoundary.</param>
        public POIBoundaryResponse(List<PoiBoundary> poiBoundary = default(List<PoiBoundary>))
        {
            this.PoiBoundary = poiBoundary;
        }

        /// <summary>
        /// Gets or Sets PoiBoundary
        /// </summary>
        [DataMember(Name="poiBoundary", EmitDefaultValue=false)]
        public List<PoiBoundary> PoiBoundary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class POIBoundaryResponse {\n");
            sb.Append("  PoiBoundary: ").Append(PoiBoundary).Append("\n");
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
            return this.Equals(input as POIBoundaryResponse);
        }

        /// <summary>
        /// Returns true if POIBoundaryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of POIBoundaryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIBoundaryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PoiBoundary == input.PoiBoundary ||
                    this.PoiBoundary != null &&
                    input.PoiBoundary != null &&
                    this.PoiBoundary.SequenceEqual(input.PoiBoundary)
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
                if (this.PoiBoundary != null)
                    hashCode = hashCode * 59 + this.PoiBoundary.GetHashCode();
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
