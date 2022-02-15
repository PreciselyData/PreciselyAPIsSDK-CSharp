/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.2
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
    /// PhoneVerification
    /// </summary>
    [DataContract]
    public partial class PhoneVerification :  IEquatable<PhoneVerification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneVerification" /> class.
        /// </summary>
        /// <param name="phoneNumber">phoneNumber.</param>
        /// <param name="locatable">locatable.</param>
        /// <param name="network">network.</param>
        /// <param name="privacyConsentRequired">privacyConsentRequired.</param>
        public PhoneVerification(string phoneNumber = default(string), string locatable = default(string), DeviceStatusNetwork network = default(DeviceStatusNetwork), string privacyConsentRequired = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.Locatable = locatable;
            this.Network = network;
            this.PrivacyConsentRequired = privacyConsentRequired;
        }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets Locatable
        /// </summary>
        [DataMember(Name="locatable", EmitDefaultValue=false)]
        public string Locatable { get; set; }

        /// <summary>
        /// Gets or Sets Network
        /// </summary>
        [DataMember(Name="network", EmitDefaultValue=false)]
        public DeviceStatusNetwork Network { get; set; }

        /// <summary>
        /// Gets or Sets PrivacyConsentRequired
        /// </summary>
        [DataMember(Name="privacyConsentRequired", EmitDefaultValue=false)]
        public string PrivacyConsentRequired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneVerification {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  Locatable: ").Append(Locatable).Append("\n");
            sb.Append("  Network: ").Append(Network).Append("\n");
            sb.Append("  PrivacyConsentRequired: ").Append(PrivacyConsentRequired).Append("\n");
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
            return this.Equals(input as PhoneVerification);
        }

        /// <summary>
        /// Returns true if PhoneVerification instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneVerification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.Locatable == input.Locatable ||
                    (this.Locatable != null &&
                    this.Locatable.Equals(input.Locatable))
                ) && 
                (
                    this.Network == input.Network ||
                    (this.Network != null &&
                    this.Network.Equals(input.Network))
                ) && 
                (
                    this.PrivacyConsentRequired == input.PrivacyConsentRequired ||
                    (this.PrivacyConsentRequired != null &&
                    this.PrivacyConsentRequired.Equals(input.PrivacyConsentRequired))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.Locatable != null)
                    hashCode = hashCode * 59 + this.Locatable.GetHashCode();
                if (this.Network != null)
                    hashCode = hashCode * 59 + this.Network.GetHashCode();
                if (this.PrivacyConsentRequired != null)
                    hashCode = hashCode * 59 + this.PrivacyConsentRequired.GetHashCode();
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
