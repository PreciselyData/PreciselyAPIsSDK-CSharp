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
    /// PropertyInfoAddressRequest
    /// </summary>
    [DataContract]
    public partial class PropertyInfoAddressRequest :  IEquatable<PropertyInfoAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfoAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PropertyInfoAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfoAddressRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences (required).</param>
        /// <param name="addresses">addresses (required).</param>
        public PropertyInfoAddressRequest(PropertyInfoPreferences preferences = default(PropertyInfoPreferences), List<MatchedAddress> addresses = default(List<MatchedAddress>))
        {
            // to ensure "preferences" is required (not null)
            if (preferences == null)
            {
                throw new InvalidDataException("preferences is a required property for PropertyInfoAddressRequest and cannot be null");
            }
            else
            {
                this.Preferences = preferences;
            }

            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new InvalidDataException("addresses is a required property for PropertyInfoAddressRequest and cannot be null");
            }
            else
            {
                this.Addresses = addresses;
            }

        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=true)]
        public PropertyInfoPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=true)]
        public List<MatchedAddress> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyInfoAddressRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
            return this.Equals(input as PropertyInfoAddressRequest);
        }

        /// <summary>
        /// Returns true if PropertyInfoAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyInfoAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyInfoAddressRequest input)
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
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
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
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
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
