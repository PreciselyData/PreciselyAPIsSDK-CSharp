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
    /// FireRiskResponseList
    /// </summary>
    [DataContract]
    public partial class FireRiskResponseList :  IEquatable<FireRiskResponseList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireRiskResponseList" /> class.
        /// </summary>
        /// <param name="fireRisk">fireRisk.</param>
        public FireRiskResponseList(List<FireRiskResponse> fireRisk = default(List<FireRiskResponse>))
        {
            this.FireRisk = fireRisk;
        }

        /// <summary>
        /// Gets or Sets FireRisk
        /// </summary>
        [DataMember(Name="fireRisk", EmitDefaultValue=false)]
        public List<FireRiskResponse> FireRisk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireRiskResponseList {\n");
            sb.Append("  FireRisk: ").Append(FireRisk).Append("\n");
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
            return this.Equals(input as FireRiskResponseList);
        }

        /// <summary>
        /// Returns true if FireRiskResponseList instances are equal
        /// </summary>
        /// <param name="input">Instance of FireRiskResponseList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireRiskResponseList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FireRisk == input.FireRisk ||
                    this.FireRisk != null &&
                    input.FireRisk != null &&
                    this.FireRisk.SequenceEqual(input.FireRisk)
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
                if (this.FireRisk != null)
                    hashCode = hashCode * 59 + this.FireRisk.GetHashCode();
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
