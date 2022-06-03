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
    /// ValidateMailingAddressUSCANAPIInput
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressUSCANAPIInput :  IEquatable<ValidateMailingAddressUSCANAPIInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressUSCANAPIInput" /> class.
        /// </summary>
        /// <param name="row">row.</param>
        public ValidateMailingAddressUSCANAPIInput(List<ValidateMailingAddressUSCANAPIInputRow> row = default(List<ValidateMailingAddressUSCANAPIInputRow>))
        {
            this.Row = row;
        }

        /// <summary>
        /// Gets or Sets Row
        /// </summary>
        [DataMember(Name="Row", EmitDefaultValue=false)]
        public List<ValidateMailingAddressUSCANAPIInputRow> Row { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateMailingAddressUSCANAPIInput {\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
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
            return this.Equals(input as ValidateMailingAddressUSCANAPIInput);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressUSCANAPIInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateMailingAddressUSCANAPIInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressUSCANAPIInput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Row == input.Row ||
                    this.Row != null &&
                    input.Row != null &&
                    this.Row.SequenceEqual(input.Row)
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
                if (this.Row != null)
                    hashCode = hashCode * 59 + this.Row.GetHashCode();
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
