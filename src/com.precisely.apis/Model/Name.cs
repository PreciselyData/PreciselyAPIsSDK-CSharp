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
    /// Name
    /// </summary>
    [DataContract]
    public partial class Name :  IEquatable<Name>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Name" /> class.
        /// </summary>
        /// <param name="langISOCode">langISOCode.</param>
        /// <param name="langType">langType.</param>
        /// <param name="value">value.</param>
        public Name(string langISOCode = default(string), string langType = default(string), string value = default(string))
        {
            this.LangISOCode = langISOCode;
            this.LangType = langType;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets LangISOCode
        /// </summary>
        [DataMember(Name="langISOCode", EmitDefaultValue=false)]
        public string LangISOCode { get; set; }

        /// <summary>
        /// Gets or Sets LangType
        /// </summary>
        [DataMember(Name="langType", EmitDefaultValue=false)]
        public string LangType { get; set; }

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
            sb.Append("class Name {\n");
            sb.Append("  LangISOCode: ").Append(LangISOCode).Append("\n");
            sb.Append("  LangType: ").Append(LangType).Append("\n");
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
            return this.Equals(input as Name);
        }

        /// <summary>
        /// Returns true if Name instances are equal
        /// </summary>
        /// <param name="input">Instance of Name to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Name input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LangISOCode == input.LangISOCode ||
                    (this.LangISOCode != null &&
                    this.LangISOCode.Equals(input.LangISOCode))
                ) && 
                (
                    this.LangType == input.LangType ||
                    (this.LangType != null &&
                    this.LangType.Equals(input.LangType))
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
                if (this.LangISOCode != null)
                    hashCode = hashCode * 59 + this.LangISOCode.GetHashCode();
                if (this.LangType != null)
                    hashCode = hashCode * 59 + this.LangType.GetHashCode();
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
