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
    /// SalesVolume
    /// </summary>
    [DataContract]
    public partial class SalesVolume :  IEquatable<SalesVolume>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesVolume" /> class.
        /// </summary>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="worldBaseCurrencyCode">worldBaseCurrencyCode.</param>
        /// <param name="value">value.</param>
        public SalesVolume(string currencyCode = default(string), string worldBaseCurrencyCode = default(string), string value = default(string))
        {
            this.CurrencyCode = currencyCode;
            this.WorldBaseCurrencyCode = worldBaseCurrencyCode;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets WorldBaseCurrencyCode
        /// </summary>
        [DataMember(Name="worldBaseCurrencyCode", EmitDefaultValue=false)]
        public string WorldBaseCurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesVolume {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  WorldBaseCurrencyCode: ").Append(WorldBaseCurrencyCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as SalesVolume);
        }

        /// <summary>
        /// Returns true if SalesVolume instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesVolume to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesVolume input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.WorldBaseCurrencyCode == input.WorldBaseCurrencyCode ||
                    (this.WorldBaseCurrencyCode != null &&
                    this.WorldBaseCurrencyCode.Equals(input.WorldBaseCurrencyCode))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.WorldBaseCurrencyCode != null)
                    hashCode = hashCode * 59 + this.WorldBaseCurrencyCode.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
