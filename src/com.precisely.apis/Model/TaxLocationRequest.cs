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
    /// TaxLocationRequest
    /// </summary>
    [DataContract]
    public partial class TaxLocationRequest :  IEquatable<TaxLocationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxLocationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxLocationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxLocationRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="locations">locations (required).</param>
        public TaxLocationRequest(LocalTaxPreferences preferences = default(LocalTaxPreferences), List<TaxLocations> locations = default(List<TaxLocations>))
        {
            // to ensure "locations" is required (not null)
            if (locations == null)
            {
                throw new InvalidDataException("locations is a required property for TaxLocationRequest and cannot be null");
            }
            else
            {
                this.Locations = locations;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public LocalTaxPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name="locations", EmitDefaultValue=true)]
        public List<TaxLocations> Locations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxLocationRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
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
            return this.Equals(input as TaxLocationRequest);
        }

        /// <summary>
        /// Returns true if TaxLocationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxLocationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxLocationRequest input)
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
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
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
                if (this.Locations != null)
                    hashCode = hashCode * 59 + this.Locations.GetHashCode();
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
