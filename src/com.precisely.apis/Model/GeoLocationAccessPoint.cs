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
    /// GeoLocationAccessPoint
    /// </summary>
    [DataContract]
    public partial class GeoLocationAccessPoint :  IEquatable<GeoLocationAccessPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationAccessPoint" /> class.
        /// </summary>
        /// <param name="geometry">geometry.</param>
        /// <param name="accuracy">accuracy.</param>
        public GeoLocationAccessPoint(GeolocationGeometry geometry = default(GeolocationGeometry), Accuracy accuracy = default(Accuracy))
        {
            this.Geometry = geometry;
            this.Accuracy = accuracy;
        }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public GeolocationGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets Accuracy
        /// </summary>
        [DataMember(Name="accuracy", EmitDefaultValue=false)]
        public Accuracy Accuracy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationAccessPoint {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
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
            return this.Equals(input as GeoLocationAccessPoint);
        }

        /// <summary>
        /// Returns true if GeoLocationAccessPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoLocationAccessPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationAccessPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.Accuracy == input.Accuracy ||
                    (this.Accuracy != null &&
                    this.Accuracy.Equals(input.Accuracy))
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Accuracy != null)
                    hashCode = hashCode * 59 + this.Accuracy.GetHashCode();
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
