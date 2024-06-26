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
    /// GeoLocationIpAddr
    /// </summary>
    [DataContract]
    public partial class GeoLocationIpAddr :  IEquatable<GeoLocationIpAddr>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeoLocationIpAddr" /> class.
        /// </summary>
        /// <param name="geometry">geometry.</param>
        /// <param name="accuracy">accuracy.</param>
        /// <param name="ipInfo">ipInfo.</param>
        public GeoLocationIpAddr(GeolocationGeometry geometry = default(GeolocationGeometry), Accuracy accuracy = default(Accuracy), IpInfo ipInfo = default(IpInfo))
        {
            this.Geometry = geometry;
            this.Accuracy = accuracy;
            this.IpInfo = ipInfo;
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
        /// Gets or Sets IpInfo
        /// </summary>
        [DataMember(Name="ipInfo", EmitDefaultValue=false)]
        public IpInfo IpInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeoLocationIpAddr {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Accuracy: ").Append(Accuracy).Append("\n");
            sb.Append("  IpInfo: ").Append(IpInfo).Append("\n");
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
            return this.Equals(input as GeoLocationIpAddr);
        }

        /// <summary>
        /// Returns true if GeoLocationIpAddr instances are equal
        /// </summary>
        /// <param name="input">Instance of GeoLocationIpAddr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeoLocationIpAddr input)
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
                ) && 
                (
                    this.IpInfo == input.IpInfo ||
                    (this.IpInfo != null &&
                    this.IpInfo.Equals(input.IpInfo))
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
                if (this.IpInfo != null)
                    hashCode = hashCode * 59 + this.IpInfo.GetHashCode();
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
