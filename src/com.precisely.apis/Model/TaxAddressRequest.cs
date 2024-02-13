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
    /// TaxAddressRequest
    /// </summary>
    [DataContract]
    public partial class TaxAddressRequest :  IEquatable<TaxAddressRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAddressRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxAddressRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxAddressRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="taxAddresses">taxAddresses (required).</param>
        public TaxAddressRequest(LocalTaxPreferences preferences = default(LocalTaxPreferences), List<TaxAddress> taxAddresses = default(List<TaxAddress>))
        {
            // to ensure "taxAddresses" is required (not null)
            if (taxAddresses == null)
            {
                throw new InvalidDataException("taxAddresses is a required property for TaxAddressRequest and cannot be null");
            }
            else
            {
                this.TaxAddresses = taxAddresses;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public LocalTaxPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets TaxAddresses
        /// </summary>
        [DataMember(Name="taxAddresses", EmitDefaultValue=true)]
        public List<TaxAddress> TaxAddresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxAddressRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  TaxAddresses: ").Append(TaxAddresses).Append("\n");
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
            return this.Equals(input as TaxAddressRequest);
        }

        /// <summary>
        /// Returns true if TaxAddressRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxAddressRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxAddressRequest input)
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
                    this.TaxAddresses == input.TaxAddresses ||
                    this.TaxAddresses != null &&
                    input.TaxAddresses != null &&
                    this.TaxAddresses.SequenceEqual(input.TaxAddresses)
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
                if (this.TaxAddresses != null)
                    hashCode = hashCode * 59 + this.TaxAddresses.GetHashCode();
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
