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
    /// Boundaries
    /// </summary>
    [DataContract]
    public partial class Boundaries :  IEquatable<Boundaries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundaries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boundaries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundaries" /> class.
        /// </summary>
        /// <param name="boundaryType">boundaryType.</param>
        /// <param name="boundaryRef">boundaryRef.</param>
        /// <param name="boundary">boundary (required).</param>
        public Boundaries(string boundaryType = default(string), string boundaryRef = default(string), List<Boundary> boundary = default(List<Boundary>))
        {
            // to ensure "boundary" is required (not null)
            if (boundary == null)
            {
                throw new InvalidDataException("boundary is a required property for Boundaries and cannot be null");
            }
            else
            {
                this.Boundary = boundary;
            }

            this.BoundaryType = boundaryType;
            this.BoundaryRef = boundaryRef;
        }

        /// <summary>
        /// Gets or Sets BoundaryType
        /// </summary>
        [DataMember(Name="boundaryType", EmitDefaultValue=false)]
        public string BoundaryType { get; set; }

        /// <summary>
        /// Gets or Sets BoundaryRef
        /// </summary>
        [DataMember(Name="boundaryRef", EmitDefaultValue=false)]
        public string BoundaryRef { get; set; }

        /// <summary>
        /// Gets or Sets Boundary
        /// </summary>
        [DataMember(Name="boundary", EmitDefaultValue=true)]
        public List<Boundary> Boundary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boundaries {\n");
            sb.Append("  BoundaryType: ").Append(BoundaryType).Append("\n");
            sb.Append("  BoundaryRef: ").Append(BoundaryRef).Append("\n");
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
            return this.Equals(input as Boundaries);
        }

        /// <summary>
        /// Returns true if Boundaries instances are equal
        /// </summary>
        /// <param name="input">Instance of Boundaries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boundaries input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundaryType == input.BoundaryType ||
                    (this.BoundaryType != null &&
                    this.BoundaryType.Equals(input.BoundaryType))
                ) && 
                (
                    this.BoundaryRef == input.BoundaryRef ||
                    (this.BoundaryRef != null &&
                    this.BoundaryRef.Equals(input.BoundaryRef))
                ) && 
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
                if (this.BoundaryType != null)
                    hashCode = hashCode * 59 + this.BoundaryType.GetHashCode();
                if (this.BoundaryRef != null)
                    hashCode = hashCode * 59 + this.BoundaryRef.GetHashCode();
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
