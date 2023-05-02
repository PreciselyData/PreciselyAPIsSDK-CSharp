/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.0
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
    /// PBKeyResponseList
    /// </summary>
    [DataContract]
    public partial class PBKeyResponseList :  IEquatable<PBKeyResponseList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PBKeyResponseList" /> class.
        /// </summary>
        /// <param name="pbkey">pbkey.</param>
        public PBKeyResponseList(List<Pbkey> pbkey = default(List<Pbkey>))
        {
            this.Pbkey = pbkey;
        }

        /// <summary>
        /// Gets or Sets Pbkey
        /// </summary>
        [DataMember(Name="pbkey", EmitDefaultValue=false)]
        public List<Pbkey> Pbkey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PBKeyResponseList {\n");
            sb.Append("  Pbkey: ").Append(Pbkey).Append("\n");
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
            return this.Equals(input as PBKeyResponseList);
        }

        /// <summary>
        /// Returns true if PBKeyResponseList instances are equal
        /// </summary>
        /// <param name="input">Instance of PBKeyResponseList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PBKeyResponseList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pbkey == input.Pbkey ||
                    this.Pbkey != null &&
                    input.Pbkey != null &&
                    this.Pbkey.SequenceEqual(input.Pbkey)
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
                if (this.Pbkey != null)
                    hashCode = hashCode * 59 + this.Pbkey.GetHashCode();
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
