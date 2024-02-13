/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.0.0
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
    /// FloodRiskByAddressRequest
    /// </summary>
    [DataContract]
    public partial class FloodRiskByAddressRequest :  IEquatable<FloodRiskByAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodRiskByAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FloodRiskByAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FloodRiskByAddressRequest" /> class.
        /// </summary>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="preferences">preferences.</param>
        public FloodRiskByAddressRequest(List<RiskAddress> addresses = default(List<RiskAddress>), FloodRiskPreferences preferences = default(FloodRiskPreferences))
        {
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new InvalidDataException("addresses is a required property for FloodRiskByAddressRequest and cannot be null");
            }
            else
            {
                this.Addresses = addresses;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=true)]
        public List<RiskAddress> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public FloodRiskPreferences Preferences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FloodRiskByAddressRequest {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
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
            return this.Equals(input as FloodRiskByAddressRequest);
        }

        /// <summary>
        /// Returns true if FloodRiskByAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FloodRiskByAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloodRiskByAddressRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
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
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
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
