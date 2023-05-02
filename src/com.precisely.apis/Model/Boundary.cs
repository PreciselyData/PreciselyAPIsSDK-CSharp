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
    /// Boundary
    /// </summary>
    [DataContract]
    public partial class Boundary :  IEquatable<Boundary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundary" /> class.
        /// </summary>
        /// <param name="boundaryId">boundaryId.</param>
        /// <param name="boundaryType">boundaryType.</param>
        /// <param name="boundaryRef">boundaryRef.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="url">url.</param>
        public Boundary(string boundaryId = default(string), string boundaryType = default(string), string boundaryRef = default(string), DemographicsGeometry geometry = default(DemographicsGeometry), string url = default(string))
        {
            this.BoundaryId = boundaryId;
            this.BoundaryType = boundaryType;
            this.BoundaryRef = boundaryRef;
            this.Geometry = geometry;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets BoundaryId
        /// </summary>
        [DataMember(Name="boundaryId", EmitDefaultValue=false)]
        public string BoundaryId { get; set; }

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
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public DemographicsGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boundary {\n");
            sb.Append("  BoundaryId: ").Append(BoundaryId).Append("\n");
            sb.Append("  BoundaryType: ").Append(BoundaryType).Append("\n");
            sb.Append("  BoundaryRef: ").Append(BoundaryRef).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Boundary);
        }

        /// <summary>
        /// Returns true if Boundary instances are equal
        /// </summary>
        /// <param name="input">Instance of Boundary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boundary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundaryId == input.BoundaryId ||
                    (this.BoundaryId != null &&
                    this.BoundaryId.Equals(input.BoundaryId))
                ) && 
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
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.BoundaryId != null)
                    hashCode = hashCode * 59 + this.BoundaryId.GetHashCode();
                if (this.BoundaryType != null)
                    hashCode = hashCode * 59 + this.BoundaryType.GetHashCode();
                if (this.BoundaryRef != null)
                    hashCode = hashCode * 59 + this.BoundaryRef.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
