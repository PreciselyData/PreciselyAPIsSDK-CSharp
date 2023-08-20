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
    /// TimezoneAddressRequest
    /// </summary>
    [DataContract]
    public partial class TimezoneAddressRequest :  IEquatable<TimezoneAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneAddressRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="addressTime">addressTime.</param>
        public TimezoneAddressRequest(PreferencTimeZone preferences = default(PreferencTimeZone), List<AddressTime> addressTime = default(List<AddressTime>))
        {
            this.Preferences = preferences;
            this.AddressTime = addressTime;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public PreferencTimeZone Preferences { get; set; }

        /// <summary>
        /// Gets or Sets AddressTime
        /// </summary>
        [DataMember(Name="addressTime", EmitDefaultValue=false)]
        public List<AddressTime> AddressTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimezoneAddressRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  AddressTime: ").Append(AddressTime).Append("\n");
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
            return this.Equals(input as TimezoneAddressRequest);
        }

        /// <summary>
        /// Returns true if TimezoneAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TimezoneAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimezoneAddressRequest input)
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
                    this.AddressTime == input.AddressTime ||
                    this.AddressTime != null &&
                    input.AddressTime != null &&
                    this.AddressTime.SequenceEqual(input.AddressTime)
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
                if (this.AddressTime != null)
                    hashCode = hashCode * 59 + this.AddressTime.GetHashCode();
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
