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
    /// ReverseGeocodeRequest
    /// </summary>
    [DataContract]
    public partial class ReverseGeocodeRequest :  IEquatable<ReverseGeocodeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReverseGeocodeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseGeocodeRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="points">points (required).</param>
        public ReverseGeocodeRequest(GeocodePreferences preferences = default(GeocodePreferences), List<Points> points = default(List<Points>))
        {
            // to ensure "points" is required (not null)
            if (points == null)
            {
                throw new InvalidDataException("points is a required property for ReverseGeocodeRequest and cannot be null");
            }
            else
            {
                this.Points = points;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public GeocodePreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=true)]
        public List<Points> Points { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReverseGeocodeRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
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
            return this.Equals(input as ReverseGeocodeRequest);
        }

        /// <summary>
        /// Returns true if ReverseGeocodeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ReverseGeocodeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReverseGeocodeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.Points == input.Points ||
                    this.Points != null &&
                    input.Points != null &&
                    this.Points.SequenceEqual(input.Points)
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
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
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
