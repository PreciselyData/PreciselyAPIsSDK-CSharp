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
    /// TaxRateAddressRequest
    /// </summary>
    [DataContract]
    public partial class TaxRateAddressRequest :  IEquatable<TaxRateAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxRateAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateAddressRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="taxRateAddresses">taxRateAddresses (required).</param>
        public TaxRateAddressRequest(LocalTaxPreferences preferences = default(LocalTaxPreferences), List<TaxRateAddress> taxRateAddresses = default(List<TaxRateAddress>))
        {
            // to ensure "taxRateAddresses" is required (not null)
            if (taxRateAddresses == null)
            {
                throw new InvalidDataException("taxRateAddresses is a required property for TaxRateAddressRequest and cannot be null");
            }
            else
            {
                this.TaxRateAddresses = taxRateAddresses;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public LocalTaxPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets TaxRateAddresses
        /// </summary>
        [DataMember(Name="taxRateAddresses", EmitDefaultValue=true)]
        public List<TaxRateAddress> TaxRateAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRateAddressRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  TaxRateAddresses: ").Append(TaxRateAddresses).Append("\n");
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
            return this.Equals(input as TaxRateAddressRequest);
        }

        /// <summary>
        /// Returns true if TaxRateAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRateAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRateAddressRequest input)
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
                    this.TaxRateAddresses == input.TaxRateAddresses ||
                    this.TaxRateAddresses != null &&
                    input.TaxRateAddresses != null &&
                    this.TaxRateAddresses.SequenceEqual(input.TaxRateAddresses)
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
                if (this.TaxRateAddresses != null)
                    hashCode = hashCode * 59 + this.TaxRateAddresses.GetHashCode();
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
